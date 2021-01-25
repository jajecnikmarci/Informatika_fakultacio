using System;
using System.IO;

namespace _2021._01._18
{
    struct adat
    {
        public string nev;
        public int kor;
        public int magassag;
    }
    class Program
    {
        static adat[] t = new adat[50];
        static int n = 0;
        static void beolvas()
        {
            StreamReader be = new StreamReader("diakok.txt");
            int i = 0;
            while (!be.EndOfStream)
            {
                string sor = be.ReadLine();
                string[] sorelemek = sor.Split(' ');
                t[i].nev = sorelemek[0];
                t[i].kor =Convert.ToInt32( sorelemek[1]);
                t[i].magassag = Convert.ToInt32(sorelemek[2]);
                i++;
            }
            n = i;
            be.Close();
        }
        static void nevsor()
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(t[i].nev);
            }
        }
        static void magasak()
        {
            for (int i = 0; i < n; i++)
            {
                if (t[i].magassag>200)
                {
                    Console.WriteLine(t[i].nev+" "+t[i].magassag);
                }
            }
        }
        static void Main(string[] args)
        {
            beolvas();
            nevsor();
            magasak();
            Console.ReadKey();
        }
    }
}
