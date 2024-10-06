using FilmsApp.Controllers;

namespace FilmsApp.Views
{

    public partial class TopFilmsPage : ContentPage
    {
        CoreController coreController { get; set; } = DependencyService.Get<CoreController>();
        public TopFilmsPage()
        {
            InitializeComponent();
            this.BindingContext = coreController.TopFilmsModel;
            coreController.TopFilmsPage = this;
        }
    }
}