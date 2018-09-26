using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INTERFACES;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Windows.Data;
using static INTERFACES.Interfaces;

namespace ViewModel
{
    public class AnimeListViewModel : ViewModelBase
	{
		#region carsCollection
		private ObservableCollection<AnimeViewModel> _animes;

		public ObservableCollection<AnimeViewModel> Animes
		{
			get
			{
				return _animes;
			}
			set

			{
				_animes = value;
				OnPropertyChanged("Cars");
			}
			}
		#endregion

		private ListCollectionView _view;

		public AnimeListViewModel()
		{
			_animes = new ObservableCollection<AnimeViewModel>();
			_view = (ListCollectionView)CollectionViewSource.GetDefaultView(_animes);
			GetAllCars();
			_filterCommand = new RelayCommand(param => this.FilterData());
			_createNewAnimeCommand = new RelayCommand(param => this.CreateNewCar(), param => this.CanCreateCar());
			FilterString = "";
		}

		private void GetAllCars()
		{
			foreach (var c in new BLNamespace.BL().getDataBase())
			{
				_animes.Add(new AnimeViewModel(c));
			}
		}

		public string FilterString
		{ get; set; }

		private ICommand _filterCommand;

		public ICommand FilterCommand
		{
			get
			{
				return _filterCommand;
			}
		}


		private void FilterData()
		{
			if (!String.IsNullOrEmpty(FilterString))
			{
				_view.Filter = (c) => ((AnimeViewModel)c).Name.Contains(FilterString);
			}
			else
			{
				_view.Filter = null;
			}
		}

		private AnimeViewModel _editedAnime;
		public AnimeViewModel EditedAnime
		{
			get
			{
				return _editedAnime;
			}
			set

			{
				_editedAnime = value;
				OnPropertyChanged(nameof(EditedAnime));
			}
			}


		private RelayCommand _createNewAnimeCommand;

		public RelayCommand CreateNewAnimeCommand
		{
			get
			{
				return _createNewAnimeCommand;
			}
			}


		private void CreateNewCar()
		{
			EditedAnime = new AnimeViewModel(new AnimeNamespace.Anime());
			EditedAnime.Name = "";
		}
		private bool CanCreateCar()
		{
			if (this.EditedAnime == null)
				return true;
			else if (!this.EditedAnime.HasErrors)
				return true;

			return false;
		}

	}
}