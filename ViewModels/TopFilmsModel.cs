using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FilmsApp.Controllers;
using FilmsApp.Models;
using FilmsApp.Views;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace FilmsApp.ViewModels
{
    public partial class TopFilmsModel : ObservableObject
    {
        [ObservableProperty] public ObservableCollection<Movie> movies;
        [ObservableProperty] public Movie selectedMovie;
        public ICommand SelectMovieCommand { get; }
        CoreController coreController { get; set; }
        // Application.Current.MainPage.Handler.MauiContext.Services.GetService<CoreController>();
        private void SelectMovie()
        {
            if (coreController == null)
                coreController = DependencyService.Get<CoreController>();
            if (selectedMovie != null && coreController != null)
                coreController.TopFilmsPage.Navigation.PushAsync(new FilmInfo());
        }

        public TopFilmsModel()
        {
            SelectMovieCommand = new RelayCommand(SelectMovie);
            movies = new ObservableCollection<Movie>
            {
                new Movie
                {
                    ImageUrl = "https://media.zenfs.com/en/deadline.com/f4828a2dc3b1f582f028107367c854f8",
                    Title = "Какой-то фильм китайский",
                    Genre = "Фэнтези"
                },
                new Movie
                {
                    ImageUrl = "https://static.wikia.nocookie.net/roadwarrior/images/7/79/Friosa_vert_main_2764x4096_dom.jpg/revision/latest?cb=20240416191245",
                    Title = "Фуриоса: Хроники Безумного Макса",
                    Genre = "Боевик",
                    Description = "Маленькую Фуриосу похищают из благодатных Зелёных Земель и в качестве доказательства существования этого оазиса привозят главарю банды байкеров Дементусу, а тот на глазах у девочки жестоко убивает пришедшую ей на помощь мать. Вскоре он вознамеривается навести шороху в Пустоши — захватывает власть в Топливном городе и в обмен на торговый договор с Цитаделью отдаёт Фуриосу Несмертному Джо в будущие жёны.\r\n\r\n"
                },
                new Movie
                {
                    ImageUrl = "https://nyagan.life/system/Cover/images/000/064/584/big/obj_0_1614744479.jpg",
                    Title = "Пончары. Глобальное закругление",
                    Genre = "Комедия",
                    Description = "Пончары – милые, уморительные создания. Круглые как пончики и пушистые как хомячки. Но когда двух из них вдруг затягивает петля времени, выясняется, что в будущем пончары – музейные экспонаты наряду с динозаврами. Нужно срочно изменить ход истории и для этого они прокатятся по всем эпохам. Им всё в новинку и всё нипочём: хоть пещерные люди, хоть квадрокоптеры… А значит, впереди округлительные приключения!"
                },
                new Movie
                {
                    ImageUrl = "https://media.zenfs.com/en/deadline.com/f4828a2dc3b1f582f028107367c854f8",
                    Title = "Какой-то фильм китайский",
                    Genre = "Фэнтези"
                },
                new Movie
                {
                    ImageUrl = "https://static.wikia.nocookie.net/roadwarrior/images/7/79/Friosa_vert_main_2764x4096_dom.jpg/revision/latest?cb=20240416191245",
                    Title = "Фуриоса: Хроники Безумного Макса",
                    Genre = "Боевик",
                    Description = "Маленькую Фуриосу похищают из благодатных Зелёных Земель и в качестве доказательства существования этого оазиса привозят главарю банды байкеров Дементусу, а тот на глазах у девочки жестоко убивает пришедшую ей на помощь мать. Вскоре он вознамеривается навести шороху в Пустоши — захватывает власть в Топливном городе и в обмен на торговый договор с Цитаделью отдаёт Фуриосу Несмертному Джо в будущие жёны.\r\n\r\n"
                },
                new Movie
                {
                    ImageUrl = "https://nyagan.life/system/Cover/images/000/064/584/big/obj_0_1614744479.jpg",
                    Title = "Пончары. Глобальное закругление",
                    Genre = "Комедия",
                    Description = "Пончары – милые, уморительные создания. Круглые как пончики и пушистые как хомячки. Но когда двух из них вдруг затягивает петля времени, выясняется, что в будущем пончары – музейные экспонаты наряду с динозаврами. Нужно срочно изменить ход истории и для этого они прокатятся по всем эпохам. Им всё в новинку и всё нипочём: хоть пещерные люди, хоть квадрокоптеры… А значит, впереди округлительные приключения!"
                },
                new Movie
                {
                    ImageUrl = "https://media.zenfs.com/en/deadline.com/f4828a2dc3b1f582f028107367c854f8",
                    Title = "Какой-то фильм китайский",
                    Genre = "Фэнтези"
                },
                new Movie
                {
                    ImageUrl = "https://static.wikia.nocookie.net/roadwarrior/images/7/79/Friosa_vert_main_2764x4096_dom.jpg/revision/latest?cb=20240416191245",
                    Title = "Фуриоса: Хроники Безумного Макса",
                    Genre = "Боевик",
                    Description = "Маленькую Фуриосу похищают из благодатных Зелёных Земель и в качестве доказательства существования этого оазиса привозят главарю банды байкеров Дементусу, а тот на глазах у девочки жестоко убивает пришедшую ей на помощь мать. Вскоре он вознамеривается навести шороху в Пустоши — захватывает власть в Топливном городе и в обмен на торговый договор с Цитаделью отдаёт Фуриосу Несмертному Джо в будущие жёны.\r\n\r\n"
                },
                new Movie
                {
                    ImageUrl = "https://nyagan.life/system/Cover/images/000/064/584/big/obj_0_1614744479.jpg",
                    Title = "Пончары. Глобальное закругление",
                    Genre = "Комедия",
                    Description = "Пончары – милые, уморительные создания. Круглые как пончики и пушистые как хомячки. Но когда двух из них вдруг затягивает петля времени, выясняется, что в будущем пончары – музейные экспонаты наряду с динозаврами. Нужно срочно изменить ход истории и для этого они прокатятся по всем эпохам. Им всё в новинку и всё нипочём: хоть пещерные люди, хоть квадрокоптеры… А значит, впереди округлительные приключения!"
                }
            };
        }
    }
}
