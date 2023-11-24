using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Staj_Projesi_Restoran_Yonetimi.Fonksiyonlar
{
    public class DatabaseManager
    {
        public async Task<Meyve> GetMeyveById(int id)
        {
            var connectionString = ConnectionString.GetConnectionString();
            Meyve meyve = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                await conn.OpenAsync();

                string query = "SELECT * FROM Table_Meyveler WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);

                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            meyve = new Meyve
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                Name = reader.GetString(reader.GetOrdinal("Name"))
                                // Diğer alanlar burada atanabilir
                            };
                        }
                    }
                }
            }

            return meyve;
        }

    }
}
