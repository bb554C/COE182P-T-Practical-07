using COE182P_T_Practical_07.Classes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace COE182P_T_Practical_07
{
    class SQLServerConnection
    {
        public static FoodTypeForm FTF;
        public static StallForm SF;
        public static ItemForm IF;
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
        public static void AddStall(string StallName, string StallDescription)
        {
            try
            {
                Stall.AddStall(SQLConnection(), StallName, StallDescription);
            }
            catch (Exception ex)
            {
                Error(ex.ToString());
                SF.Close();
            }
        }

        public static void UpdateStall(int StallID, string StallName, string StallDescription)
        {
            try
            {
                Stall.UpdateStall(SQLConnection(),StallID, StallName, StallDescription);
            }
            catch (Exception ex)
            {
                Error(ex.ToString());
                SF.Close();
            }
        }

        public static void DeleteStall(int StallID)
        {
            try
            {
                Stall.DeleteStall(SQLConnection(),StallID);
            }
            catch (Exception ex)
            {
                Error(ex.ToString());
                SF.Close();
            }
        }

        public static List<StallList> GetStallList()
        {
            List<StallList> SL = new List<StallList>();
            try
            {
                SL = Stall.GetStallList(SQLConnection());
            }
            catch (Exception ex)
            {
                Error(ex.ToString());
                SF.Close();
            }
            return SL;
        }

        public static void AddFoodType(string FoodType, string TypeDescription)
        {
            try
            {
                Type.AddType(SQLConnection(), FoodType, TypeDescription);
            }
            catch (Exception ex)
            {
                Error(ex.ToString());
                SF.Close();
            }
        }

        public static void UpdateFoodType(int FoodID, string FoodType, string TypeDescription)
        {
            try
            {
                Type.UpdateType(SQLConnection(), FoodID, FoodType, TypeDescription);
            }
            catch (Exception ex)
            {
                Error(ex.ToString());
                SF.Close();
            }
        }

        public static void DeleteFoodType(int FoodID)
        {
            try
            {
                Type.DeleteType(SQLConnection(), FoodID);
            }
            catch (Exception ex)
            {
                Error(ex.ToString());
                SF.Close();
            }
        }

        public static List<TypeList> GetFoodTypeList()
        {
            List<TypeList> TL = new List<TypeList>();
            try
            {
                TL = Type.GetTypeList(SQLConnection());
            }
            catch (Exception ex)
            {
                Error(ex.ToString());
                SF.Close();
            }
            return TL;
        }

        public static void AddItem(int StallID, int FoodTypeID, string FoodName, string FoodDescription, decimal FoodPrice)
        {
            try
            {
                Item.AddItem(SQLConnection(), StallID, FoodTypeID, FoodName, FoodDescription, FoodPrice);
            }
            catch (Exception ex)
            {
                Error(ex.ToString());
                SF.Close();
            }
        }
        public static void UpdateItem(int FoodID, int StallID, int FoodTypeID, string FoodName, string FoodDescription, decimal FoodPrice)
        {
            Item.UpdateItem(SQLConnection(), FoodID, StallID, FoodTypeID, FoodName, FoodDescription, FoodPrice);
        }
        public static void DeleteItem(int FoodID)
        {
            try
            {
                Item.DeleteItem(SQLConnection(), FoodID);
            }
            catch (Exception ex)
            {
                Error(ex.ToString());
                SF.Close();
            }
        }
        public static List<ItemList> GetItemList()
        {
            List<ItemList> TL = new List<ItemList>();
            try
            {
                TL = Item.GetItemList(SQLConnection());
            }
            catch (Exception ex)
            {
                Error(ex.ToString());
                SF.Close();
            }
            return TL;
        }

        private static void Error(string ex)
        {
            MessageBox.Show("Error Code: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

