using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

//l’esercitazione di oggi sarà divisa in 2 parti:
//-una parte ci porterà a fare esercizi con Razor
//- la seconda a fare delle prove con i layout di .Net Core MVC

//— PRIMA PARTE —-
//A questo punto, una volta ripulito GIT e creata una nuova repository, per la prima parte riguardante Razor dovete creare un nuovo progetto MVC dentro la vostra soluzione chiamato Razor per svolgere gli esercizi che trovate nel file esercizi-razor.txt
//Svolgeteli tutti all’interno della view Index del controller HomeController che viene generata di default nel nuovo progetto che avete creato.
//— SECONDA PARTE —-
//Per la seconda parte, ritornate sul progetto sul quale avete lavorato la scorsa volta. Usate questo progetto per fare esercizio con i layout, perciò aprite il progetto della vostra pizzeria in cui lo avevate lasciato e fate esperimenti con i layout.
//Create dunque un nuovo layout e inserite al suo interno il codice che secondo voi definisce lo scheletro dell’applicazione e che dovrà essere utilizzato in altre pagine future del vostro progetto.


namespace la_mia_pizzeria_static.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}