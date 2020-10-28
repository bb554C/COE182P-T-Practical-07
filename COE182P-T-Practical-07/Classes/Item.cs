using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace COE182P_T_Practical_07.Classes
{
    class Item
    {
        public static void AddItem(SqlConnection SQLconn,  int StallID, int FoodTypeID, string FoodName, string FoodDescription, decimal FoodPrice)
        {
            using (SqlCommand command = new SqlCommand("dbo.AddNewFood", SQLconn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@IDStall", SqlDbType.Int).Value = StallID;
                command.Parameters.Add("@IDType", SqlDbType.Int).Value = FoodTypeID;
                command.Parameters.Add("@NameFood", SqlDbType.VarChar, 100).Value = FoodName;
                command.Parameters.Add("@DescFood", SqlDbType.VarChar, 200).Value = FoodDescription;
                command.Parameters.Add("@Price", SqlDbType.Decimal).Value = FoodPrice;
                SQLconn.Open();
                command.ExecuteNonQuery();
            }
            SQLServerConnection.CloseSQLConnection(SQLconn);
        }
        public static void UpdateItem(SqlConnection SQLconn, int FoodID, int StallID, int FoodTypeID, string FoodName, string FoodDescription, decimal FoodPrice)
        {
            using (SqlCommand command = new SqlCommand("dbo.UpdateFood", SQLconn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@IDFood", SqlDbType.Int).Value = FoodID;
                command.Parameters.Add("@IDStall", SqlDbType.Int).Value = StallID;
                command.Parameters.Add("@IDType", SqlDbType.Int).Value = FoodTypeID;
                command.Parameters.Add("@NameFood", SqlDbType.VarChar, 100).Value = FoodName;
                command.Parameters.Add("@DescFood", SqlDbType.VarChar, 200).Value = FoodDescription;
                command.Parameters.Add("@Price", SqlDbType.Decimal).Value = FoodPrice;
                SQLconn.Open();
                command.ExecuteNonQuery();
            }
            SQLServerConnection.CloseSQLConnection(SQLconn);
        }
        public static void DeleteItem(SqlConnection SQLconn, int FoodID)
        {
            using (SqlCommand command = new SqlCommand("dbo.DeleteFood", SQLconn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@IDStall", SqlDbType.Int).Value = FoodID;
                SQLconn.Open();
                command.ExecuteNonQuery();
            }
            SQLServerConnection.CloseSQLConnection(SQLconn);
        }
        public static List<ItemList> GetItemList(SqlConnection SQLconn)
        {
            List<ItemList> IL= new List<ItemList>();
            using (SqlCommand command = new SqlCommand("dbo.GetFoodList", SQLconn))
            {
                command.CommandType = CommandType.StoredProcedure;
                SQLconn.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ItemList tempSL = new ItemList();
                        tempSL.FoodID = reader.GetInt32(0);
                        tempSL.StallID = reader.GetInt32(1);
                        tempSL.FoodTypeID = reader.GetInt32(2);
                        tempSL.FoodName = reader.GetString(3);
                        tempSL.FoodDescription = reader.GetString(4);
                        tempSL.FoodPrice = reader.GetDecimal(5);
                        IL.Add(tempSL);
                    }
                }
                SQLServerConnection.CloseSQLConnection(SQLconn);
            }
            return IL;
        }
    }
    public class ItemList
    { 
        public int FoodID { get; set; }
        public int StallID { get; set; }
        public int FoodTypeID { get; set; }
        public string FoodName { get; set; }
        public string FoodDescription { get; set; }
        public decimal FoodPrice { get; set; }
    }
}
