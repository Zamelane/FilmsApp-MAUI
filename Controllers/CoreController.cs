using CommunityToolkit.Mvvm.ComponentModel;
using FilmsApp.ViewModels;
using FilmsApp.Views;

namespace FilmsApp.Controllers
{
    public partial class CoreController : ObservableObject, ICoreController
    {
        [ObservableProperty] private TopFilmsPage topFilmsPage;
        [ObservableProperty] private FilmsListsPage filmsListsPage;

        [ObservableProperty] private FilmsListsViewModel filmsListsViewModel = new();
        [ObservableProperty] private TopFilmsModel topFilmsModel = new();
        [ObservableProperty] private HomeViewModel homeViewModel = new();
    }
}
