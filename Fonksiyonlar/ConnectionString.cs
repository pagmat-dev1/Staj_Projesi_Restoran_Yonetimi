using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Staj_Projesi_Restoran_Yonetimi.Datasets;
using Microsoft.SqlServer.Server;


namespace Staj_Projesi_Restoran_Yonetimi.Fonksiyonlar
{
    public class ConnectionString
    {
        public static String GetConnectionString()
        {
            return "Server=DESKTOP-MIOEHHS\\SQLEXPRESS;Database=Restoran;User Id=test_user;Password=test123;";
        }

    }
    public class DatabaseManager
    {
        public DatabaseManager()
        {
        }

        public static List<YourDataType> GetDataFromDatabase()
        {
            var connectionString = ConnectionString.GetConnectionString();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // SQL sorgunuzu burada yürütün
                // Verileri alın ve döndürünx

                return null;
            }
        }
    }

}
