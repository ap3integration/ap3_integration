namespace AP3.Classes
{
    class Tournois
    {
        private List<Equipes> equipes;
        private List<Epreuve> epreuves;

        public Tournois()
        {
            Equipes = new List<Equipes>();
            Epreuves = new List<Epreuve>();
        }

        public List<Epreuve> Epreuves { get => epreuves; set => epreuves = value; }
        public List<Equipes> Equipes { get => equipes; set => equipes = value; }
    }
}
