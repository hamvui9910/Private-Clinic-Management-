using PCM_DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCM_DAL
{
    public class DoanhThu_DAL
    {
        private static string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];

        public bool search(DoanhThu_DTO dt)
        {
            string query = string.Empty;
            query += "SELECT [maHD], [ngaytao], [tenBN], [tienthuoc], [tongcong] FROM HoaDon";
            using (SqlConnection _cnn = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _cnn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    try
                    {
                        _cnn.Open();
                        cmd.ExecuteNonQuery();
                        _cnn.Close();
                        _cnn.Dispose();
                    }
                    catch (Exception ex)
                    {
                        _cnn.Close();
                        return false;
                    }
                }
            }
            return true;
        }
        public List<DoanhThu_DTO> select()
        {
            string query = string.Empty;
            query += "SELECT [maHD], [ngaytao], [tenBN], [tienthuoc], [tongcong]";
            query += "FROM [HoaDon]";

            List<DoanhThu_DTO> lsDoanhThu = new List<DoanhThu_DTO>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                DoanhThu_DTO dt = new DoanhThu_DTO();
                                dt.maHD = reader["maHD"].ToString();
                                dt.ngaytao = reader["ngaytao"].ToString();
                                dt.tenBN = reader["tenBN"].ToString();
                                dt.tienthuoc = Convert.ToDecimal(reader["tienthuoc"].ToString());
                                dt.tongcong = Convert.ToDecimal(reader["tongcong"].ToString());
                                lsDoanhThu.Add(dt);
                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return null;
                    }
                }
            }
            return lsDoanhThu;
        }
        public List<DoanhThu_DTO> selectByKeyWord(string sKeyword)
        {
            string query = string.Empty;
            query += "SELECT [maHD], [ngaytao], [tenBN], [tienthuoc], [tongcong]";
            query += "FROM [HoaDon]";
            query += " WHERE ([maHD] LIKE CONCAT('%',@sKeyword,'%'))";
            query += " OR ([ngaytao] LIKE CONCAT('%',@sKeyword,'%'))";
            query += " OR ([tenBN] LIKE CONCAT('%',@sKeyword,'%'))";
            query += " OR ([tienthuoc] LIKE CONCAT('%',@sKeyword,'%'))";
            query += " OR ([tongcong] LIKE CONCAT('%',@sKeyword,'%'))";

            List<DoanhThu_DTO> lsDoanhThu = new List<DoanhThu_DTO>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@sKeyword", sKeyword);
                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                DoanhThu_DTO dt = new DoanhThu_DTO();
                                dt.maHD = reader["maHD"].ToString();
                                dt.ngaytao = reader["ngaytao"].ToString();
                                dt.tenBN = reader["tenBN"].ToString();
                                dt.tienthuoc = Convert.ToDecimal(reader["tienthuoc"].ToString());
                                dt.tongcong = Convert.ToDecimal(reader["tongcong"].ToString());
                                lsDoanhThu.Add(dt);
                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return null;
                    }
                }
            }
            return lsDoanhThu;
        }
    }
}
