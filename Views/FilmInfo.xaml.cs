using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FilmsApp.Controllers;
using FilmsApp.Models;
using FilmsApp.ViewModels;
using System.Windows.Input;

namespace FilmsApp.Views;

public partial class FilmInfo : ContentPage
{
    public ICommand BookmarkEditCommand { get; }
    public ICommand WriteCommentCommand { get; }
    public TopFilmsModel TopFilmsPageContext { get; set; }
    CoreController coreController { get; set; } = DependencyService.Get<CoreController>();
    public Movie SelectedMovie { get; set; }

    public FilmInfo(Movie movie)
    {
        SelectedMovie = movie;

        BookmarkEditCommand = new RelayCommand(BookmarkEdit);
        WriteCommentCommand = new RelayCommand(WriteComment);

        TopFilmsPageContext = coreController.TopFilmsModel;
        this.BindingContext = this;

        InitializeComponent();
    }

    public void BookmarkEdit()
    {
        Navigation.PushModalAsync(new BookmarkEdit(SelectedMovie));
    }

    public void WriteComment()
    {
        Navigation.PushModalAsync(new WriteCommentPage(SelectedMovie));
    }
}