using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TombWhileCiklus
{
    class Program
    {
        static int[] GeneraltSzamok = new int[100];
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            //Alap programozási tételek
            //->Összegzés tétele ok
            //->átlagolás tétele ok
            //->maximum, minimum kiválasztás tétel ok
            //->eldöntés tétele ok
            //->megszámlálás=leszámolás tétele ok
            //->kiválasztási tétel ok
            //->keresési tétel ok
            //->Rendezési tétel 
            Feladat1Feltoltes();
            Feladat2Kiiratas();
            Feladat3OsszegzesTetele();
            Feladat4Atlagolas();
            Feladat5MinMaxTetel();
            Feladat6EldontesTetel();
            Feladat7LeszamolasTetel();
            Feladat8KivalasztasTetel();
            Feladat9KeresesTetel();
            Feladat10Rendezestetel();
            Console.ReadKey();
        }

        private static void Feladat10Rendezestetel()
        {
            Console.WriteLine("Feladat 10: (n-1)*(n-1)es rendezes tétel");
            int Csere; //növekvő sorrendbe teszem az elemeket
            for (int i = 0; i < GeneraltSzamok.Length-1; i++)
            {
                for (int j = 0; j < GeneraltSzamok.Length-1; j++)
                {
                    if(GeneraltSzamok[j]>GeneraltSzamok[j+1])
                    {
                        Csere = GeneraltSzamok[j];
                        GeneraltSzamok[j] = GeneraltSzamok[j + 1];
                        GeneraltSzamok[j + 1] = Csere;
                    }
                }
            }
            for (int i = 0; i < GeneraltSzamok.Length; i++)
            {
                if (i % 5 == 0)
                {
                    Console.Write("\n\t");
                }
                Console.Write("{0,-3} , ", GeneraltSzamok[i]);
            }
        }

        private static void Feladat9KeresesTetel()
        {
            Console.WriteLine("Feladat 9: Keresés tétele");
            Console.Write("Kérem adja meg melyik számra keresne rá: ");
            int KeresettSzam = int.Parse(Console.ReadLine());
            int Szamlalo = 0;
            while(Szamlalo!=GeneraltSzamok.Length && KeresettSzam!=GeneraltSzamok[Szamlalo])
            { 
                Szamlalo++;
            }
            if(Szamlalo==GeneraltSzamok.Length)
            { Console.WriteLine("\tNincs ereménye a keresésnek"); }
            else
            { Console.WriteLine("\tVan ilyen elem, mégpedig :{0}",Szamlalo+1); }
        }

        private static void Feladat8KivalasztasTetel()
        {
            Console.WriteLine("Feladat 8:Kivalasztas tétele");
            //a 100 benne van a tömbben, és hol?
            int Keres = 100;
            int i = 0;
            while(GeneraltSzamok[i]!=Keres)
            { 
                i++;
            }
            Console.WriteLine("A 100 indexe/előfordulási helye: {0}", i);
        }

        private static void Feladat7LeszamolasTetel()
        {
            Console.WriteLine("Feladat 7: Leszamolas/megszámlálás tétele");
            //Hány hárommal osztható számom van?
            int db = 0;
            for (int i = 0; i < GeneraltSzamok.Length; i++)
            {
                if(GeneraltSzamok[i]%3==0)
                {
                    db++;
                }
            }
            Console.WriteLine("\tEnnyi hárommal osztható számom van a tömbben: {0}",db);
        }

        private static void Feladat6EldontesTetel()
        {
            Console.WriteLine("Feladat 6: Eldöntési tétel");
            //megnézem, hogy az adott tömbben van-e 60nál nagyonn értékü elem
            int db = 0;//klasszikus vizsgálat leszámolással
            for (int i = 0; i < GeneraltSzamok.Length; i++)
            {
                if(GeneraltSzamok[i]>60)
                {
                    db++;
                }
            }
            if(db>0)
            {
                Console.WriteLine("\tVan olyan értéked ami 60-nál nagyobb");
            }
            else
            {
                Console.WriteLine("\tNincs ilyen elem");
            }
            //--------------------------------------------------------------------------------
            bool Dontes = false; //bool vagyis logikai értékü változóval való vizsgálat
            for (int i = 0; i < GeneraltSzamok.Length; i++)
            {
                if(GeneraltSzamok[i]>60)
                { 
                    Dontes = true;
                }
            }
            Console.WriteLine("\tVan 60-nál nagyobb elem ? : {0} ", Dontes);
        }

        private static void Feladat5MinMaxTetel()
        {
            Console.WriteLine("Feladat 5: Minimum maximum kiválasztás tétele");
            //Minimum tétel
            int Min = int.MaxValue;
            for (int i = 0; i < GeneraltSzamok.Length; i++)
            {
                if(GeneraltSzamok[i]<Min)
                {
                    Min = GeneraltSzamok[i];
                }
            }
            Console.WriteLine("\tA tömb legkisebb eleme: {0}", Min);
            int Max = int.MinValue;
            for (int i = 0; i < GeneraltSzamok.Length; i++)
            {
                if(Max<GeneraltSzamok[i])
                {
                    Max = GeneraltSzamok[i];
                }
            }
            Console.WriteLine("\tA tömb legnagyobb eleme: {0}",Max);
        }

        private static void Feladat4Atlagolas()
        {
            Console.WriteLine("Feladat 4 :Átlagolás tétel");
            int Osszeg = 0;
            double Atlag = 0;
            for (int i = 0; i < GeneraltSzamok.Length; i++)
            {
                Osszeg += GeneraltSzamok[i];
                //Osszeg=Osszeg+GeneraltSzamok[i];
            }
            Atlag = (double)Osszeg / GeneraltSzamok.Length;
            Console.WriteLine("\tA generált számok összege: {0}", Osszeg);
            Console.WriteLine("\tA generált számok átlaga: {0:0.00}", Atlag);
        }

        private static void Feladat3OsszegzesTetele()
        {
            Console.WriteLine("Feladat 3: Összegzési tétel");
            int Osszeg = 0;
            for (int i = 0; i < GeneraltSzamok.Length; i++)
            {
                Osszeg += GeneraltSzamok[i];
               //Osszeg=Osszeg+GeneraltSzamok[i];
            }
            Console.WriteLine("\tA generált számok összege: {0}", Osszeg);
        }

        private static void Feladat2Kiiratas()
        {
            Console.WriteLine("Feladat 2: kiiratas");
            for (int i = 0; i < GeneraltSzamok.Length; i++)
            {
                if(i%5==0)
                {
                    Console.Write("\n\t");
                }
                Console.Write("{0,-3} , ",GeneraltSzamok[i]);
            }
        }

        private static void Feladat1Feltoltes()
        {
            Console.WriteLine("Feladat1: feltöltés");
            /* int Szam; //Klasszikus feltöltés nem alkalmas arra, hogy feltételnek megfeleöen adjunk a rendszerhez számokat
             for (int i = 0; i < GeneraltSzamok.Length; i++)
             {
                 Szam = rnd.Next(50, 150);
                 GeneraltSzamok[i] = Szam;
             }*/
            int Szam;
            int db = 0;
            while(db!=GeneraltSzamok.Length)
            {
                Szam = rnd.Next(50, 150);
                if (Szam%5==0)//olyan számokkal töltöm fel a tömböt amik 5-el oszthatók
                {
                    GeneraltSzamok[db] = Szam;
                    db++;
                    //biztosítja, hogy a feltételnek eleget tevő számok kerüljenek csak be, illetve leállítja a folyamatot,
                    //ha elérte a program a kívánt elemszámot
                }  
            }
        }
    }
}
