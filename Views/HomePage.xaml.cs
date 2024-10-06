using FilmsApp.Controllers;

namespace FilmsApp.Views;

public partial class HomePage : ContentPage
{
    CoreController coreController { get; set; } = DependencyService.Get<CoreController>();
    public HomePage()
	{
		InitializeComponent();
		this.BindingContext = coreController.HomeViewModel;
	}
}