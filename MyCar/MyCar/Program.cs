using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace MyCar
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Создаем массив объектов класса "Car"
            Car[] cars = new Car[5];

            // Инициализируем объекты и добавляем их в массив
            cars[0] = new Car("Toyota", "Camry", 2017, 16000000, true);
            cars[1] = new Car("Kia", "Rio", 2021, 9000000, false);
            cars[2] = new Car("Hyundai", "Elantra", 2022, 18000000, true);
            cars[3] = new Car("Chevrolet", "Malibu", 2020, 27000000, true);
            cars[4] = new Car("Nissan", "Altima", 2021, 8000000, false);

            // Вывод информации о машинах
            foreach (Car car in cars)
            {
                car.DisplayCarInfo();
                car.Drive();
                Console.WriteLine();

            }
        }
    }
}
