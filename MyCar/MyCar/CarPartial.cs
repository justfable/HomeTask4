using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyCar
{
    public partial class Car
    {
        public void Drive()
        {
            if (isAvailable)
            {
                Console.WriteLine($"Автомобиль {make} {model} есть в наличии.");
            }
            else
            {
                Console.WriteLine($"Автомобиль {make} {model} нет в наличии.");
            }
        }
    }
}