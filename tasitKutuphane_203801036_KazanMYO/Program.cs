using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tasit;

namespace tasitKutuphane_203801036_KazanMYO
{
    class Program
    {
        static void Main(string[] args)
        {
            araba arb = new araba();
            int arbsay = 0; 
            Console.WriteLine("Kaç adet araba girişi yapacaksınız?");
            arbsay = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < arbsay; i++)
            {
                string dosyaYol = @"Araba.txt";
                FileStream fs = new FileStream(dosyaYol,FileMode.OpenOrCreate,FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                

                Console.WriteLine("Araba Markası Giriniz");
                arb.marka = Convert.ToString(Console.ReadLine());
                sw.WriteLine(arb.marka);
                Console.WriteLine(" Model Girin ");
                arb.model = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Çıkış Yılı Girin");
                arb.cikisYil = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Vites Tipi Giriniz");
                arb.vitesTip = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Yakıt Türü Giriniz");
                arb.yakıtTür = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Depo Kapasitesi Girin");
                arb.depoKap = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Bagaj Kapasitesi Girin");
                arb.bagajKap = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ses Sistemi Girin");
                arb.sesSis = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Koltuk Isıtma Girin");
                arb.koltukIs = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Elektronik Cam Girin");
                arb.elektronikCam = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Klima Girin");
                arb.klima = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Radyo Girin");
                arb.radyo = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Direksiyon Girin");
                arb.direksiyonTip = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Tekerlek Girin");
                arb.tekerlekSay = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Kapı Girin");
                arb.kapıSay = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Koltuk Girin");
                arb.koltukSay = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Hız Girin");
                arb.hiz = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Max Hız Girin");
                arb.maxHız = Convert.ToDouble(Console.ReadLine());
                sw.Flush();
                sw.Close();

            }

        }
    }
}
