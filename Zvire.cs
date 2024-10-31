namespace Program{
    class Zvire{
        private string zvuk;
        private string rasa;  
        private int vek;

        private Zvire(string zvuk, string rasa, int vek){
            this.zvuk = zvuk;
            this.rasa = rasa;
            this.vek = vek;
        }

        public static Zvire zvireKocka(){
            Zvire kocka = new Zvire("meow without the t", "bristká kočka", 3);
            return kocka;
        }

        public static Zvire zvirePes(){
            Zvire pes = new Zvire("Haf", "Zlatý Retriever", 2);
            return pes;
        }

        public static Zvire zvireKrava(){
            Zvire krava = new Zvire("Moooooo", "Kráva z obalu Milky", 1);
            return krava;
        }

        public static Zvire zvireZaba(){
            Zvire zaba = new Zvire("kuňk", "Skokan Lesní", 4);
            return zaba;
        }

        public static Zvire zvireKun(){
            Zvire kun = new Zvire("íííháááá", "shirský kůň", 6);
            return kun;
        }

        public static Zvire zvireJester(){
            Zvire jester = new Zvire("*zvuk ještěra*", "Agama", 8);
            return jester;
        }

        public static Zvire zvireHad(){
            Zvire had = new Zvire("SSSSSSSSSSSSSSSSSS", "Zmije", 2);
            return had;
        }

        public static Zvire zvirePanda(){
            Zvire panda = new Zvire("bek bek", "Červená Panda", 3);
            return panda;
        }

        public static Zvire zvireMedved(){
            Zvire medved = new Zvire("brum brum", "Kokainový Medvěd", 3);
            return medved;
        }

        public static Zvire zvireLev(){
            Zvire lev = new Zvire("řev", "Lev Perský", 15);
            return lev;
        }

        public string zvukZvirete(){
            return zvuk;
        }

        public string rasaZvirete(){
            return rasa;
        }

        public string vekZvirete(){
            return vek.ToString();
        }

        public string vypis(){
            return $"zvuk:{zvuk}\nrasa:{rasa}\nvěk:{vek}\n----------------------------";
        }

    }
}