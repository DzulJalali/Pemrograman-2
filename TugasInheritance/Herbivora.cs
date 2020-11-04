using System;

namespace TugasInheritance
{
    public class Herbivora : Binatang
    {
        // PROPERTY
        string nama = "Kambing";
        string nama2 = "Sapi";
        string jenisMakanan2 = "Tumbuhan";
        string pemburu = "Macan";


        public void jenisMakanan()
        {
            Console.WriteLine(nama2 + " makan " + jenisMakanan2);
        }

        public string diburu()
        {
            return nama + " dikejar " + pemburu;
        
            
        }
    }
}