using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Miniproyecto_Bertoni_Solutions.Models
{
    public class Album
    {
        /*public Album()
        {
            Photos = new List<Photo>();
        }*/
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        //public List<Photo> Photos { get; set; }
    }
}