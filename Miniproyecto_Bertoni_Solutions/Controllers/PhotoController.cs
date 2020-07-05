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
    public class PhotoController : Controller
    {
        public ActionResult Index(int AlbumId = 0)
        {
            var response = Services.GetPhotos(AlbumId);
            var ListaPhotos = new List<Photo>();
            if (response != null)
            {
                ListaPhotos = JsonConvert.DeserializeObject<List<Photo>>(response);
            }
            return View(ListaPhotos);
        }

        [HttpPost]
        public ActionResult CargarComments(int PhotoId = 0)
        {
            var response = Services.GetComments(PhotoId);
            var ListaComments = new List<Comment>();

            if (response != null)
            {
                ListaComments = JsonConvert.DeserializeObject<List<Comment>>(response);
            }

            return PartialView("PartialPhotosView", ListaComments);
        }
    }
}