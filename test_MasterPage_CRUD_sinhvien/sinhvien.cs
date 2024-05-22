using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_ASP_sinhvien
{
    public class sinhvien
    {
        public int masv { get; set; }
        public string hoten { get; set; }
        public string diachi { get; set; }
        public string dienthoai { get; set; }
        public int malop { get; set; }
        public sinhvien() { }
        public sinhvien(int masv, string hoten, string diachi, string dienthoai, int malop)
        {
            this.masv = masv;
            this.hoten = hoten;
            this.diachi = diachi;
            this.dienthoai = dienthoai;
            this.malop = malop;
        }
    }
}