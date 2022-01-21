using System;
namespace degisken
{
    class Program
    {
        static void Main(string[] args)
        {
           int deger=10;
            Console.WriteLine(deger);
            byte b=5;
            Console.WriteLine(b); //sbyte,short,ushort,Int16
            DateTime dt=DateTime.Now;
            Console.WriteLine(dt);

            object o1="x";
            object o2=4;
            object o3='a';

            //string ifadeler
            string str=string.Empty;
            string ad="alper";
            string soyad="saçmaözü";
            string tamIsim=ad + " " + soyad;
            Console.WriteLine(tamIsim);

            //int ifadeler
            int sayi1=10;
            int sayi2=14;
            int toplam =sayi1+sayi2;
            Console.WriteLine(toplam);

            //boolean
            bool bool1=6>2;
            Console.WriteLine(bool1);

            //değişkenler
            string str12="10";
            int int12=14;
             string yenideger=str12 + int12.ToString();
             Console.WriteLine(yenideger);

             int int13=int12+Convert.ToInt32(str12);
             Console.WriteLine(int13);
             
             //tarih
             string datetime1=DateTime.Now.ToString("MM.dd.yyyy");
             Console.WriteLine(datetime1);
             
             string datetime2=DateTime.Now.ToString("dd/MM/yyyy");
             Console.WriteLine(datetime2);

             //saat
             string hour=DateTime.Now.ToString("HH:mm");
             Console.WriteLine(hour);
        }
    }
}

