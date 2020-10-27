using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace COE182P_T_Practical_07
{
    class Stall
    {
        public static void AddStall(SqlConnection SQLconn, string StallTypeName, string StallDescription)
        {
            using (SqlCommand command = new SqlCommand("INSERT INTO dbo.CanteenStalls (StallName, StallDescription) " + "VALUES (@StallName, @StallDescription)", SQLconn))
            {
                command.Parameters.Add("StallName", SqlDbType.VarChar, 100).Value = StallTypeName;
                command.Parameters.Add("StallDescription", SqlDbType.VarChar, 200).Value = StallDescription;
                SQLconn.Open();
                command.ExecuteNonQuery();
            }
        }

        public static void UpdateStall(SqlConnection SQLconn, int StallID, string StallTypeName, string StallDescription)
        {
            using (SqlCommand command = new SqlCommand("UPDATE dbo.CanteenStalls" 
                + " SET StallName = @StallName," 
                + " StallDescription = @StallDescription"
                + " WHERE StallID = @StallID", SQLconn))
            {
                command.Parameters.Add("StallID", SqlDbType.Int).Value = StallID;
                command.Parameters.Add("StallName", SqlDbType.VarChar, 100).Value = StallTypeName;
                command.Parameters.Add("StallDescription", SqlDbType.VarChar, 200).Value = StallDescription;
                SQLconn.Open();
                command.ExecuteNonQuery();
            }
        }

        public static void DeleteStall(SqlConnection SQLconn, int StallID)
        {
            using (SqlCommand command = new SqlCommand("DELETE FROM dbo.CanteenStalls" + " WHERE StallID = @StallID", SQLconn))
            {
                command.Parameters.Add("StallID", SqlDbType.Int, 200).Value = StallID;
                SQLconn.Open();
                command.ExecuteNonQuery();
            }
        }

        public static List<StallList> GetStallList(SqlConnection SQLconn)
        {
            List<StallList> SL = new List<StallList>();
            using (SqlCommand command = new SqlCommand("SELECT StallID, StallName, StallDescription FROM dbo.CanteenStalls", SQLconn))
            {
                SQLconn.Open();
                using(SqlDataReader reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        StallList tempSL = new StallList();
                        tempSL.StallID = reader.GetInt32(0);
                        tempSL.StallName = reader.GetString(1);
                        tempSL.StallDescription = reader.GetString(2);
                        SL.Add(tempSL);
                    }
                }
            }
            return SL;
        }
    }
    public class StallList
    {
        public int StallID { get; set; }
        public string StallName { get; set; }
        public string StallDescription { get; set; }
    }
}
