using NklLession06.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NklLession06.Controllers
{
    public class NklSongController : Controller
    {
        private static List<NklSong> nklSongs = new List<NklSong>()
        {
            new NklSong{Id=2210900035, NklTitle="Nguyễn Khánh Linh", NklAuthor="K22CNT3", NklArtist="NTU", NklYearRelease=2020},
            new NklSong{Id=1, NklTitle="Nguyễn Khánh Linh", NklAuthor="K22CNT3", NklArtist="NTU", NklYearRelease=2020}
        };


        // GET: NklSong
        /// <summary>
        /// Hiển thi danh sách bài hát
        /// Author: Nguyễn Khánh Linh
        /// </summary>
        /// <returns></returns>
        public ActionResult NklIndex()
        {
            return View(nklSongs);
        }
        //Get: NklCreate
        /// <summary>
        /// Add new song
        /// Author: Nguyễn Khánh Linh
        /// </summary>
        /// <returns></returns>
        public ActionResult NklCreate()
        {
            var nklSong = new NklSong();
            return View(nklSong);
        }
    }
}