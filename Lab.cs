using System;
using System.Collections.Generic;

namespace a
{
    public class Lab
    {
        /**
         * Функция определения количества четных цифр в натуральном числе
         * 
         */
        public static int GetEvenCount(uint number)
        {
            string n = Convert.ToString(number);
            int sum = 0; //сумма

            for (int i = 0; i < n.Length; i++)
            {

                if (n[i] % 2 == 0)
                {
                    sum += 1;
                }
            }
            return sum;
        }
        /**
         ' jpsdogijshadpfoguhzosidfgh
         
         */
        public static int GetDigitCount(uint number, char digit)
        {
            string n = Convert.ToString(number);
            int result = 0;
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] == digit)
                {
                    result += 1;
                }
            }
            return result;
        }

        public static List<int> GetSumEqNumbers() 
        {
            int max = 9999;
            int q = 6 * 27;
            List<int> list = new List<int>();
            for (int i = 1000; i <= max; i++)
            {
                if (i % q == 0)
                {
                    string g = Convert.ToString(i);
                    if (g[0] + g[3] == g[1] + g[2])
                    {
                        list.Add(i);

                    }
                }

            }
            return list;
        }
    }
}

