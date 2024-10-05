using FilmsApp.Controllers;

namespace FilmsApp.Views;

public partial class TopFilmsPage : ContentPage
{
	public TopFilmsPage()
	{
		InitializeComponent();
		CoreController.topFilmsPage = this;
	}
}