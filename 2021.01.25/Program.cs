using System;
using System.IO;

namespace _2021._01._25
{
    struct adat
    {
        public string nev;
        public int darab;
        public int ar;
    }
    class Program
    {
        static adat[] t = new adat[50];
        static int n = 0;
        static void beolvas()
        {
            StreamReader be = new StreamReader("csoki.txt");
            int i = 0;
            while (!be.EndOfStream)
            {
                string sor = be.ReadLine();
                string[] sorelemek = sor.Split(' ');
                t[i].nev = sorelemek[0];
                t[i].ar = Convert.ToInt32(sorelemek[1]);
                t[i].darab = Convert.ToInt32(sorelemek[2]);
                i++;
            }
            n = i;
            be.Close();
            Console.WriteLine(n);
        }
        static void kiir()
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(t[i].nev + " " + t[i].ar +" Ft");
            }
        }
        static void legdragabb()
        {
            int legdragabb = 0;
            int o = 0;
            for (int i = 0; i < n; i++)
            {
                if (t[i].ar>legdragabb)
                {
                    legdragabb = t[i].ar;
                    o = i;
                }
            }
            Console.WriteLine("A legdrágább csoki a " + t[o].nev);
        }
        static void bevetel()
        {
            int a = 0;
            for (int i = 0; i < n; i++)
            {
                a += t[i].ar * t[i].darab;
            }
            Console.WriteLine("Az össz bevétel "+a);
        }
        static void Main(string[] args)
        {
            beolvas();
            kiir();
            legdragabb();
            bevetel();
            Console.ReadKey();
        }
    }
}
