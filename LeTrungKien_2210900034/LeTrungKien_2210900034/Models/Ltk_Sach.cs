//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LeTrungKien_2210900034.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ltk_Sach
    {
        public string Ltk_MaSach { get; set; }
        public string Ltk_TenSach { get; set; }
        public Nullable<int> Ltk_SoTrang { get; set; }
        public Nullable<int> Ltk_NamXB { get; set; }
        public string Ltk_MaTG { get; set; }
        public Nullable<bool> Ltk_TrangThai { get; set; }
    
        public virtual Ltk_TacGia Ltk_TacGia { get; set; }
    }
}
