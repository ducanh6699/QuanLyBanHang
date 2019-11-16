using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace WebApplication1
{
    public class libraryweb
    {
        public static String ketnoi = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\QuanLyBanHang.mdb";
        public static DataTable laydulieu(String sql)
        {
            OleDbConnection con = new OleDbConnection(ketnoi);
            con.Open();
            OleDbDataAdapter ada = new OleDbDataAdapter(sql, con);
            DataTable tb = new DataTable();
            ada.Fill(tb);
            con.Close();
            return tb;
        }
    }
}