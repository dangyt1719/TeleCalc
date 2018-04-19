using ITUniver.TeleCalc.Core.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ITUniver.TeleCalc.Core
{
    public class Calc
    {

       private IOperation[] operations { get; set; }

        public Calc()
        {
            var opers = new List<IOperation>();
            
            // получить текущую сборку
            var assembly = Assembly.GetExecutingAssembly();

            // получить все типы в ней
            var classes = assembly.GetTypes();
           
            foreach (var item in classes)
            {
                // получаем интерфейсы, которые реализует класс
                var interfaces = item.GetInterfaces();

                // если хотя бы один из интерфейсов имеет заданное имя
                
                var isOperation = interfaces.Any(i => i == typeof(IOperation));
                
                if (isOperation)
                {
                    Console.WriteLine($"Operatrion {item.Name}");
                    var obj = Activator.CreateInstance(item) as IOperation;
                    if (obj != null)
                    {
                        
                        opers.Add(obj);
                    }
                }
            }

            operations = opers.ToArray();
          
        }
        public dynamic  Find()
        {
            
          var opers = new List<IOperation>();

            // получить текущую сборку
            var assembly = Assembly.GetExecutingAssembly();

            // получить все типы в ней
            var classes = assembly.GetTypes();

            foreach (var item in classes)
            {
                // получаем интерфейсы, которые реализует класс
                var interfaces = item.GetInterfaces();

                // если хотя бы один из интерфейсов имеет заданное имя

                var isOperation = interfaces.Any(i => i == typeof(IOperation));

                if (isOperation)
                {
                    Console.WriteLine($"Operatrion {item.Name}");
                    var obj = Activator.CreateInstance(item) as IOperation;
                    if (obj != null)
                    {

                        opers.Add(obj);
                    }
                }
            }

           return operations = opers.ToArray();

        }
        public double Exec(string operName, double? x, double? y)
        {
            IOperation operation = operations
                .FirstOrDefault(o => o.Name == operName);

            if (operation == null)
                return double.NaN;

            operation.Args = new double[] { Convert.ToDouble(x), Convert.ToDouble(y) };
            return (double)operation.Result;
        }

        #region old

        public double Sqr(double x)
        {
            return Math.Pow(x, 2);
        }

        public int Sum(int x, int y)
        {
            return x + y;
        }

        public double Sum(double x, double y)
        {
            return Exec("sum", x, y);
        }

        public double Sub(double x, double y)
        {
            return Exec("sub", x, y);
        }

        public double Div(double x, double y)
        {
            return x / y;
        }

        public double Pow(double x, double y)
        {
            return Math.Pow(x, y);
        }

        public double Sqrt(double x)
        {
            return Math.Sqrt(x);
        }

        #endregion
    }
}
