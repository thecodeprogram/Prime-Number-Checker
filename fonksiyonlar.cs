using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asalci
{
    class fonksiyonlar
    {
        //this function check the number is prime or not
        public bool isPrime(int sayi)
        {
            for (int i = 2; i < sayi; i++)
            {
                return sayi % i == 0 ? true : false;
            }
            return true;
        }
    }
}
