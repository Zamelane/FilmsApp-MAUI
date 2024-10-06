using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using FilmsApp.Models;
using System.Windows.Input;
using FilmsApp.Controllers;
using CommunityToolkit.Mvvm.Input;

namespace FilmsApp.ViewModels
{
    public partial class FilmsListsViewModel : ObservableObject
    {
        [ObservableProperty] ObservableCollection<MoviesList> lists = new();
        public ICommand AddListCommand { get; }

        private async void AddList()
        {
            var name = await CoreController.filmsListsPage.DisplayPromptAsync(
                "Создание списка",
                "Введите название:",
                "ОК",
                "Отмена");

            if (name == String.Empty || name == null)
                await CoreController.filmsListsPage.DisplayAlert(
                    "Ошибка создания",
                    "Название списка не должно быть пустым",
                    "ОК");
            else
                lists.Add(new()
                {
                    Title = name,
                    Movies = new()
                });
        }

        public FilmsListsViewModel()
        {
            AddListCommand = new RelayCommand(AddList);
            lists.Add(new() { Movies = [], Title = "Мой листик" });
        }
    }
}
