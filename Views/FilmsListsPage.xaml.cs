using CommunityToolkit.Mvvm.Input;
using FilmsApp.Controllers;
using FilmsApp.ViewModels;
using System.Windows.Input;

namespace FilmsApp.Views;

public partial class FilmsListsPage : ContentPage
{
	CoreController coreController = DependencyService.Get<CoreController>();
    public FilmsListsPage()
	{
        InitializeComponent();
		this.BindingContext = coreController.FilmsListsViewModel;
        coreController.FilmsListsPage = this;
	}
}