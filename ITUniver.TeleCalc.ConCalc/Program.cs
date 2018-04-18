using ITUniver.TeleCalc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ITUniver.TeleCalc.ConCalc
{
    class Program
    {
       // static void Main(string[] args)
        static void Main(string[] args)
        {
            Console.WriteLine("Пожалуйста, выберите операцию");
            Calc calc = new Calc();
            string operName=Console.ReadLine();
            Console.WriteLine("Пожалуйста, введите первое число");

            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Пожалуйста, введите второе число");
            double y = Convert.ToDouble(Console.ReadLine());
            
#region bla
            /*  if (args.Length != 3)
              {

                  Console.WriteLine("Пожалуйста, введите операцию и два числа");
                  Console.ReadLine();
                  return;
              }*/
            //   string operName = args[0];

            //   double x = Double.Parse(args[1]);
            //double y = Double.Parse(args[2]);
            // var calc = new Calc();
#endregion
            double? result = calc.Exec(operName, x, y);
            Console.WriteLine(string.Format("{0}{1}{2} = {3}", x, operName, y, result));
            Console.ReadKey();
           
        }
    }
}
