namespace AP3.Classes
{
    public class Eleves
    {
        private string prenom;
        private string nom;
        private string promo;
        public Eleves(string _prenom, string _nom, string _promo)
        {
            Prenom = _prenom;
            Nom = _nom;
            Promo = _promo;
        }

        public string Prenom { get => prenom; set => prenom = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Promo { get => promo; set => promo = value; }
    }

}
