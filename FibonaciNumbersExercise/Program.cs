using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonaciNumbersExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> fiboList = new List<int>();
            FibonaciRecursive(10, fiboList);
            Console.ReadLine();
        }
        static void FibonaciRecursive(int num, List<int> fiboList)
        {
            if (fiboList.Count > 40 || fiboList.Count == num)
                return;                        
            else if (fiboList.Count == 0)
                fiboList.Add(0);
            else if (fiboList.Count == 1)
                fiboList.Add(1);
            else if (fiboList.Count < num)
                fiboList.Add(fiboList[fiboList.Count - 1] + fiboList[fiboList.Count - 2]);
            FibonaciRecursive(num, fiboList);
        }
    }
}
