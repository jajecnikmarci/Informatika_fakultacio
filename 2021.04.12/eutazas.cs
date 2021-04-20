using System;
using System.IO;

namespace _2021._04._12
{
    struct adat
    {
        public int megallo;
        public int felszall;
        public int ido;
        public int az;
        public string berlet;
        public int ervenyes;
    }
    class eutazas
    {
        static adat[] t = new adat[2000];
        static int n = 0;
        static void feladat1()
        {
            Console.WriteLine("1.feladat");
            StreamReader be = new StreamReader("utasadat.txt");
            int i = 0;
            while (be.EndOfStream)
            {
                string sor = be.ReadLine();
                string[] sorelemek = sor.Split(' ');
                t[i].megallo = Convert.ToInt32(sorelemek[0]);
                string datumido = sorelemek[1];
                string[] datumidoelemek = datumido.Split('-');
                t[i].felszall = Convert.ToInt32(datumidoelemek[0]);
                t[i].ido = Convert.ToInt32(datumidoelemek[1]);
                t[i].az = Convert.ToInt32(sorelemek[2]);
                t[i].berlet = sorelemek[3];
                t[i].ervenyes = Convert.ToInt32(sorelemek[4]);
                i++;
            }
            n = i;
            Console.WriteLine(n);
            be.Close();
        }
        static void feladat2()
        {
            Console.WriteLine("2.feladat");
            Console.WriteLine("A buszra" + n + "ember akart felszállni.");
        }
        static void feladat3()
        {
            Console.WriteLine("3.feladat");
        }
        static void feladat4()
        {
            Console.WriteLine("4.feladat");
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

        }
    }
}
