using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace COE182P_T_Practical_07
{
    class Type
    {
        public static void AddType(SqlConnection SQLconn, string FoodType, string TypeDescription)
        {
            using (SqlCommand command = new SqlCommand("dbo.AddNewFoodType", SQLconn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@TypeFood", SqlDbType.VarChar, 100).Value = FoodType;
                command.Parameters.Add("@DescType", SqlDbType.VarChar, 200).Value = TypeDescription;
                SQLconn.Open();
                command.ExecuteNonQuery();
            }
            SQLServerConnection.CloseSQLConnection(SQLconn);
        }
        public static void UpdateType(SqlConnection SQLconn, int FoodTypeID, string FoodType, string TypeDescription)
        {
            using (SqlCommand command = new SqlCommand("dbo.UpdateFoodType", SQLconn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@IDType", SqlDbType.Int).Value = FoodTypeID;
                command.Parameters.Add("@TypeFood", SqlDbType.VarChar, 100).Value = FoodType;
                command.Parameters.Add("@DescType", SqlDbType.VarChar, 200).Value = TypeDescription;
                SQLconn.Open();
                command.ExecuteNonQuery();
            }
            SQLServerConnection.CloseSQLConnection(SQLconn);
        }
        public static void DeleteType(SqlConnection SQLconn, int FoodTypeID)
        {
            using (SqlCommand command = new SqlCommand("dbo.DeleteFoodType", SQLconn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@IDStall", SqlDbType.Int, 200).Value = FoodTypeID;
                SQLconn.Open();
                command.ExecuteNonQuery();
            }
            SQLServerConnection.CloseSQLConnection(SQLconn);
        }
        public static List<TypeList> GetTypeList(SqlConnection SQLconn)
        {
            List<TypeList> TL = new List<TypeList>();
            using (SqlCommand command = new SqlCommand("dbo.GetFoodTypeList", SQLconn))
            {
                command.CommandType = CommandType.StoredProcedure;
                SQLconn.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TypeList tempTL = new TypeList();
                        tempTL.FoodTypeID = reader.GetInt32(0);
                        tempTL.FoodType = reader.GetString(1);
                        tempTL.TypeDescription = reader.GetString(2);
                        TL.Add(tempTL);
                    }
                }
            }
            SQLServerConnection.CloseSQLConnection(SQLconn);
            return TL;
        }
    }
    public class TypeList
    {
        public int FoodTypeID { get; set; }
        public string FoodType { get; set; }
        public string TypeDescription { get; set; }
    }
}