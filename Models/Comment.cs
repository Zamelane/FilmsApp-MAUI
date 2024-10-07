using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace FilmsApp.Models
{
    public partial class Comment : ObservableObject
    {
        [ObservableProperty] private string commentText;
        [ObservableProperty] private int mark;
    }
}
