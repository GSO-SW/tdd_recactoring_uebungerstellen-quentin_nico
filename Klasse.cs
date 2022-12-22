namespace refactoring
{
    class Transportmittel
    {
        int ticket = 0;
        int anzahlTriebwerke = 0;
        int anzahlFluegel = 0;
        int anzahlTueren = 0;
        int anzahlReifen = 0;
        int anzahlTurbinen = 0;
        int anzahlSchiffsschrauben = 0;
        double kilometerstand = 0;
        double strecke = 0;


        public int Ticket
        {
            set {ticket = value;}
            get {return ticket;}
        }
        public double strecke
        {
            get {return Strecke;}
        }
        public double Kilometerstand
        {
            if(value > 0)
            {
                set{kilometerstand = value;}
            }
            else 
            {
                throw new ArgumentOutOfRangeExeption("Kilometerstand kann nicht negativ sein");
            }
            get {return kilometerstand;}
        }
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
            this.anzahlTueren = anzahlTueren;
            this.anzahlFluegel = anzahlFluegel;
            this.anzahlTriebwerke = anzahlTriebwerke;
        }

        public double StreckeZurueckgelegt(double strecke)
        {
            kilometerstand = kilometerstand + strecke;
            KilometerstandBerechnen(kilometerstand,strecke)
        }

        public double KilometerstandBerechnen(double kilometerstand , double streckeGefahren)
        {
            kilometerstand = kilometerstand + streckeGefahren;
            return kilometerstand;
        }

        public int PolizeiGoenntTicketWieVieleHabIchDenn(int ticket)
        {
            ticket = ticket + 1
            return ticket;
        }
    }
}