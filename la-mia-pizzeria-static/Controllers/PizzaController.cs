using Microsoft.AspNetCore.Mvc;
//L’elenco delle pizze ora va passato come model dal controller, e la view deve utilizzarlo per mostrare l’html corretto.
//Gestiamo anche la possibilità che non ci siano pizze nell’elenco: in quel caso dobbiamo mostrare un messaggio che indichi all’utente che non ci sono pizze presenti nella nostra applicazione.
//Ogni pizza dell’elenco avrà un pulsante che se cliccato ci porterà a una pagina che mostrerà i dettagli di quella singola pizza.
//Dobbiamo quindi inviare l’id come parametro dell’URL, recuperarlo con la action, caricare i dati della pizza ricercata e passarli come model.
//La view a quel punto li mostrerà all’utente con la grafica che preferiamo.
//Ps. visto che abbiamo cambiato il controller sul quale lavoriamo, ricordiamoci di cambiare anche il “mapping di default” dei controller...altrimenti quale pagina viene caricata se richiamo l’url “/” della nostra webapp?

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            return View(Pizza.pizzas);
        }

        public IActionResult Details(int id)
        {
            var pizza = Pizza.pizzas.FirstOrDefault(p => p.Id == id);
            
            return View(pizza);
        }
    }
}
