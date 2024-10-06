using FilmsApp.Controllers;
using FilmsApp.Models;
using FilmsApp.ViewModels;

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
        public TopFilmsPage(MoviesList mv)
        {
            InitializeComponent();
            var model = new TopFilmsModel();
            model.movies = mv.Movies;
            this.BindingContext = model;
        }
    }
}