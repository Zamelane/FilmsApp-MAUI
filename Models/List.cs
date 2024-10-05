using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace FilmsApp.Models
{
    class List : ObservableObject
    {
        [ObservableProperty] string title;
        [ObservableProperty] ObservableCollection<Movie> movies;
    }
}
