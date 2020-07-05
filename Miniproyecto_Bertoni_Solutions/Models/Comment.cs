using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Miniproyecto_Bertoni_Solutions.Models
{
    public class Comment
    {
        public int postId { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string body { get; set; }
    }
}