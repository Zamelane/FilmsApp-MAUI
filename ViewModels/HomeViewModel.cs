using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace FilmsApp.ViewModels
{
    public partial class HomeViewModel : ObservableObject
    {
        public ICommand NavigateToTopFilmsCommand { get; }
        public ICommand NavigateToFilmsListsCommand { get; }

        public HomeViewModel()
        {
            NavigateToTopFilmsCommand = new RelayCommand(NavigateToTopFilms);
            NavigateToFilmsListsCommand = new RelayCommand(NavigateToFilmsLists);
        }

        private void NavigateToTopFilms() => Shell.Current.GoToAsync("//TopFilmsPage");

        private void NavigateToFilmsLists() => Shell.Current.GoToAsync("//FilmsListsPage");
    }
}
