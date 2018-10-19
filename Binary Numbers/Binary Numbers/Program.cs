using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int k = 0;
            string sayı = "";
            Console.WriteLine("Bir Sayı Giriniz: ");
            k = Convert.ToInt32(Console.ReadLine());

            while (k > 0)
            {
                sayı = (Convert.ToString(k % 2)) + sayı;

                k = k / 2;

            }

            Console.WriteLine(sayı);



        }
    }
}
