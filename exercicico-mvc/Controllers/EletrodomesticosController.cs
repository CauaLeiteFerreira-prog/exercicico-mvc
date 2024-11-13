using exercicico_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace exercicico_mvc.Controllers
{
    public class EletrodomesticosController : Controller
    {
        public IActionResult Index()
        {
            List<Eletrodomestico> Eletros = new List<Eletrodomestico>
            {
                new Geladeiras {Marca = "Continental", Modelo = "Frost free", ConsumoEnergetico = 80.60, CapacidadeLitros = 450, TemFreezer = true},
                new Televisor {Marca = "Sansung", Modelo = "Gaming Hub", ConsumoEnergetico = 69.5, TamanhoTela = 65, EhSmart = true},
                new Televisor {Marca = "LG", Modelo = "AI Gaming", ConsumoEnergetico = 62.3, TamanhoTela = 52, EhSmart = false}
            };
            return View(Eletros);
        }
    }
}


