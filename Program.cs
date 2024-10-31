namespace Program{
    class Program{
        public static void Main(String[] args){
            Zvire kocka = Zvire.zvireKocka();
            Zvire had = Zvire.zvireHad();
            Zvire lev = Zvire.zvireLev();
            Console.WriteLine(kocka.vypis());
            Console.WriteLine(had.vypis());
            Console.WriteLine(lev.vypis());
        }
    }
}