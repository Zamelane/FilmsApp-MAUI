using CommunityToolkit.Mvvm.Input;
using FilmsApp.Controllers;
using FilmsApp.Models;
using FilmsApp.ViewModels;
using System.Windows.Input;

namespace FilmsApp.Views;

public partial class FilmsListsPage : ContentPage
{
	CoreController coreController = DependencyService.Get<CoreController>();
    public ICommand TapToListCommand { get; }
    public FilmsListsPage()
	{
		this.BindingContext = coreController.FilmsListsViewModel;
        coreController.FilmsListsPage = this;

        TapToListCommand = new Command<MoviesList>(TapToList);

        InitializeComponent();
    }

    private async void TapToList(MoviesList ml)
    {
        await Navigation.PushAsync(new TopFilmsPage(ml));
    }
}