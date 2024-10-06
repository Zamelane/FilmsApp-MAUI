using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace FilmsApp.Models
{
    public partial class MoviesList : ObservableObject
    {
        [ObservableProperty] private string title;
        [ObservableProperty] private ObservableCollection<Movie> movies;
    }
}
