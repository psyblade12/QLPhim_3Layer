//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLPhimDAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class NguoiDung
    {
        public int NguoiDungID { get; set; }
        public string Ten { get; set; }
        public string MatKhau { get; set; }
        public int NhomNguoiDungID { get; set; }
    
        public virtual NhomNguoiDung NhomNguoiDung { get; set; }
    }
}