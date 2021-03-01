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
    public class DanhSachBenhNhan_DAL
    {
        private static string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];

        public bool them(DanhSachBenhNhan_DTO dsbn)
        {
            string query = string.Empty;
            query += "INSERT INTO [DanhSachBenhNhan] ([BN_maBN], [BN_hoten], [BN_gioitinh], [BN_namsinh], [BN_diachi], [BN_sdt], [BN_ngaykham], [BN_loaibenh], [BN_trieuchung])";
            query += "VALUES (@BN_maBN, @BN_hoten,@BN_gioitinh, @BN_namsinh, @BN_diachi, @BN_sdt, @BN_ngaykham, @BN_loaibenh, @BN_trieuchung)";
            using (SqlConnection _cnn = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _cnn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@BN_maBN", dsbn.BN_maBN);
                    cmd.Parameters.AddWithValue("@BN_hoten", dsbn.BN_hoten);
                    cmd.Parameters.AddWithValue("@BN_gioitinh", dsbn.BN_gioitinh);
                    cmd.Parameters.AddWithValue("@BN_namsinh", dsbn.BN_namsinh);
                    cmd.Parameters.AddWithValue("@BN_diachi", dsbn.BN_diachi);
                    cmd.Parameters.AddWithValue("@BN_sdt", dsbn.BN_sdt);
                    cmd.Parameters.AddWithValue("@BN_ngaykham", dsbn.BN_ngaykham);
                    cmd.Parameters.AddWithValue("@BN_loaibenh", dsbn.BN_loaibenh);
                    cmd.Parameters.AddWithValue("@BN_trieuchung", dsbn.BN_trieuchung);
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
        public bool xoa(DanhSachBenhNhan_DTO dsbn)
        {
            string query = string.Empty;
            query += "DELETE FROM [DanhSachBenhNhan] WHERE [BN_maBN] = @BN_maBN";
            using (SqlConnection _cnn = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _cnn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@BN_maBN", dsbn.BN_maBN);
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
        public bool sua(DanhSachBenhNhan_DTO dsbn)
        {
            string query = string.Empty;
            query += "UPDATE [DanhSachBenhNhan] SET [BN_hoten] = @BN_hoten, [BN_ngaykham] = @BN_ngaykham, " +
                "[BN_loaibenh] = @BN_loaibenh, [BN_trieuchung] = @BN_trieuchung WHERE [BN_maBN] = @BN_maBN";
            using (SqlConnection _cnn = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _cnn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@BN_maBN", dsbn.BN_maBN);
                    cmd.Parameters.AddWithValue("@BN_hoten", dsbn.BN_hoten);
                    cmd.Parameters.AddWithValue("@BN_ngaykham", dsbn.BN_ngaykham);
                    cmd.Parameters.AddWithValue("@BN_loaibenh", dsbn.BN_loaibenh);
                    cmd.Parameters.AddWithValue("@BN_trieuchung", dsbn.BN_trieuchung);
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

        public List<DanhSachBenhNhan_DTO> select()
        {
            string query = string.Empty;
            query += "SELECT [BN_ngaykham], [BN_maBN], [BN_hoten], [BN_gioitinh], [BN_namsinh], [BN_diachi], [BN_sdt], [BN_loaibenh], [BN_trieuchung]";
            query += "FROM [DanhSachBenhNhan]";

            List<DanhSachBenhNhan_DTO> lsBenhNhan = new List<DanhSachBenhNhan_DTO>();

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
                                DanhSachBenhNhan_DTO bn = new DanhSachBenhNhan_DTO();
                                bn.BN_ngaykham = reader["BN_ngaykham"].ToString();
                                bn.BN_maBN = reader["BN_maBN"].ToString();
                                bn.BN_hoten = reader["BN_hoten"].ToString();
                                bn.BN_gioitinh = reader["BN_gioitinh"].ToString();
                                bn.BN_namsinh = reader["BN_namsinh"].ToString();
                                bn.BN_diachi = reader["BN_diachi"].ToString();
                                bn.BN_sdt = reader["BN_sdt"].ToString();
                                bn.BN_loaibenh = reader["BN_loaibenh"].ToString();
                                bn.BN_trieuchung = reader["BN_trieuchung"].ToString();
                                lsBenhNhan.Add(bn);
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
            return lsBenhNhan;
        }

        public List<DanhSachBenhNhan_DTO> selectNameByKeyWord(string sKeyword)
        {
            string query = string.Empty;
            query += "SELECT * FROM [DanhSachBenhNhan]";
            query += " WHERE ([BN_hoten] LIKE CONCAT('%',@sKeyword,'%'))";
            //query += " WHERE ([BN_ngaykham] LIKE CONCAT('%',@sKeyword,'%'))";
            //query += " OR ([BN_maBN] LIKE CONCAT('%',@sKeyword,'%'))";
            //query += " OR ([BN_hoten] LIKE CONCAT('%',@sKeyword,'%'))";
            //query += " OR ([BN_gioitinh] LIKE CONCAT('%',@sKeyword,'%'))";
            //query += " OR ([BN_namsinh] LIKE CONCAT('%',@sKeyword,'%'))";
            //query += " OR ([BN_diachi] LIKE CONCAT('%',@sKeyword,'%'))";
            //query += " OR ([BN_sdt] LIKE CONCAT('%',@sKeyword,'%'))";
            //query += " OR ([BN_loaibenh] LIKE CONCAT('%',@sKeyword,'%'))";
            //query += " OR ([BN_trieuchung] LIKE CONCAT('%',@sKeyword,'%'))";

            List<DanhSachBenhNhan_DTO> lsBenhNhan = new List<DanhSachBenhNhan_DTO>();

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
                                DanhSachBenhNhan_DTO bn = new DanhSachBenhNhan_DTO();
                                bn.BN_ngaykham = reader["BN_ngaykham"].ToString();
                                bn.BN_maBN = reader["BN_maBN"].ToString();
                                bn.BN_hoten = reader["BN_hoten"].ToString();
                                bn.BN_gioitinh = reader["BN_gioitinh"].ToString();
                                bn.BN_namsinh = reader["BN_namsinh"].ToString();
                                bn.BN_diachi = reader["BN_diachi"].ToString();
                                bn.BN_sdt = reader["BN_sdt"].ToString();
                                bn.BN_loaibenh = reader["BN_loaibenh"].ToString();
                                bn.BN_trieuchung = reader["BN_trieuchung"].ToString();
                                lsBenhNhan.Add(bn);
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
            return lsBenhNhan;
        }
    }
}

