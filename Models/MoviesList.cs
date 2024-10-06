using CommunityToolkit.Mvvm.ComponentModel;
using FilmsApp.Controllers;
using System.Collections.ObjectModel;

namespace FilmsApp.Models
{
    public partial class MoviesList : ObservableObject
    {
        [ObservableProperty] private string title;
        [ObservableProperty] private ObservableCollection<Movie> movies;
        public string ImageUrl
        {
            get
            {
                if (movies.Count == 0)
                    return "https://pic.rutubelist.ru/video/51/71/51713cbcc3300bf70d5b70198e32984f.jpg";
                return movies.First().ImageUrl;
            }
        }
        public string FilmsCount
        {
            get
            {
                int count = movies.Count;
                string word = "фильм";

                switch (count % 10)
                {
                    case 0:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                        word += "ов";
                        break;
                    case 2:
                    case 3:
                    case 4:
                        word += "а";
                        break;
                }

                return $"{count} {word}";
            }
        }

        public void Update(CoreController cc)
        {
            OnPropertyChanged(nameof(FilmsCount));
            OnPropertyChanged(nameof(ImageUrl));
        }
    }
}
