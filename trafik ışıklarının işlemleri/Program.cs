using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trafik_ışıklarının_işlemleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //trafik_ışıklarının_işlemleri
            Console.WriteLine("trafik ışıklarının işlemleri");
            Console.WriteLine("renk giriniz");      
             string renk = Console.ReadLine();
            switch (renk)
            {
                case "kırmızı":
                    Console.WriteLine("dur");
                    break;

                case "sarı":
                    Console.WriteLine("hazırlan");
                    break;
                    
                case "yeşil":
                    Console.WriteLine("geçebilirsiniz");
                    break;  

                default:
                    Console.WriteLine("geçersiz renk girişi");
                    break;
            }
            Console.ReadKey();  
              
            





        }
    }
}
