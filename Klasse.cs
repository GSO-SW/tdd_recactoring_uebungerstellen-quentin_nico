namespace refactoring
{
    class Transportmittel
    {

        int anzahlTriebwerke = 0;
        int anzahlFluegel = 0;
        int anzahlTueren = 0;
        int anzahlReifen = 0;
        int anzahlTurbinen = 0;
        int anzahlSchiffsschrauben = 0;


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

        public int anzahlTurbinen
        {
            get{return anzahlTurbinen;}
        }

        public int AnzahlSchiffsschrauben
        {
            get{return anzahlSchiffsschrauben;}
        }

        
        public Transportmittel(int anzahlReifen,int anzahlTurbinen,int anzahlSchiffsschrauben,int anzahlTueren,int anzahlFluegel, int anzahlTriebwerke)
        {
            this.anzahlReifen = anzahlReifen;
            this.anzahlTurbinen = anzahlTurbinen;
            this.anzahlSchiffsschrauben = anzahlSchiffsschrauben;

        }


    }
}