using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Lab05.Models
{
    public class LtkMember
    {
        [Required(ErrorMessage = "Ltk: Hãy nhập mã số")]
        [DataType(DataType.Currency)]
        public int? Id { get; set; }
        [Required(ErrorMessage = "Ltk: Hãy nhập tên đăng nhập")]
        public string LtkUsername { get; set; }
        [Required(ErrorMessage = "Ltk: Hãy nhập họ và tên")]
        public string LtkFullName { get; set; }
        [Required(ErrorMessage = "Ltk: Hãy nhập mật khẩu")]
        [DataType(DataType.Password)]
        public string LtkPassword { get; set; }
        [Required(ErrorMessage = "Ltk: Hãy nhập tuổi")]
        [Range(18, 50, ErrorMessage = "Ltk: Tuổi từ 18 - 50")]
        public int? LtkAge { get; set; }
        [Required(ErrorMessage = " Hãy nhập email")]
        [RegularExpression(@"[A-Za - z0-9._%+-] + @[A-Za - z0-9.-]+\.[A-Za - z] {2 - 4}", ErrorMessage = "Ltk: Email phải đúng định dạng")]
        public string LtkEmail { get; set; }
    }
}