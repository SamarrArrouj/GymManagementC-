using System;
using Microsoft.Data.SqlClient;

namespace GymManagementSystemC_
{
    internal class EquipmentRepository
    {
        private readonly string connectionString = "data source=DELL\\SQLEXPRESS;database=gym;integrated security=True; TrustServerCertificate=True;";

        public Equipment GetEquipmentById(int equipmentId)
        {
            Equipment equipment = null;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Equipment WHERE EID = @EID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@EID", equipmentId);
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            equipment = new Equipment();
                            equipment.Id = reader.GetInt32(reader.GetOrdinal("EID"));
                            equipment.EquipName = reader.GetString(reader.GetOrdinal("EquipName"));
                            equipment.EquipDescrip = reader.GetString(reader.GetOrdinal("EDescription"));
                            equipment.MusclesUsed = reader.GetString(reader.GetOrdinal("MUsed"));

                            // Vérification et conversion de DDate
                            var dDateOrdinal = reader.GetOrdinal("DDate");
                            if (!reader.IsDBNull(dDateOrdinal))
                            {
                                string dDateStr = reader.GetString(dDateOrdinal); // Récupère la valeur comme string
                                if (DateTime.TryParse(dDateStr, out DateTime parsedDDate))
                                {
                                    equipment.DDate = parsedDDate; // Si c'est une date valide, l'assigne
                                }
                                else
                                {
                                    equipment.DDate = DateTime.MinValue; // Valeur par défaut si la conversion échoue
                                }
                            }
                            else
                            {
                                equipment.DDate = DateTime.MinValue; // Valeur par défaut si la colonne est null
                            }

                            // Fix for Cost field: Check if it is Int64, then cast to decimal
                            var costOrdinal = reader.GetOrdinal("Cost");
                            if (!reader.IsDBNull(costOrdinal))
                            {
                                // Check if the cost is stored as Int64 and cast it to decimal
                                if (reader.GetFieldType(costOrdinal) == typeof(long))
                                {
                                    equipment.Cost = (decimal)reader.GetInt64(costOrdinal);
                                }
                                else
                                {
                                    equipment.Cost = reader.GetDecimal(costOrdinal);
                                }
                            }
                            else
                            {
                                equipment.Cost = 0.0m; // Default value if Cost is NULL
                            }
                        }
                    }
                }
            }

            return equipment;
        }



        public void UpdateEquipment(Equipment equipment)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string updateQuery = "UPDATE Equipment SET EquipName = @EquipName, EquipDescrip = @EquipDescrip, MusclesUsed = @MusclesUsed, DDate = @DDate, Cost = @Cost WHERE EID = @EID";
                using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                {
                    cmd.Parameters.AddWithValue("@EquipName", equipment.EquipName);
                    cmd.Parameters.AddWithValue("@EDescription", equipment.EquipDescrip);
                    cmd.Parameters.AddWithValue("@MUsed", equipment.MusclesUsed);

                    // Convertir DDate de DateTime à string
                    cmd.Parameters.AddWithValue("@DDate", equipment.DDate.ToString("yyyy-MM-dd")); // Format de date approprié

                    cmd.Parameters.AddWithValue("@Cost", equipment.Cost);
                    cmd.Parameters.AddWithValue("@EID", equipment.Id);

                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
