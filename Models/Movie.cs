using CommunityToolkit.Mvvm.ComponentModel;

namespace FilmsApp.Models
{
    public partial class Movie : ObservableObject
    {
        [ObservableProperty] private string imageUrl;
        [ObservableProperty] private string title;
        [ObservableProperty] private string genre;
        [ObservableProperty] private string description = "Без описания";
    }
}
