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
    public class QuyDinh_DAL
    {
        private static string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];


        public bool them(QuyDinh_DTO qd)
        {
            string query = string.Empty;
            query += "INSERT INTO [QuyDinh] ([maQD], [tenQD], [noidung])";
            query += "VALUES (@maQD, @tenQD, @noidung)";
            using (SqlConnection _cnn = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _cnn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maQD", qd.maQD);
                    cmd.Parameters.AddWithValue("@tenQD", qd.tenQD);
                    cmd.Parameters.AddWithValue("@noidung", qd.noidung);
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
        public bool xoa(QuyDinh_DTO qd)
        {
            string query = string.Empty;
            query += "DELETE FROM QuyDinh WHERE [maQD] = @maQD";
            using (SqlConnection _cnn = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _cnn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maQD", qd.maQD);
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
        public bool sua(QuyDinh_DTO qd)
        {
            string query = string.Empty;
            query += "UPDATE QuyDinh SET [tenQD] = @tenQD, [noidung] = @noidung WHERE [maQD] = @maQD";
            using (SqlConnection _cnn = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _cnn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maQD", qd.maQD);
                    cmd.Parameters.AddWithValue("@tenQD", qd.tenQD);
                    cmd.Parameters.AddWithValue("@noidung", qd.noidung);
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

        public List<QuyDinh_DTO> select()
        {
            string query = string.Empty;
            query += "SELECT [maQD], [tenQD], [noidung]";
            query += "FROM [QuyDinh]";

            List<QuyDinh_DTO> lsQuyDinh = new List<QuyDinh_DTO>();

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
                                QuyDinh_DTO qd = new QuyDinh_DTO();
                                qd.maQD = reader["maQD"].ToString();
                                qd.tenQD = reader["tenQD"].ToString();
                                qd.noidung = reader["noidung"].ToString();
                                lsQuyDinh.Add(qd);
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
            return lsQuyDinh;
        }
        public List<QuyDinh_DTO> selectByKeyWord(string sKeyword)
        {
            string query = string.Empty;
            query += "SELECT [maQD], [tenQD], [noidung]";
            query += "FROM [QuyDinh]";
            query += " WHERE ([maQD] LIKE CONCAT('%',@sKeyword,'%'))";
            query += " OR ([tenQD] LIKE CONCAT('%',@sKeyword,'%'))";
            query += " OR ([noidung] LIKE CONCAT('%',@sKeyword,'%'))";

            List<QuyDinh_DTO> lsQuyDinh = new List<QuyDinh_DTO>();

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
                                QuyDinh_DTO qd = new QuyDinh_DTO();
                                qd.maQD = reader["maQD"].ToString();
                                qd.tenQD = reader["tenQD"].ToString();
                                qd.noidung = reader["noidung"].ToString();
                                lsQuyDinh.Add(qd);
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
            return lsQuyDinh;
        }
    }
}
