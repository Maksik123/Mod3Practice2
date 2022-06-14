using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3Practice2.Services
{
    public class Starter
    {
        public delegate int SumFunc(int a, int b);
        public event SumFunc SumHandlerEvent;

        public void Start()
        {
            SumService sumService = new();
            try
            {
                SumHandlerEvent += sumService.Sum;
                SumHandlerEvent += sumService.Sum;
                int result = SumHandlerEvent.Invoke(4, 5);
                var result2 = SumHandlerEvent.Invoke(4, 5);
                var sumEvenetsResult = result + result2;
                Console.WriteLine(sumEvenetsResult);
            }
            catch
            {
                throw new Exception ("Wrong");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Linq");

            Console.WriteLine("----------------");
            TestingLinqService testingLinq = new();
            testingLinq.TestLINQ();

        }
    }
}
