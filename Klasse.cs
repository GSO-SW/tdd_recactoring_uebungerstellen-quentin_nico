namespace refactoring
{
    class Transportmittel
    {

        int anzahlTriebwerke = 0;
        int anzahlFluegel = 0;
        int anzahlTueren = 0;
        int anzahlReifen = 0;


        public int AnzahlTriebwerke
        {
            get {return anzahlTriebwerke;}
        }
        public int AnzahlFluegel
        {
            get {return anzahlFluegel;}
        }
        public int AnzahlTueren
        {
            get {return anzahlTueren;}
        }
        public int AnzahlReifen
        {
            get{return anzahlReifen;}
        }

        
        public Transportmittel(int anzahlReifen,int anzahlTueren,int anzahlFluegel, int anzahlTriebwerke)
        {
            this.anzahlReifen = anzahlReifen;
        }


    }
}