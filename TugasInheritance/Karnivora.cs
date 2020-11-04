using System;

namespace TugasInheritance
{
    public class Karnivora : Binatang
    {
        //PROPERTY
        string nama = "Singa";
        string nama2 = "Macan";
        string korban = "Kambing";
        string jenisMakanan = "Daging";
       

        
        public void makan()
        {
            Console.WriteLine(nama + " makan " +jenisMakanan);
        }

        public void berburu()
        {
            Console.WriteLine(nama2 + " memburu " + korban);
        }
    }
}