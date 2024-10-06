using FilmsApp.ViewModels;
using FilmsApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsApp.Controllers
{
    public interface ICoreController
    {
        TopFilmsPage TopFilmsPage { get; set; }
        FilmsListsPage FilmsListsPage { get; set; }

        FilmsListsViewModel FilmsListsViewModel { get; set; }
        TopFilmsModel TopFilmsModel { get; set; }
        HomeViewModel HomeViewModel { get; set; }
    }
}
