using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBookController : Controller
    {
        public ActionResult Detail()
        {
            var comicBook = new ComicBook()
            {
                    SeriesTitle = "The Amazing Spider-Man",
                    IssueNumber = 700,
                    DescriptionHTML = "<p><strong>will Peter Parker?</strong></p>",
                    Artists = new Artist[]
                    {
                       new Artist(){ Name= "Script Role", Role =  "Dan Slott" },
                      new Artist(){ Name=   "Pencils" ,Role= "Humberto Ramos" },
                      new Artist(){ Name=   "Inks" ,Role= "Victor Olazaba" },
                      new Artist(){ Name=   "Colors" ,Role= "Edgar Delgado" },
                      new Artist(){ Name=   "Letters",Role= "Chris Eliopoulos" }
                    }
            };
            return View(comicBook);
        }
    }
}