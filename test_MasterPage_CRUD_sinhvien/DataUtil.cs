using CRUD_ASP_sinhvien;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace test_MasterPage_CRUD_sinhvien
{
    public class DataUtil
    {
        SqlConnection conn;
        public DataUtil()
        {
            string sqlconn = @"Data Source=DESKTOP-RF25IGV\SQLEXPRESS;Initial Catalog=sinhviendb;Integrated Security=True;Encrypt=False";
            conn = new SqlConnection(sqlconn);
        }
        //--danh sach sinh vien
        public List<sinhvien> dsSinhvien()
        {
            List<sinhvien> ds = new List<sinhvien>();
            string sql = "select * from sinhvien";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                sinhvien s = new sinhvien();
                s.masv = (int)reader["masv"];
                s.hoten = (string)reader["hoten"];
                s.diachi = (string)reader["diachi"];
                s.dienthoai = (string)reader["dienthoai"];
                s.malop = (int)reader["malop"];
                ds.Add(s);
            }
            conn.Close();
            return ds;

        }
    }
}