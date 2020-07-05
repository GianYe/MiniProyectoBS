using Miniproyecto_Bertoni_Solutions.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Miniproyecto_Bertoni_Solutions.Conexion;

namespace Miniproyecto_Bertoni_Solutions.Controllers
{
    public class HomeController : Controller
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

        public PartialViewResult Photos(int albumId)
        {
            var response = Services.GetPhotos(albumId);
            var ListaPhotos = new List<Photo>();
            if (response != null)
            {
                ListaPhotos = JsonConvert.DeserializeObject<List<Photo>>(response);
            }
            return PartialView(ListaPhotos);
        }


        public PartialViewResult Comments(int photoId)
        {
            HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create("https://jsonplaceholder.typicode.com/comments");
            myReq.ContentType = "application/json";
            var response = (HttpWebResponse)myReq.GetResponse();
            string JSONcomments;

            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                JSONcomments = sr.ReadToEnd();
            }


            var comments = JsonConvert.DeserializeObject<List<Comment>>(JSONcomments);

            return PartialView(comments.Where(x => x.postId == photoId).ToList());
        }

    }
}