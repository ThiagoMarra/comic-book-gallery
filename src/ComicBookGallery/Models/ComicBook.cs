using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Models
{
    public class ComicBook
    {
        public int Id { get; set; }
        public string SeiresTitle { get; set; }
        public int Issue { get; set; }
        public string DescriptionHTML { get; set; }
        public Artist[] Artist { get; set; }
        public bool Favorite { get; set; }
    }
}