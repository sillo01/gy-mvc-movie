using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // Get: /HelloWorld/
        public string Index()
        {
            return "Ésta es la ruta por defecto";
        }

        // Get /HelloWorld/route
        // Se llama una ruta especializada
        public string Route()
        {
            return "Un controlador puede implementar más de una ruta";
        }

        // Get: /HelloWorld/query/
        // Se llama el método pasando la cadena completa de parémtros 
        public string Query(string name, int param)
        {
            return $"Hola {name}, el valor del parámetro es {param}";
        }

        // Get: /HelloWorld/template
        // Se llama el método siguiendo la convención de la plantilla
        public string Template(string name, int id)
        {
            return HtmlEncoder.Default.Encode($"Hola {name}, el valor del ID es {id}");
        }
    }
}