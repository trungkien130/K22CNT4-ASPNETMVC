using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Ltk_Lesson6.Models
{
    public class LtkSong
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage ="Ltk Hãy nhập tiêu đề")]
        [DisplayName("Tiêu đề")]
        public string LtkTitle { get; set; }
        [Required(ErrorMessage = "Ltk Hãy nhập tác giả")]
        [DisplayName("Tác giả")]
        public string LtkAuthor { get; set; }
        [Required(ErrorMessage = "Ltk Hãy nhập nghệ sĩ")]
        [DisplayName("Nghệ sĩ")]
        [StringLength(50,MinimumLength =2,ErrorMessage ="Ltk tên nghệ sĩ có tối thiểu 2 ký tự, tối đa 50 ký tự")]
        public string LtkArtist { get; set; }
        [Required(ErrorMessage = "Ltk Hãy nhập năm xuất bản")]
        [DisplayName("Năm xuất bản")]
        [RegularExpression(@"[0-9]{4}", ErrorMessage = "Ltk Nhập xuất bản phải có 2 ký tự số")]
        [Range(1900, 2024,ErrorMessage = "Ltk năm xuất bản từ năm 1900 đến 2024")]
        public int LtkYearRelease { get; set; }
    }
}