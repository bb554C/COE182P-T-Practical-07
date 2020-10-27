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
            using (SqlCommand command = new SqlCommand("INSERT INTO dbo.FoodMenu (StallID, FoodTypeID, FoodName, FoodDescription, FoodPrice) " 
                + "VALUES (@StallID, @FoodTypeID, @FoodName, @FoodDescription, @FoodPrice)", SQLconn))
            {
                command.Parameters.Add("StallID", SqlDbType.Int).Value = StallID;
                command.Parameters.Add("FoodTypeID", SqlDbType.Int).Value = FoodTypeID;
                command.Parameters.Add("FoodName", SqlDbType.VarChar, 100).Value = FoodName;
                command.Parameters.Add("FoodDescription", SqlDbType.VarChar, 200).Value = FoodDescription;
                command.Parameters.Add("FoodPrice", SqlDbType.Decimal).Value = FoodPrice;
                SQLconn.Open();
                command.ExecuteNonQuery();
            }
        }
        public static void UpdateItem(SqlConnection SQLconn, int FoodID, int StallID, int FoodTypeID, string FoodName, string FoodDescription, decimal FoodPrice)
        {
            using (SqlCommand command = new SqlCommand("UPDATE dbo.FoodMenu"
               + " SET StallID = @StallID,"
               + " FoodTypeID = @FoodTypeID,"
               + " FoodName = @FoodName," 
               + " FoodDescription = @FoodDescription,"
               + " FoodPrice = @FoodPrice"
               + " WHERE FoodID = @FoodID", SQLconn))
            {
                command.Parameters.Add("FoodID", SqlDbType.Int).Value = FoodID;
                command.Parameters.Add("StallID", SqlDbType.Int).Value = StallID;
                command.Parameters.Add("FoodTypeID", SqlDbType.Int).Value = FoodTypeID;
                command.Parameters.Add("FoodName", SqlDbType.VarChar, 100).Value = FoodName;
                command.Parameters.Add("FoodDescription", SqlDbType.VarChar, 200).Value = FoodDescription;
                command.Parameters.Add("FoodPrice", SqlDbType.Decimal).Value = FoodPrice;
                SQLconn.Open();
                command.ExecuteNonQuery();
            }
        }
        public static void DeleteItem(SqlConnection SQLconn, int FoodID)
        {
            using (SqlCommand command = new SqlCommand("DELETE FROM dbo.FoodMenu" + " WHERE FoodID = @FoodID", SQLconn))
            {
                command.Parameters.Add("FoodID", SqlDbType.Int).Value = FoodID;
                SQLconn.Open();
                command.ExecuteNonQuery();
            }
        }
        public static List<ItemList> GetItemList(SqlConnection SQLconn)
        {
            List<ItemList> IL= new List<ItemList>();
            using (SqlCommand command = new SqlCommand("SELECT FoodID, StallID, FoodName, FoodTypeID, FoodDescription, FoodPrice FROM dbo.FoodMenu", SQLconn))
            {
                SQLconn.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ItemList tempSL = new ItemList();
                        tempSL.FoodID = reader.GetInt32(0);
                        tempSL.StallID = reader.GetInt32(1);
                        tempSL.FoodName = reader.GetString(2);
                        tempSL.FoodTypeID = reader.GetInt32(3);
                        tempSL.FoodDescription = reader.GetString(4);
                        tempSL.FoodPrice = reader.GetDecimal(5);
                        IL.Add(tempSL);
                    }
                }
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
