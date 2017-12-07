using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerCS.Classes
{
    public class Euler001
    {
        //Problem 1
        //If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
        //Find the sum of all the multiples of 3 or 5 below 1000.
        public static int Problem1()
        {
            int soma = 0;
            for(int contador = 1; contador < 1000; contador++)
            {
                if ((contador % 3) == 0 || (contador % 5) == 0)
                {
                    soma += contador;
                }

            }

            return soma;
        }
    }
}
