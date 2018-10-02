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
using System.Windows.Controls;

namespace UI
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
			_saveCommand = new RelayCommand(param => this.SaveData(), param => this.CanEditeAnime());
			_createNewAnimeCommand = new RelayCommand(param => this.CreateNewAnime(), param => this.CanCreateAnime());
			_deleteAnimeCommand = new RelayCommand(param => this.DeleteAnime());
		}



		private void GetAllCars()
		{
			foreach (var c in new BLNamespace.BL().getDataBase())
			{
				_animes.Add(new AnimeViewModel(c));
			}
		}


		private ICommand _saveCommand;

		public ICommand SaveCommand
		{
			get
			{
				return _saveCommand;
			}
		}


		private void SaveData()
		{
			_animes = Animes;
			EditedAnime = null;
			_editedAnime = null;
		}
		public void SetEditedAnime(AnimeViewModel anime)
		{
			EditedAnime = anime;
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
		private bool CanEditeAnime()
		{
			if (EditedAnime == null)
				return false;
			if (!EditedAnime.HasErrors)
				return true;
			return false;
		}
		private RelayCommand _deleteAnimeCommand;

		public RelayCommand DeleteAnimeCommand
		{
			get
			{
				return _deleteAnimeCommand;
			}
		}


		private void DeleteAnime()
		{
			Animes.Remove(EditedAnime);
			EditedAnime = null;
		}


		private RelayCommand _createNewAnimeCommand;

		public RelayCommand CreateNewAnimeCommand
		{
			get
			{
				return _createNewAnimeCommand;
			}
		}


		private void CreateNewAnime()
		{
			
			EditedAnime = new AnimeViewModel(new AnimeNamespace.Anime());
			EditedAnime.Name = "";
			Animes.Add(EditedAnime);
		}
		private bool CanCreateAnime()
		{
			if (this.EditedAnime == null)
				return true;
			if (!EditedAnime.HasErrors)
				return true;

			return false;
		}

	}
}