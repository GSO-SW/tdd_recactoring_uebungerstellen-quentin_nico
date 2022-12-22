namespace refactoring
{
    class Transportmittel
    {

        
        int anzahlReifen = 0;
        int anzahlTurbinen = 0;
        int anzahlSchiffsschrauben = 0;

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

        
        public Transportmittel(int anzahlReifen,int anzahlTurbinen,int anzahlSchiffsschrauben)
        {
            this.anzahlReifen = anzahlReifen;
            this.anzahlTurbinen = anzahlTurbinen;
            this.anzahlSchiffsschrauben = anzahlSchiffsschrauben;

        }


    }
}