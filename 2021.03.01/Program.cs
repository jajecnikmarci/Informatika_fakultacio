using System;
using System.IO;

namespace cegesauto
{
    struct adat
    {
        public int nap;
        public string ido;
        public string rendszam;
        public int szemaz;
        public int km;
        public int kibe;
    }
    class Program
    {
        static adat[] t = new adat[500];
        static int n = 0;
        static string[] autok = new string[10]
        {
            "CEG300",
            "CEG301",
            "CEG302",
            "CEG303",
            "CEG304",
            "CEG305",
            "CEG306",
            "CEG307",
            "CEG308",
            "CEG309",
        };
        static void feladat1()
        {
            Console.WriteLine("1.feladat");
            StreamReader be = new StreamReader("autok.txt");
            int i = 0;
            while(!be.EndOfStream)
            {
                string sor = be.ReadLine();
                string[] sorelemek = sor.Split(' ');
                t[i].nap =Convert.ToInt32( sorelemek[0]);
                t[i].ido = sorelemek[1];
                t[i].rendszam = sorelemek[2];
                t[i].szemaz = Convert.ToInt32(sorelemek[3]);
                t[i].km = Convert.ToInt32(sorelemek[4]);
                t[i].kibe = Convert.ToInt32(sorelemek[5]);
                i++;
            }
            n = i;
            be.Close();            
        }
        static void feladat2()
        {
            Console.WriteLine("2.feladat");
            int s =0;
            for (int i = 0; i < n; i++)
            {
                if (t[i].kibe==0)
                {
                    s = i;
                }
            }
            Console.WriteLine(t[s].nap+". nap rendszám: "+t[s].rendszam);
        }
        static void feladat3()
        {
            Console.WriteLine("3.feladat");
            Console.Write("Nap: ");
            int nap = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A forgalom a "+nap+". napon:");
            for (int i = 0; i < 10; i++)
            {
                if (t[i].nap==nap)
                {
                    if (t[i].kibe==0)
                    {
                        Console.WriteLine(t[i].ido + " " + t[i].rendszam + " " + t[i].szemaz + " ki");
                    }
                    else
                    {
                        Console.WriteLine(t[i].ido + " " + t[i].rendszam + " " + t[i].szemaz + " be");
                    }
                }
            }
        }
        static void feladat4()
        {
            Console.WriteLine("4.feladat");
            int kint = 0;
            for (int i = 0; i < n; i++)
            {
                if (t[i].kibe==0)
                {
                    kint++;
                }
                else
                {
                    kint--;
                }
            }
            Console.WriteLine("A hónap végén "+kint+" darab kocsi volt kinn.");
        }
        static void feladat5()
        {
            Console.WriteLine("5.feladat");
            int kikm = 0;
            int bekm = 0;
            for (int a = 0; a < 10; a++)
            {
                int ossz = 0;
                for (int i = 0; i < n; i++)
                {
                    if (t[i].rendszam==autok[a])
                    {
                        if (t[i].kibe==0)
                        {
                            kikm = t[i].km;
                        }
                        else
                        {
                            bekm = t[i].km;
                            ossz += (bekm - kikm);
                        }
                    }
                }
                Console.WriteLine(autok[a] + " " + ossz+" km");
            }          
        }
        static void feladat6()
        {
            Console.WriteLine("6.feladat");
            int maxkm = 0;
            int szemely = 0;
            int kikm = 0;
            int bekm = 0;
            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    if (t[i].rendszam==autok[j])
                    {
                        if (t[i].kibe==0)
                        {
                            kikm = t[i].km;
                        }
                        else
                        {
                            bekm = t[i].km;
                            if (bekm-kikm>maxkm)
                            {
                                maxkm = bekm - kikm;
                                szemely = t[i].szemaz;
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Leghosszabb út: "+maxkm+" km, személy: "+szemely);
        }
        static void feladat7()
        {
            Console.WriteLine("7.feladat");
            Console.WriteLine("Rendszám: ");
            string rendszam = Console.ReadLine();
            string fajlnev = rendszam + "_menetlevel.txt";
            StreamWriter ki = new StreamWriter(fajlnev);
            for (int i = 0; i < n; i++)
            {
                if (t[i].rendszam==rendszam)
                {
                    if (t[i].kibe == 0)
                    {
                        ki.Write(t[i].szemaz + "\t" + t[i].nap + ". " + t[i].ido + "\t" + t[i].km + " km \t");
                    }
                    else
                    {
                        ki.WriteLine(t[i].nap + ". " + t[i].ido + "\t" + t[i].km + " km");
                    }
                }
            }
            ki.Close();
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
