using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace FilmsApp.ViewModels
{
    public partial class FilmsListsViewModel : ObservableObject
    {
        [ObservableProperty] ObservableCollection<Models.List> lists = new();
    }
}
