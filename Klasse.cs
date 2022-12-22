namespace refactoring
{
    class Transportmittel
    {

        
        int anzahlReifen = 0;

        public int AnzahlReifen
        {
            get{return anzahlReifen;}
        }

        
        public Transportmittel(int anzahlReifen)
        {
            this.anzahlReifen = anzahlReifen;
        }


    }
}