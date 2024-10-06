using CommunityToolkit.Mvvm.Input;
using FilmsApp.Controllers;
using FilmsApp.Models;
using FilmsApp.ViewModels;
using System.Windows.Input;

namespace FilmsApp.Views;

public partial class FilmInfo : ContentPage
{
    public ICommand BookmarkEditCommand { get; }
    public TopFilmsModel TopFilmsPageContext { get; set; }
    CoreController coreController { get; set; } = DependencyService.Get<CoreController>();
    public FilmInfo()
	{
        BookmarkEditCommand = new RelayCommand(BookmarkEdit);
        InitializeComponent();
		TopFilmsPageContext = coreController.TopFilmsModel;
        this.BindingContext = this;
    }

    public void BookmarkEdit()
    {
        Navigation.PushModalAsync(new BookmarkEdit(TopFilmsPageContext.SelectedMovie));
    }
}