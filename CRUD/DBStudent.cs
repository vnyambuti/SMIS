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
    }
}
