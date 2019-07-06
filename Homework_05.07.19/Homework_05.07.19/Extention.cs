using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework_05._07._19
{
    public static class Extention
    {

        public static void SimpleNum(this int number)
        {
            int count = 0;
            for (int i = 1; i <= number; i++)
            {

                if (number % i == 0)
                {
                    count++;
                }

            }


            if (count > 2)
            {
                Console.WriteLine("Sade eded deyil");
            }
            else
            {
                Console.WriteLine("Sade ededdir");
            }



        }

        public static int MyLastIndexOf(this string word, char letter)
        {
            int index = 1;
            for (int i = word.Length - 1; i >= 0; i--)
            {

                if (word[i] == letter)
                {
                    return index = i + 1;

                }





            }

            return index;

        }


    }
}
