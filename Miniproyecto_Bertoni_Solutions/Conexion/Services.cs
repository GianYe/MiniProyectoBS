using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using Newtonsoft.Json;

namespace Miniproyecto_Bertoni_Solutions.Conexion
{
        public class Services
        {
            public static string GetAlbums()
            {
                var url = "https://jsonplaceholder.typicode.com/albums";

                return Get(url);
            }

            public static string GetPhotos(int AlbumId = 0)
            {
                var url = "https://jsonplaceholder.typicode.com/photos";

                if (AlbumId != 0)
                {
                    url = url + "?albumId=" + AlbumId.ToString();
                }

                return Get(url);
            }

            public static string GetComments(int PostId = 0)
            {
                var url = "https://jsonplaceholder.typicode.com/comments";

                if (PostId != 0)
                {
                    url = url + "?postId=" + PostId.ToString();
                }

                return Get(url);
            }

            public static string Get(string url)
            {
                WebClient webClient = new WebClient();
                webClient.Headers.Add("Content-Type", "application/json");
                webClient.Encoding = System.Text.Encoding.UTF8;

                string data = webClient.DownloadString(url);
                return data;
            }
        }
}