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
        static int szavazo = 0;
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
            float c = 5;
            for (int i = 0; i < n; i++)
            {
                szavazo += t[i].szavazat;
            }
            c = (float)szavazo / (float)lakossag;
            c =(float)Math.Round(c * 100, 2);
            Console.WriteLine("A választáson "+szavazo+" állampolgár, a jogosultak "+c+"%-a vett részt.");
        }
        static void feladat5()
        {
            Console.WriteLine("5.feladat");
            int g = 0;
            for (int i = 0; i < n; i++)
            {
                if (t[i].part=="GYEP")
                {
                    g += t[i].szavazat;
                }
            }
            double gszazalek = (double)g / szavazo*100;
            gszazalek = (double)Math.Round(gszazalek, 2);
            Console.WriteLine("Gyümölcsevők Pártja= "+gszazalek+"%");
            int h = 0;
            for (int i = 0; i < n; i++)
            {
                if (t[i].part == "HEP")
                {
                    h += t[i].szavazat;
                }
            }
            double hszazalek = (double)h / szavazo * 100;
            hszazalek = (double)Math.Round(hszazalek, 2);
            Console.WriteLine("Húsevők Pártja= " + hszazalek + "%");
            int te = 0;
            for (int i = 0; i < n; i++)
            {
                if (t[i].part == "TISZ")
                {
                    te += t[i].szavazat;
                }
            }
            double teszazalek = (double)te / szavazo * 100;
            teszazalek = (double)Math.Round(teszazalek, 2);
            Console.WriteLine("Tejivók Szövetsége= " + teszazalek + "%");
            int z = 0;
            for (int i = 0; i < n; i++)
            {
                if (t[i].part == "ZEP")
                {
                    z += t[i].szavazat;
                }
            }
            double zszazalek = (double)z / szavazo * 100;
            zszazalek = (double)Math.Round(zszazalek, 2);
            Console.WriteLine("Zöldségevők Pártja= " + zszazalek + "%");
            int f = 0;
            for (int i = 0; i < n; i++)
            {
                if (t[i].part == "-")
                {
                    f += t[i].szavazat;
                }
            }
            double fszazalek = (double)f / szavazo * 100;
            fszazalek = (double)Math.Round(fszazalek, 2);
            Console.WriteLine("Független jelöltek= " + fszazalek + "%");
        }
        static void feladat6()
        {
            Console.WriteLine("6.feladat");
            int max = 0;
            for (int i = 0; i < n; i++)
            {
                if (t[i].szavazat>max)
                {
                    max = t[i].szavazat;
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (t[i].szavazat==max)
                {
                    if (t[i].part=="-")
                    {
                        Console.WriteLine(t[i].vez_nev+" "+ t[i].ker_nev+" Független");
                    }
                    else
                    {
                        Console.WriteLine(t[i].vez_nev + " " + t[i].ker_nev+" "+t[i].part);
                    }
                }
            }
        }
        static void feladat7()
        {
            Console.WriteLine("7.feladat");
            StreamWriter ki = new StreamWriter("kepviselok.txt");
            for (int ker = 1; ker <=8 ; ker++)
            {
                int max = 0;
                int s = 0;
                for (int i = 0; i < n; i++)
                {
                    if (t[i].ker==ker)
                    {
                        if (t[i].szavazat>max)
                        {
                            max = t[i].szavazat;
                            s = i;
                        }
                    }
                }
                if (t[s].part=="-")
                {
//                    ki.WriteLine(ker+"")
                }
            }
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
