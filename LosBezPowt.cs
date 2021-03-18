using System;
using System.Collections.Generic;

namespace LosowanieBezPowtorzen
{
    class Program
    {
        static bool NumberIsExist(int val, List<int> list) {
            int ileLiczb = 0;
            for (int i = 0; i < list.Count; ++i) {
                if (val == list[i]) ileLiczb++;
            }
            return ileLiczb > 0 ? true : false;
        }
        static void Main(string[] args) {
            List<int> numbers = new List<int>{ 0, 0, 0, 0, 0, 0 };
            //Console.Write(numbers.Count);
            for(int i=0; i < numbers.Count; ++i) {
                Random random = new Random();
                int los = random.Next(49) + 1;
                do {
                    los = random.Next(49) + 1;
                } while (NumberIsExist(los, numbers));
                numbers[i] = los;
            }
            for (int i = 0; i < numbers.Count; ++i) {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
