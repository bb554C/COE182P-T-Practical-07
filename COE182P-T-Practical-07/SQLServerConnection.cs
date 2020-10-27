using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace COE182P_T_Practical_07
{
    class SQLServerConnection
    {
        public static SqlConnection SQLConnection()
        {
            SqlConnection connection = null;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MapuaCanteenMenuDB"]?.ConnectionString;
                connection = new SqlConnection(connectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL was not able to connect to the database. Error: " + ex.ToString(), "SQL Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return connection;
        }

        public static void SQLAddNewFoodType(string FoodTypeName, string FoodTypeDescription)
        {
            SqlConnection SQLconn = SQLConnection();
            try
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO dbo.FoodMenuType (FoodType, TypeDescription) " + "VALUES (@FoodType, @TypeDescription)", SQLconn))
                {
                    SQLconn.Open();
                    //command.Parameters.Add
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL was not able to execute the command. Error: " + ex.ToString(), "SQL Command Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

