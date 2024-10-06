using FilmsApp.Controllers;

namespace FilmsApp.Views;

public partial class FilmsListsPage : ContentPage
{
	public FilmsListsPage()
	{
		InitializeComponent();
		CoreController.filmsListsPage = this;
	}
}