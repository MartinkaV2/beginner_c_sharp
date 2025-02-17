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
            var rnd = new Random(); // Itt egy Random objektumot hozol létre, amely segítségével véletlenszámokat generálhatsz.
            List<int> paratlan = new List<int>(); // Létrehozol egy üres listát, amely az int típusú páratlan számokat fogja tárolni.
            
            while (paratlan.Count < 32) {  // Ez a ciklus addig fut, amíg a paratlan lista elemszáma el nem éri a 32-t.
                int szam = rnd.Next(1,50); // Minden ciklusban generálsz egy véletlenszámot 1 és 49 között (rnd.Next(1, 50)).
                if (szam % 2 == 0) // Ellenőrzöd, hogy a szám páros-e (szam % 2 == 0). Ha igen, akkor kiírod, hogy páros, de nem adod hozzá a listához.
                {
                    Console.WriteLine($"A szám páros{szam}.");
                }
                else {
                    Console.WriteLine($"A szám páratlan {szam}");
                    paratlan.Add(szam);
                }
            }

            Console.WriteLine(string.Join(";",paratlan)); // A string.Join metódussal vesszővel elválasztva kiírod a lista elemeit. Itt azonban figyelni kell, hogy a kód ";"-t használ elválasztóként a vessző helyett.
            Console.WriteLine($"A lista hossza: {paratlan.Count}");
            */
