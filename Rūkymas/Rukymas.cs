namespace RukymasApp.Models
{
    public class Rukymas
    {
        private int cigaretesPerDiena;
        private int cigaretesPakelyje;
        private decimal pakelioKaina;

        public Rukymas(int cigaretesPerDiena,
                       int cigaretesPakelyje,
                       decimal pakelioKaina)
        {
            this.cigaretesPerDiena = cigaretesPerDiena;
            this.cigaretesPakelyje = cigaretesPakelyje;
            this.pakelioKaina = pakelioKaina;
        }

        public int ImtiCigaretesPerDiena()
        {
            return cigaretesPerDiena;
        }

        public int ImtiCigaretesPakelyje()
        {
            return cigaretesPakelyje;
        }

        public decimal ImtiPakelioKaina()
        {
            return pakelioKaina;
        }

        public decimal DienosIslaidos()
        {
            return cigaretesPerDiena * pakelioKaina
                   / cigaretesPakelyje;
        }

        public decimal MenesioIslaidos()
        {
            return DienosIslaidos() * 30;
        }

        public decimal MetuIslaidos()
        {
            return DienosIslaidos() * 365;
        }

        public int MetuCigareciuKiekis()
        {
            return cigaretesPerDiena * 365;
        }
    }
}