using System.Data.SqlClient;


namespace AP3.ADO
{
    public abstract class ADO
    {
        protected static SqlConnection connection;

        public static void open()
        {
            string cs = @"Data Source=localhost;Initial Catalog=bd_ap3;Integrated Security=True";
            try
            {
                connection = new SqlConnection(cs);
                connection.Open();
                Console.WriteLine("Connecion ouverte ! ");
            }
            catch (Exception e)
            {
                Console.WriteLine("Erreur !");
            }
        }

        protected static void close()
        {
            if (connection != null)
            {
                connection.Close();
                Console.WriteLine("Connexion fermée");
            }
        }
    }
}

