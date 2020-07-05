using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Miniproyecto_Bertoni_Solutions.Models;
using Miniproyecto_Bertoni_Solutions.Conexion;
using Newtonsoft.Json;

namespace Miniproyecto_Bertoni_Solutions.Controllers
{
    public class AlbumController : Controller
    {
        public ActionResult Index()
        {
            var response = Services.GetAlbums();
            var ListaAlbums = new List<Album>();
            if (response != null)
            {
                ListaAlbums = JsonConvert.DeserializeObject<List<Album>>(response);
            }
            return View(ListaAlbums);
        }
    }
}