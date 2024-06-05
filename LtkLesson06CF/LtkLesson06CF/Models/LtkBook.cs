using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LtkLesson06CF.Models
{
    public class LtkBook
    {
        [Key]
        public int LtkId { get; set; }
        public string LtkBookId { get; set; }
        public string LtkTitle { get; set; }
        public string LtkAuthor { get; set; }
        public int LtkYear { get; set; }
        public string LtkPublic { get; set; }
        public string LtkPicture { get; set; }
        public int LtkCategoryId { get; set; }
        // Thuộc tính quan hệ
        public virtual LtkCategory LtkCategory { get; set; }
    }
}