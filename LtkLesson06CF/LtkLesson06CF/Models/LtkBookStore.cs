using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LtkLesson06CF.Models
{
    public class LtkBookStore : DbContext
    {
        public LtkBookStore() : base("LtkBookStoreConnectionString") { }

        // Khai báo các thuộc tính ứng với các bảng trong cơ sở dữ liệu
        public DbSet<LtkCategory> LtkCategories { get; set; }
        public DbSet<LtkBook> LtkBooks { get; set; }
    }
}
