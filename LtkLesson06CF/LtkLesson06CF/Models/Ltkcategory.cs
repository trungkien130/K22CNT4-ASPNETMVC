using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LtkLesson06CF.Models
{
    public class LtkCategory
    {
        [Key]
        public int LtkId { get; set; }
        public string LtkCategoryName { get; set; }

        // Thuộc tính quan hệ
        public virtual ICollection<LtkBook> LtkBooks { get; set; }
    }
}