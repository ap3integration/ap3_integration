namespace AP3.Classes
{
   public class Equipes
    {
        private string nom;
        private List<Eleves> eleves;
        private Dictionary<Epreuve, int> resultats;



        public Equipes(string _nom)
        {
            Nom = _nom;
            Eleves = new List<Eleves>();
            Resultats = new Dictionary<Epreuve, int>();
        }

        public string Nom { get => nom; set => nom = value; }
        public Dictionary<Epreuve, int> Resultats { get => resultats; set => resultats = value; }
        internal List<Eleves> Eleves { get => eleves; set => eleves = value; }
    }
}
