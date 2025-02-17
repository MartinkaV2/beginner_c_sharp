namespace DolgozatGyakorlas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *1. Feladat
                Készíts egy programot ahol létrehozunk egy paratlan nevü listát adjunk hozzá 32 db véletlenszerű számot 
                1-50 között és ki kell írni, hogy a szám páros vagy páratlan, 
                de a listához csak a páratlan számokat adjuk hozzá. 
                Írjuk ki a lista tartalmát egymás mellé vesszővel elválasztva. 
                Írjuk ki a lista hosszát is.

             */
            /*
            var rnd = new Random();     // Itt egy Random objektumot hozol létre, amely segítségével véletlenszámokat generálhatsz.
            List<int> paratlan = new List<int>();     // Létrehozol egy üres listát, amely az int típusú páratlan számokat fogja tárolni.
            
            while (paratlan.Count < 32) {      // Ez a ciklus addig fut, amíg a paratlan lista elemszáma el nem éri a 32-t.
                int szam = rnd.Next(1,50);     // Minden ciklusban generálsz egy véletlenszámot 1 és 49 között (rnd.Next(1, 50)).
                if (szam % 2 == 0)     // Ellenőrzöd, hogy a szám páros-e (szam % 2 == 0). Ha igen, akkor kiírod, hogy páros, de nem adod hozzá a listához.
                {
                    Console.WriteLine($"A szám páros{szam}.");
                }
                else {
                    Console.WriteLine($"A szám páratlan {szam}");
                    paratlan.Add(szam);
                }
            }

            Console.WriteLine(string.Join(";",paratlan));     // A string.Join metódussal vesszővel elválasztva kiírod a lista elemeit. Itt azonban figyelni kell, hogy a kód ";"-t használ elválasztóként a vessző helyett.
            Console.WriteLine($"A lista hossza: {paratlan.Count}");
            */
            
             /*
             * 2. Feladat
                Készítsünk egy szamok nevű listát, 
                kérjünk be a felhasználótól 7 db számot, 
                és növeljük meg a bekért számok értékét kettővel és ha nagyobb, 
                mint 20 és kisebb mint 100 akkor adjuk hozzá a listához. 
                Számoljuk, hanyadik szám lett a listához adva 
                és a végén írjuk ki a lista hosszát.
            
             

            List  <int> szamok = new List<int>();     // Egy szamok nevű integer típusú listát hoz létre, amely kezdetben üres.
            int db = 0;     // Egy db nevű változót inicializálunk nullára, amely a hozzáadott számok darabszámát fogja számlálni.
            for (int i = 0; i < 7; i++)     // Egy for ciklus, amely 7 alkalommal fut le, hogy 7 számot kérjen be a felhasználótól.
            {
                Console.WriteLine("Adj meg egy számot");
                int szam = int.Parse(Console.ReadLine());
                int megnovelt = szam + 2;     //Kéri a felhasználótól egy szám megadását, majd az int.Parse segítségével konvertálja a beolvasott szöveget számmá. A beolvasott számhoz hozzáad 2-t, és ezt az eredményt tárolja a megnovelt változóban.
                if (megnovelt > 20 && megnovelt < 100)    //Ellenőrzi, hogy a megnövelt szám 20 és 100 között van-e. Ha igen, hozzáadja a szamok listához, növeli a db számlálót, és kiírja, hogy hányadik szám lett hozzáadva. Ha nem, akkor jelez, hogy a szám nem lett hozzáadva.
                {
                    szamok.Add(megnovelt);
                    db++;
                    Console.WriteLine($"{db} szám lett a listához adva.");
                    
                }
                else {
                    Console.WriteLine("A szám nem lett a listához adva.");
                }
            }

            Console.WriteLine($"A lista hossza: {szamok.Count}");    //A ciklus után kiírja a szamok lista hosszát, ami az összes hozzáadott szám mennyiségét jelenti.
            */
