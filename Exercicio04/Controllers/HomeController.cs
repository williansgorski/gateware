using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Exercicio04.Models;
using Newtonsoft.Json;
using System.IO;

namespace Exercicio04.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public JsonResult GetFrutas()
        {
            
            return Json(ReturnJson());
        }

        public List<string> ReturnJson()
        {
            List<string> nomeFrutas = new List<string>();
            using (StreamReader r = new StreamReader("frutas.json"))
            {
                var json = r.ReadToEnd();
                List<Frutas> frutas = JsonConvert.DeserializeObject<List<Frutas>>(json);

                for (int i = 0; i < frutas.Count; i++)
                {
                    nomeFrutas.Add(frutas[i].Name);
                }
                
                return nomeFrutas;
            }
        }
        
    }
}
