using AP3.Classes;
using System.Data.SqlClient;

namespace AP3.ADO
{

    public class ADOEleves : ADO
    {

        public void Add(string nom, string prenom, int age)
        {
            ADO.open();
            try
            {
                string query = "INSERT INTO Eleves (Nom, Prenom, Age) VALUES (@Nom, @Prenom, @Age)";
                using (SqlCommand cmd = new SqlCommand(query, ADO.connection)) // Associe la connexion
                {
                    cmd.Parameters.AddWithValue("@Nom", nom);
                    cmd.Parameters.AddWithValue("@Prenom", prenom);
                    cmd.Parameters.AddWithValue("@Age", age);

                    cmd.ExecuteNonQuery(); // Execution commande
                    Console.WriteLine("Élève ajouté avec succès !");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur : " + ex.Message);
            }
            finally
            {
                ADO.close();
            }
        }

        public void Delete(int id)
        {
            ADO.open();
            try
            {
                string query = "DELETE FROM Eleves WHERE id=@id";
                using (SqlCommand cmd = new SqlCommand(query, ADO.connection)) // Associe la connexion
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery(); // Execution commande
                    Console.WriteLine("Élève supprimé avec succès !");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                ADO.close();
            }
        }

        public void Update(string prenom, string nom, string promo, int id)
        {
            ADO.open();
            if (id <= 0)
            {
                Console.WriteLine("Il faut obligatoirement l'id de la personne pour modifier");
                return;
            }

            try
            {
                string query = "UPDATE Eleves SET prenom = @p, nom = @n, promo = @pr WHERE id = @id";
                using (SqlCommand cmd = new SqlCommand(query, ADO.connection)) // Associe la connexion
                {

                    if (prenom == null && nom == null && promo == null)
                    {
                        Console.WriteLine("Il faut remplir au moins un champ.");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@p", prenom);
                        cmd.Parameters.AddWithValue("@n", nom);
                        cmd.Parameters.AddWithValue("@pr", promo);
                        cmd.Parameters.AddWithValue("@id", id);
                    }



                    cmd.ExecuteNonQuery(); // Execution commande
                    Console.WriteLine("Élève supprimé avec succès !");
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
        }

        public static List<Eleves> getAll()
        {
            List<Eleves> eleves = new List<Eleves>();

            try
            {
                string query = "SELECT * FROM Eleves";
                using (SqlCommand cmd = new SqlCommand(query, ADO.connection)) // Associe la connexion
                {

                    SqlDataReader reader = cmd.ExecuteReader(); // Execution commande






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


            return eleves;
        }







    }
}
