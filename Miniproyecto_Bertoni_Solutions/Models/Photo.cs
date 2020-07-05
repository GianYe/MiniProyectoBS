using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Miniproyecto_Bertoni_Solutions.Models
{
    public class Photo
    {
        /*public Photo()
        {
            Comments = new List<Comment>();
        }*/
        public int albumId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public string thumbnailUrl { get; set; }
        //public List<Comment> Comments { get; set; }
    }
}