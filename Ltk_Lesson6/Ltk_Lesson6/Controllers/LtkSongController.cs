using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ltk_Lesson6.Models;

namespace Ltk_Lesson6.Controllers
{
    public class LtkSongController : Controller
    {
        private static List<LtkSong> ltkSongs = new List<LtkSong>()
        {
            new LtkSong{id=221090034,LtkTitle="Lê Trung Kiên",LtkAuthor="CNT4",LtkArtist="Ntu",LtkYearRelease=2024},
            new LtkSong{id=1,LtkTitle="Lê Trung Kiên",LtkAuthor="CNT4",LtkArtist="Ntu",LtkYearRelease=2024}

        };
        /// <summary>
        /// Hiển thị danh sách bài hát
        /// Author: Lê Trung Kiên
        /// </summary>
        /// <returns></returns>
        // GET: LtkSong
        public ActionResult LtkIndex()
        {
            return View(ltkSongs);
        }
        //Get: LTkCreate
        /// <summary>
        /// Form thêm mới bài hát
        /// Author: Lê Trung Kiên
        /// </summary>
        /// <returns></returns>
        public ActionResult LtkCreate()
        {
            var ltkSong = new LtkSong();
            return View(ltkSong);
        }
    }
}