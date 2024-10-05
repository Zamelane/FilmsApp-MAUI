using FilmsApp.Controllers;
using FilmsApp.Models;

namespace FilmsApp.Views;

public partial class FilmInfo : ContentPage
{
	public FilmInfo()
	{
		InitializeComponent();
		this.BindingContext = CoreController.topFilmsPage.BindingContext;
	}
}