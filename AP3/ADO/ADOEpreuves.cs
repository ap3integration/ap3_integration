using AP3.Classes;
using System.Data.SqlClient;

namespace AP3.ADO
{
    internal class ADOEpreuves : ADO
    {
        public ADOEpreuves() { }

        public static List<Epreuve> getAll()
        {
            List<Epreuve> epreuves = new List<Epreuve>();
            open();
            try
            {
                string query = "SELECT * FROM Epreuves";
                using (SqlCommand cmd = new SqlCommand(query, ADO.connection)) // Associe la connexion
                {

                    SqlDataReader reader = cmd.ExecuteReader(); // Execution commande

                    while (reader.Read())
                    {
                        epreuves.Add(new Epreuve(reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));
                    }




                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                ADO.close();
            }


            return epreuves;
        }
    }
}

