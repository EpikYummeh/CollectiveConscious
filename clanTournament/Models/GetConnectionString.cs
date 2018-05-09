using System.Configuration;
using System.Data.SqlClient;

namespace clanTournament.Models
{
    public class GetConnectionString
    {
        public static string ConString()
        {
            
            return ConfigurationManager.ConnectionStrings["CoCodbEntities1"].ConnectionString;
        }
        public int SaveGuardianData(int ID, string MembershipId, string DisplayName, int MembershipType)
        {
            SqlConnection conn = new SqlConnection(ConString());
            string query = "INSERT INTO Guardian(ID,MembershipID,DisplayName,MembershipType) values ('" + ID + "','" + MembershipId + "','" + DisplayName + "','" + MembershipType + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }
    }
}