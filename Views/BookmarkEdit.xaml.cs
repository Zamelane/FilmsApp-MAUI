using CommunityToolkit.Mvvm.Input;
using FilmsApp.Controllers;
using FilmsApp.Models;
using FilmsApp.ViewModels;
using System.Windows.Input;

namespace FilmsApp.Views;

public partial class BookmarkEdit : ContentPage
{
    CoreController coreController { get; set; } = DependencyService.Get<CoreController>();
    FilmsListsViewModel FilmsListsViewModel { get; set; }
    public ICommand ExitCommand { get; }
    public BookmarkEdit(Movie editMovie)
	{
        ExitCommand = new RelayCommand(Exit);
        InitializeComponent();
        FilmsListsViewModel = coreController.FilmsListsViewModel;
        this.BindingContext = this;

        StackLayout sl = new();

        foreach (MoviesList list in coreController.FilmsListsViewModel.Lists)
        {
            bool isChecked = false;

            foreach (Movie movie in list.Movies)
                if (movie.Title == editMovie.Title)
                    isChecked = true;

            CheckBox cb = new()
            {
                IsChecked = isChecked,
                AutomationId = list.Title
            };

            cb.CheckedChanged += (s, e) =>
            {
                CheckBox cbx = s as CheckBox;

                foreach (MoviesList list in coreController.FilmsListsViewModel.Lists)
                {
                    if (list.Title == cbx.AutomationId)
                        if (cbx.IsChecked)
                            list.Movies.Add(editMovie);
                        else list.Movies.Remove(editMovie);
                }

                coreController.FilmsListsViewModel.Update();
            };

            sl.Add(new StackLayout()
            {
                Orientation = StackOrientation.Horizontal,
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    cb,
                    new Label()
                    {
                        Text = list.Title,
                        Padding = 10
                    }
                }
            });
        }

        this.RootContent.Content = sl;
    }

    private void Exit()
    {
        Navigation.PopModalAsync();
    }
}