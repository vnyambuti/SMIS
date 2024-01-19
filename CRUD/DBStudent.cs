using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using MySqlX.XDevAPI.Common;
using System.Xml.Linq;
using Org.BouncyCastle.Ocsp;
using System.Data.SqlClient;
using Dapper.Contrib.Extensions;
using Org.BouncyCastle.Utilities;
using System.Collections;

namespace CRUD
{
    internal class DBStudent
    {

      

        public static void AddStudent(Student std) {
          
          

           try
           {
              
                string sql = "INSERT INTO students (Name, Reg,Class,Stream) VALUES (@Name, @Reg,@Class,@Stream);";
                object[] parameters = { new { Name = std.Name, Reg = std.Reg, Class = std.Class, Stream = std.Stream } };
               

                using (var sqlConnection = new MySqlConnection(Helper.CnnVal("school")))
                {

                    sqlConnection.Execute(sql, parameters);
                    MessageBox.Show("Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
               
           }
           catch(MySqlException ex)
            {
                MessageBox.Show("Mysql connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void DisplayandSearch(String query,DataGridView dgv)
        {

            try
            {

               


                using (var sqlConnection = new MySqlConnection(Helper.CnnVal("school")))
                {

                  MySqlCommand cmd = new MySqlCommand(query, sqlConnection);

                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    dgv.DataSource = dt;

                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Mysql connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void DeleteStudent(String id)
        {
            try
            {




                using (var sqlConnection = new MySqlConnection(Helper.CnnVal("school")))
                {
                    string query = "DELETE FROM students WHERE ID = "+id;
                    sqlConnection.Execute(query);
                    MessageBox.Show("Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Mysql connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void UpdateStudent(Student std,String id)
        {
            try
            {

                string sql = "UPDATE  students SET Name=@Name, Reg=@Reg,Class=@Class,Stream=@Stream WHERE ID="+id;
                object[] parameters = { new { Name = std.Name, Reg = std.Reg, Class = std.Class, Stream = std.Stream } };


                using (var sqlConnection = new MySqlConnection(Helper.CnnVal("school")))
                {

                    sqlConnection.Execute(sql, parameters);
                    MessageBox.Show("updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Mysql connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }



}
