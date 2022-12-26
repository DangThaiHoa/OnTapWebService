using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace OnTap
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        SqlConnection cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        String connectionString = "Data Source=QuafBanhMi-PC;Initial Catalog=qlnv;Integrated Security=True";
        public WebService()
        {
            Connect();
        }
        [WebMethod]
        public void Connect()
        {
            cn = new SqlConnection(connectionString);
            cn.Open();
        }
        [WebMethod]
        public void Disconnect()
        {
            cn.Close();
        }
        [WebMethod]
        public DataSet Select(string strStore)
        {
            Connect();
            cmd = new SqlCommand(strStore, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Disconnect();
            return ds;
        }
        [WebMethod]
        public bool CheckKey(string sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, cn);
            DataTable table = new DataTable();
            dap.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }

        [WebMethod]
        public void Insert(string strStore, string manv, string hoten, int gioitinh, DateTime ngaysinh, string diachi, Byte[] hinhanh, string madv)
        {
            Connect();
            cmd = new SqlCommand(strStore, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@manv", SqlDbType.NChar).Value = manv;
            cmd.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = hoten;
            cmd.Parameters.Add("@gioitinh", SqlDbType.Bit).Value = gioitinh;
            cmd.Parameters.Add("@ngaysinh", SqlDbType.DateTime).Value = ngaysinh;
            cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = diachi;
            cmd.Parameters.Add("@hinhanh", SqlDbType.Image).Value = hinhanh;
            cmd.Parameters.Add("@madv", SqlDbType.NChar).Value = madv;
            cmd.ExecuteNonQuery();
            Disconnect();
        }

        [WebMethod]
        public void InsertDonVi(string strStore, string madv, string tendv)
        {
            Connect();
            cmd = new SqlCommand(strStore, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@madv", SqlDbType.NChar).Value = madv;
            cmd.Parameters.Add("@tendv", SqlDbType.NVarChar).Value = tendv;
            cmd.ExecuteNonQuery();
            Disconnect();
        }

        [WebMethod]
        public void DeleteNhanVien(string strStore, string manv)
        {
            Connect();
            cmd = new SqlCommand(strStore, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@manv", SqlDbType.NChar).Value = manv;
            cmd.ExecuteNonQuery();
            Disconnect();
        }

        [WebMethod]
        public void DeleteDonVi(string strStore, string madv)
        {
            Connect();
            cmd = new SqlCommand(strStore, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@madv", SqlDbType.NChar).Value = madv;
            cmd.ExecuteNonQuery();
            Disconnect();
        }
    }
}
