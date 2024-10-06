using FilmsApp.Controllers;

namespace FilmsApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DependencyService.RegisterSingleton(new CoreController());

            MainPage = new AppShell();
        }
    }
}
