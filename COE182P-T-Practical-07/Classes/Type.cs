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
            using (SqlCommand command = new SqlCommand("INSERT INTO dbo.FoodMenuType (FoodType, TypeDescription)" + " VALUES (@TypeName, @TypeDescription)", SQLconn))
            {
                command.Parameters.Add("FoodType", SqlDbType.VarChar, 100).Value = FoodType;
                command.Parameters.Add("TypeDescription", SqlDbType.VarChar, 200).Value = TypeDescription;
                SQLconn.Open();
                command.ExecuteNonQuery();
            }
        }
        public static void UpdateType(SqlConnection SQLconn, int FoodTypeID, string FoodType, string TypeDescription)
        {
            using (SqlCommand command = new SqlCommand("UPDATE dbo.FoodMenuType"
                + " SET FoodType = @FoodType,"
                + " TypeDescription = @TypeDescription"
                + " WHERE FoodTypeID = @FoodTypeID", SQLconn))
            {
                command.Parameters.Add("FoodTypeID", SqlDbType.Int).Value = FoodTypeID;
                command.Parameters.Add("FoodType", SqlDbType.VarChar, 100).Value = FoodType;
                command.Parameters.Add("TypeDescription", SqlDbType.VarChar, 200).Value = TypeDescription;
                SQLconn.Open();
                command.ExecuteNonQuery();
            }
        }
        public static void DeleteType(SqlConnection SQLconn, int FoodTypeID)
        {
            using (SqlCommand command = new SqlCommand("DELETE FROM dbo.FoodMenuType" + " WHERE FoodTypeID = @FoodTypeID", SQLconn))
            {
                command.Parameters.Add("FoodTypeID", SqlDbType.Int, 200).Value = FoodTypeID;
                SQLconn.Open();
                command.ExecuteNonQuery();
            }
        }
        public static List<TypeList> GetTypeList(SqlConnection SQLconn)
        {
            List<TypeList> TL = new List<TypeList>();
            using (SqlCommand command = new SqlCommand("SELECT FoodTypeID, FoodType, TypeDescription FROM dbo.FoodMenuType", SQLconn))
            {
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