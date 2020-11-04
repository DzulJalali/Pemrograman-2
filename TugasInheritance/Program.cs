using System;

namespace TugasInheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Kehidupan Binatang :");
            
            //angka = angka < angka;
            

            Karnivora singa = new Karnivora();
            Karnivora macan = new Karnivora();
            Herbivora sapi = new Herbivora();
            Herbivora Kambing = new Herbivora();
            singa.makan();
            singa.bernafas();
            macan.berburu();
            sapi.jenisMakanan();
            Console.WriteLine(Kambing.diburu());
            
           
        }
    }
}
