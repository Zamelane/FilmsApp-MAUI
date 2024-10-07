using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace FilmsApp.Models
{
    public partial class Movie : ObservableObject
    {
        [ObservableProperty] private string imageUrl;
        [ObservableProperty] private string title;
        [ObservableProperty] private string genre;
        [ObservableProperty] private string description = "Без описания";
        [ObservableProperty] private ObservableCollection<Comment> comments = new();
    }
}
