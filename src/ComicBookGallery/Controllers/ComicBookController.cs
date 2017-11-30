using ComicBookGallery.Data;
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
        private ComicBookRepository _comicbookRepository;

        public ComicBookController()
        {
            _comicbookRepository = new ComicBookRepository();
        }

        public ActionResult Detail(int id)
        {
            var comicbook = _comicbookRepository.Get(id);

            return View(comicbook);
        }
    }
}