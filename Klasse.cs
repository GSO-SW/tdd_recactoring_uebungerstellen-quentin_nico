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
        string kennung = UNKNOWN;


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

        public string Kennung
        {
            get{return kennung;}
        }

        
        public Transportmittel(int anzahlReifen,int anzahlTurbinen,int anzahlSchiffsschrauben,int anzahlTueren,int anzahlFluegel, int anzahlTriebwerke)
        {
            this.anzahlReifen = anzahlReifen;
            this.anzahlTurbinen = anzahlTurbinen;
            this.anzahlSchiffsschrauben = anzahlSchiffsschrauben;
            this.kennung = ZufaelligeKennungVergeben();

        }


        

        private string ZufaelligeKennungVergeben()
        {
            string k = "";
            int l = 10;
            char[] chars = new char[]{'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};

            Random r = new Random();

            int i = r.Next(1,11);


            while(k.Length < l)
            {
                if(i > 8)
                {
                    k = k + chars[r.Next(0,chars.Length-1)];
                }
                else
                {
                    k = k + Convert.ToSting(r.Next(1,10));
                }
            }

            return k;


        }


    }
}