using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCar
{
    public partial class Car
    {
        private string make;        // Марка автомобиля
        private string model;       // Модель автомобиля
        private int year;           // Год выпуска
        private double price;       // Цена автомобиля
        private bool isAvailable;   // Доступность (в наличии или нет)

        // Статическое поле для отслеживания общего количества машин
        private static int totalCars = 0;

        // Статическое поле для отслеживания суммарной цены машин
        private static double totalPrices = 0;


        // Конструктор по умолчанию
        public Car()
        {
            make = "Unknown";
            model = "Unknown";
            year = DateTime.Now.Year;
            price = 0;
            isAvailable = false;
        }

        // Конструктор класса
        public Car(string make, string model, int year, double price, bool isAvailable)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;
            this.isAvailable = isAvailable;

            // Увеличиваем общее количество машин и суммарную цену при создании нового объекта
            totalCars++;
            totalPrices += price;
        }


        public static double AveragePrice
        {
            get
            {
                if (totalCars == 0)
                    return 0;
                return totalPrices / totalCars;
            }
        }

        // Статическое свойство для получения общего количества машин
        public static int TotalCars
        {
            get { return totalCars; }
        }


        // Перегруженный конструктор без года выпуска
        public Car(string make, string model, double price, bool isAvailable)
            : this(make, model, DateTime.Now.Year, price, isAvailable)
        {
        }

        // Перегруженный конструктор без доступности
        public Car(string make, string model, int year, double price)
            : this(make, model, year, price, true)
        {
        }




        // Методы для доступа к полям (геттеры)
        public string Make
        {
            get
            {
                return make;
            }
            set
            {
                this.make = value;
            }
        }

        public string Model
        {
            get
            {
                return model;

            }
            set
            {
                this.model = value;
            }
        }

        public int Year
        {
            get
            {
                return year;

            }
        }

        public double Price
        {
            get
            {
                return price;

            }

        }


        public void DisplayCarInfo()
        {
            Console.WriteLine($"Марка: {make}");
            Console.WriteLine($"Модель: {model}");
            Console.WriteLine($"Год выпуска: {year}");
            Console.WriteLine($"Цена: {price}");
        }

        // Метод для обновления информации о машине с передачей аргументов по ссылке
        public void UpdateCarInfo(ref string newMake, ref string newModel, ref int newYear, ref double newPrice, ref bool newIsAvailable)
        {
            make = newMake;
            model = newModel;
            year = newYear;
            price = newPrice;
            isAvailable = newIsAvailable;
        }

    }
}
