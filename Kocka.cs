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

        public static void zvireKocka(){
            Zvire kocka = new Zvire("meow withou the t", "bristká kočka", 3);
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
    }
}