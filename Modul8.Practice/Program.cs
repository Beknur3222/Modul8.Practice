using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul8.Practice
{
    public class RangeOfArray
    {
        int[] array=null;
        public RangeOfArray()
        {
            array = new int[10];
            Random random = new Random();
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 20);
            }
        }

        public int this[int index]
        {
            get
            {
                if (index > 0 && index<=array.Length)
                {
                    return array[index - 1];
                }         
                else 
                {
                    throw new Exception(); 
                }
                
            }
          
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < array.Length; i++)
            {
                result += array[i] + " ";
            }

            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Supermaket supermarket = new Supermaket();
            Console.WriteLine("Сумм всех продуктов: {0}",
                supermarket[1]);

            List<double> x = new List<double> { 1, 2, 3, 4, 5 };
            List<double> y = new List<double> { 10, 20, 30, 40, 50 };

            double slope, intercept;
            LinearRegression.CalculateLinearRegression(x, y, out slope, out intercept);

            double nextMonth = slope * 6 + intercept;
            double monthAfterNext = slope * 7 + intercept;
            double thirdMonth = slope * 8 + intercept;

            Console.WriteLine($"Прогноз на следующие три месяца:");
            Console.WriteLine($"Следующий месяц: {nextMonth}");
            Console.WriteLine($"Месяц после следующего: {monthAfterNext}");
            Console.WriteLine($"Третий месяц: {thirdMonth}");

            Console.ReadKey();
        }
    }
}
