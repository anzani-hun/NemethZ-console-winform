using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//csv eléréséhez kell
using System.IO;

namespace Console_CSV_adatbazissal
{
    class Program
    {
        //dinamikus lista létrehozása (dolgozok néven): 
        static List<Dolgozo> dolgozok = new List<Dolgozo>();

        static void Main(string[] args)
        {
            //beolvasás metódus generáltatása.
            beolvasas();

            feladat01();
            feladat02();

            Console.WriteLine("\nProgram vége!");
            Console.ReadKey();
        }




        private static void feladat02()
        {
            // 2. feladat: a legmagasabb keresetű dolgozó kiíratása
            Console.WriteLine("2. feladat megoldása: ");

            //lamba operátorral keresés FINDet használva  ber keresése -> BÉR
            Dolgozo max = dolgozok.Find(a => a.ber == dolgozok.Max(b => b.ber));

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"A legtöbbet kereső dolgozó: {max.nev} és ennyit keres: {max.ber} Ft");
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void feladat01()
        {
            //dolgozók számának kiíratása:
            Console.WriteLine("1. feladat megoldása: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"A dolgozók száma: {dolgozok.Count} fő\n");
            Console.ForegroundColor = ConsoleColor.White;
        }


        //ezt a metódust fent generáltattuk le
        private static void beolvasas()
        {
            using (StreamReader sr = new StreamReader("dolgozok.csv"))
            {
                //a csv fejléc átugrása, kihagyása.
                sr.ReadLine();


                //olvassa amíg nincs vége a fájlnak
                while (!sr.EndOfStream)
                {
                    //a sorokból a macskakörmöket kivesszük és a vesszőnél elválasztva feldaraboljuk
                    string[] line = sr.ReadLine().Replace('"', ' ').Split(',');

                    //Dolgozo példányosítása     // adatbázis fejléce: "nev","neme","reszleg","belepesev","ber"  > int az utolsó kettő
                    Dolgozo dolgozo = new Dolgozo(line[0].Trim(), line[1].Trim(), line[2].Trim(), int.Parse(line[3].Trim()), int.Parse(line[4].Trim()));
                    
                    //dolgozók hozzáadása soronként
                    dolgozok.Add(dolgozo);
                }
            }
        }
    }
}
