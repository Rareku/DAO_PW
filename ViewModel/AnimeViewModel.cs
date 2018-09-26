using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using static INTERFACES.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace ViewModel
{ 
	public class AnimeViewModel : ViewModelBase
	{
		private IAnime _anime;

		public AnimeViewModel(IAnime anime)
		{
			_anime = anime;
		}


		[Required(ErrorMessage = "Anime must have a name")]
		[StringLength(10, MinimumLength = 3, ErrorMessage = "długość nazwy musi być...")]
		public string Name
		{
			get
			{
				return _anime.Name;
			}
			set

			{
				_anime.Name = value;
				OnPropertyChanged("Name");
				Validate();
			}
		}


		public int Day
		{
			get
			{
				return _anime.Day;
			}

			set

			{
				_anime.Day = value;
				OnPropertyChanged("Day");
				Validate();
			}
		}


		public int Length
		{
			get
			{
				return _anime.Length;
			}

			set

			{
				_anime.Length = value;
				OnPropertyChanged("Length");
				Validate();
			}
		}


		public void Validate()
		{
			var validationContext = new ValidationContext(this, null, null);
			var validationResults = new List<ValidationResult>();

			Validator.TryValidateObject(this, validationContext, validationResults, true);

			//usunięcie z listy błedów tych właściwości, 
			//dla których już nie ma błędów w validationResults
			foreach (var kv in _errors.ToList())
			{
				if (validationResults.All(r => r.MemberNames.All(m => m != kv.Key)))
				{
					_errors.Remove(kv.Key);
					OnErrorChanged(kv.Key);
				}
			}

			var q = from e in validationResults
					from m in e.MemberNames
					group e by m into g
					select g;

			foreach (var prop in q)
			{
				var messages = prop.Select(r => r.ErrorMessage).ToList();

				if (_errors.ContainsKey(prop.Key))
				{
					_errors.Remove(prop.Key);
				}
				_errors.Add(prop.Key, messages);
				OnErrorChanged(prop.Key);
			}
		}
	}
}
