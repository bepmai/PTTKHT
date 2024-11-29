using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace lop
{
    internal class Modify
    {
        SqlDataAdapter dataAdapter; // sẽ truy xuất dữ liệu vào bảng 
        SqlCommand sqlCommand; // truy van va cap nhat toi csdl
        public Modify() { }

        // dataset trả về nhiều bảng 
        // datatable trả về 1 bảng
        public DataTable getAllTTLop()
        {
            DataTable dataTable = new DataTable();
            string query = "select * from TTLOP";
            //string query1 = "select * from NguoiHoc";
            using (SqlConnection sqlConnection = DataConnection.getConnection())
            {
                sqlConnection.Open();

                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                //dataAdapter = new SqlDataAdapter(query1, sqlConnection);
                dataAdapter.Fill(dataTable); // lap day du lieu vao bang

                sqlConnection.Close();
            }

            return dataTable;
        }
 

        //
        public DataTable getAllTTSinhVien()
        {
            DataTable dataTable = new DataTable();
      
            string query1 = "select * from NguoiHoc";
            using (SqlConnection sqlConnection = DataConnection.getConnection())
            {
                sqlConnection.Open();

           
                dataAdapter = new SqlDataAdapter(query1, sqlConnection);
                dataAdapter.Fill(dataTable); // lap day du lieu vao bang

                sqlConnection.Close();
            }

            return dataTable;
        }

        //

        public bool insert(TTLop ttlop)
        {
            SqlConnection sqlConnection = DataConnection.getConnection();
            string query = "insert into tTTLOP values (@idClass, @nameClass, @nameSubject, @nameTeacher, @numberLearners, @dateCreated)";

            //string query1 = "insert into tNguoiHoc values (@iduser, @userName)";

            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@idClass", SqlDbType.VarChar).Value = ttlop.IdClass;
                sqlCommand.Parameters.Add("@nameClass", SqlDbType.NVarChar).Value = ttlop.NameClass;
                sqlCommand.Parameters.Add("@nameSubject", SqlDbType.NVarChar).Value = ttlop.NameSubject;
                sqlCommand.Parameters.Add("@nameTeacher", SqlDbType.NVarChar).Value = ttlop.NameTeacher;
                sqlCommand.Parameters.Add("@numberLearners", SqlDbType.VarChar).Value = ttlop.NumberLearners;
                sqlCommand.Parameters.Add("@dateCreated", SqlDbType.DateTime).Value = ttlop.DateCreated.ToLongDateString(); // chi lay ngay/thang/nam

                /*sqlCommand = new SqlCommand(query1, sqlConnection);
                sqlCommand.Parameters.Add("@iduser", SqlDbType.VarChar).Value = ttlop.Iduser;
                sqlCommand.Parameters.Add("@userName", SqlDbType.NVarChar).Value = ttlop.Username;*/

                sqlCommand.ExecuteNonQuery(); // thuc thi lenh truy van

            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }

        //
        public bool insert1(SV sinhvien)
        {
            SqlConnection sqlConnection = DataConnection.getConnection();
            string query1 = "insert into tNguoiHoc values (@iduser, @userName)";

            try
            {
                sqlCommand = new SqlCommand(query1, sqlConnection);
                sqlCommand.Parameters.Add("@iduser", SqlDbType.VarChar).Value = sinhvien.Iduser;
                sqlCommand.Parameters.Add("@userName", SqlDbType.NVarChar).Value = sinhvien.Username;

                sqlCommand.ExecuteNonQuery(); // thuc thi lenh truy van

            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
            //
        }
    }
}
