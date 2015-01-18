using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITCallegari_WebAPIs.Models
{
    public class BookModels
    {

        public int Id { get; set; }
        public String Name { get; set; }
        public String Autor { get; set; }
        public String Editor { get; set; }
        public String Edition { get; set; }
        public String Genre { get; set; }
        public int Pages { get; set; }

    }
}