using CommunityToolkit.Mvvm.Input;
using FilmsApp.Controllers;
using FilmsApp.Models;
using FilmsApp.ViewModels;
using System.Windows.Input;

namespace FilmsApp.Views
{

    public partial class TopFilmsPage : ContentPage
    {
        CoreController coreController { get; set; } = DependencyService.Get<CoreController>();
        public TopFilmsModel TopFilmsModel { get; set; }
        public ICommand TapToFilmCommand { get; }
        public TopFilmsPage()
        {
            TopFilmsModel = coreController.TopFilmsModel;
            this.BindingContext = this;
            coreController.TopFilmsPage = this;

            TapToFilmCommand = new Command<Movie>(TapToFilm);

            InitializeComponent();
        }
        public TopFilmsPage(MoviesList mv)
        {
            var model = new TopFilmsModel();
            model.movies = mv.Movies;
            TopFilmsModel = model;
            this.BindingContext = this;

            TapToFilmCommand = new Command<Movie>(TapToFilm);

            Title = mv.Title;

            InitializeComponent();
        }

        private async void TapToFilm(Movie movie)
        {
            if (coreController != null)
                await Navigation.PushAsync(new FilmInfo(movie));
        }
    }
}