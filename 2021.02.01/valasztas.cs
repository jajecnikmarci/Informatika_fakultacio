using System;
using System.IO;

namespace _2021._02._01
{
    struct adat
    {
        public int ker;
        public int szavazat;
        public string vez_nev;
        public string ker_nev;
        public string part;
    }
    struct keres
    {
        public string keres_vez_nev;
        public string keres_ker_nev;
    }
    class Program
    {
        static int lakossag = 12345;
        static adat[] t = new adat[100];
        static int n = 0;
        static keres[] k = new keres[1];
        static void feladat1()
        {
            Console.WriteLine("1.feladat");
            StreamReader be = new StreamReader("szavazatok.txt");
            int i = 0;
            while (!be.EndOfStream)
            {
                string sor = be.ReadLine();
                string[] sorelemek = sor.Split(" ");
                t[i].ker= Convert.ToInt32( sorelemek[0]);
                t[i].szavazat= Convert.ToInt32(sorelemek[1]);
                t[i].vez_nev= sorelemek[2];
                t[i].ker_nev= sorelemek[3];
                t[i].part= sorelemek[4];
                i++;
            }
            be.Close();
            n = i;
            Console.WriteLine(n);
        }
        static void feladat2()
        {
            Console.WriteLine("2.feladat");
            Console.WriteLine("A helyhatósági választáson " + n + " képviselőjelölt indult.");
        }
        static void feladat3()
        {
            Console.WriteLine("3.feladat");
            Console.WriteLine("Kérem adja meg a kívánt személy teljes nevét szóközzel elválasztva:");
            string keresett_nev = Console.ReadLine();
            string[] keresett_nev_elemek = keresett_nev.Split(" ");
            k[0].keres_vez_nev = keresett_nev_elemek[0];
            k[0].keres_ker_nev = keresett_nev_elemek[1];
            int a = 0;
            for (int i = 0; i < n; i++)
            {
                if (t[i].vez_nev==k[0].keres_vez_nev)
                {
                    if (t[i].ker_nev==k[0].keres_ker_nev)
                    {
                        Console.WriteLine(t[i].szavazat);
                        a = 1;
                    }
                }
            }
            if (a!=1)
            {
                Console.WriteLine("Ilyen nevű képviselőjelölt nem szerepela nyilvántartásban!");
            }
        }
        static void feladat4()
        {
            Console.WriteLine("4.feladat");
            int b = 0;
            float c = 5;
            for (int i = 0; i < n; i++)
            {
                b += t[i].szavazat;
            }
            c = (float)b / (float)lakossag;
            c =(float)Math.Round(c * 100, 2);
            Console.WriteLine("A választáson "+b+" állampolgár, a jogosultak "+c+"%-a vett részt.");
        }
        static void feladat5()
        {
            Console.WriteLine("5.feladat");
        }
        static void feladat6()
        {
            Console.WriteLine("6.feladat");
        }
        static void feladat7()
        {
            Console.WriteLine("7.feladat");
        }
        static void Main(string[] args)
        {
            feladat1();
            feladat2();
            feladat3();
            feladat4();
            feladat5();
            feladat6();
            feladat7();
            Console.ReadKey();
        }
    }
}
