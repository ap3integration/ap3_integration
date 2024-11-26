namespace AP3.Classes
{
    public class Epreuve
    {
        private int id_epreuve;
        private string nom_epreuve;
        private string statut_epreuve;
        private Dictionary<Equipes, int> coefficients;


        public Epreuve(string _nom_epreuve, string _statut_epreuve)
        {
            id_epreuve = 0;
            Nom_epreuve = _nom_epreuve;
            Statut_epreuve = _statut_epreuve;
            coefficients = new Dictionary<Equipes, int>();
        }
        public Epreuve(int _id, string _nom_epreuve, string _statut_epreuve)
        {
            id_epreuve = _id;
            Nom_epreuve = _nom_epreuve;
            Statut_epreuve = _statut_epreuve;
            coefficients = new Dictionary<Equipes, int>();
        }
        public string Nom_epreuve { get => nom_epreuve; set => nom_epreuve = value; }
        public string Statut_epreuve { get => statut_epreuve; set => statut_epreuve = value; }
        public int Id_epreuve { get => id_epreuve; set => id_epreuve = value; }
        public Dictionary<Equipes, int> Coefficients { get => coefficients; set => coefficients = value; }

        public override string ToString()
        {
            return this.nom_epreuve;
        }
    }
}
