using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace MvcMovie.Controllers
{
    
    public class SemanaController : Controller
    {
        private readonly string[] semana = new string[7]
        {
            "Domingo", "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado"
        };

        public string Index()
        {
            return string.Join(", ", semana);
        }

        public string Inglesa()
        {
            return string.Join(", ", semana.Skip(1).Take(5));
        }

        public string Param(string filtro)
        {
            return string.Join(", ", semana.Where(d => d.StartsWith(filtro.ToUpper())));
        }

        public string Id(int id)
        {
            return id < 8 ? semana[id-1] : "404";
        }
    }
}