using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace WebServiceASMX
{
    public class Employee
    {
        public DataSet getEmployees()
        {
           
            DataSet dataTable = new DataSet();
            using (SqlConnection con = new SqlConnection(
                ConfigurationManager.ConnectionStrings["connectionLocal"]
                .ConnectionString))
            {
             
                con.Open();
                using (SqlDataAdapter sqlAdapter = new SqlDataAdapter(
                    "SELECT * FROM Employees", con))
                {
                    sqlAdapter.Fill(dataTable);
                }
            }
                return dataTable;
        }
    }
}