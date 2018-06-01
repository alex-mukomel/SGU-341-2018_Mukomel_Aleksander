/*Создать иерархию классов для транспортной компании. 
В компании есть ТС разных видов: наземные, водные и воздушные. 
У каждого ТС есть такие характеристики как:
скорость, грузоподъёмность, марка, количество персонала и количество пассажиров. 

Каждое ТС умеет доставлять грузы и предоставлять полную информацию о себе. 
ТС каждого типа в свою очередь подразделяется на более мелкие категории:
-наземные (поезда, автомобили и т.д.), 
-водные (лайнеры, танкеры и т.д.), 
-воздушные (самолёты, вертолёты и т.д.)

Программа представляет из себя консольное приложение, 
которое умеет создавать ТС с заданной грузоподъёмностью и скоростью.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите скорость ТС: ");
            double speed = Double.Parse(Console.ReadLine());
            Console.Write("Введите грузоподъемность ТС: ");
            double carrying = Double.Parse(Console.ReadLine());
            Console.Write("Введите модель ТС: ");
            string mark = Console.ReadLine();
            Console.Write("Введите количество персонала ТС: ");
            int numberOfStaff = Int32.Parse(Console.ReadLine());
            Console.Write("Введите количество пассажиров ТС: ");
            int numberOfPassengers = Int32.Parse(Console.ReadLine());

            Transport transport;
            Console.WriteLine("Выберете из списка тип создаваемого ТС.");
            Console.WriteLine("1. Наземный. \n2. Водный. \n3. Воздушный.");
            ConsoleKeyInfo type = Console.ReadKey();
            ConsoleKeyInfo subtype;
            switch (type.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("\n1. Поезд. \n2. Автомобиль.");
                    subtype = Console.ReadKey();
                    switch (subtype.Key)
                    {
                        case ConsoleKey.D1:
                            transport = new Train(speed, carrying, mark, numberOfStaff, numberOfPassengers);
                            break;
                        case ConsoleKey.D2:
                            transport = new Car(speed, carrying, mark, numberOfStaff, numberOfPassengers);
                            break;
                        default:
                            Console.WriteLine("\nНекорректный ввод");
                            transport = null;
                            break;
                    }
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("\n1. Лайнер. \n2. Танкер.");
                    subtype = Console.ReadKey();
                    switch (subtype.Key)
                    {
                        case ConsoleKey.D1:
                            transport = new Liner(speed, carrying, mark, numberOfStaff, numberOfPassengers);
                            break;
                        case ConsoleKey.D2:
                            transport = new Tanker(speed, carrying, mark, numberOfStaff, numberOfPassengers);
                            break;
                        default:
                            Console.WriteLine("\nНекорректный ввод");
                            transport = null;
                            break;
                    }
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("\n1. Самолет. \n2. Вертолет.");
                    subtype = Console.ReadKey();
                    switch (subtype.Key)
                    {
                        case ConsoleKey.D1:
                            transport = new Aircraft(speed, carrying, mark, numberOfStaff, numberOfPassengers);
                            break;
                        case ConsoleKey.D2:
                            transport = new Helicopter(speed, carrying, mark, numberOfStaff, numberOfPassengers);
                            break;
                        default:
                            Console.WriteLine("\nНекорректный ввод");
                            transport = null;
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("\nНекорректный ввод");
                    transport = null;
                    break;
            }
            Console.WriteLine();

            if (transport == null)
            {
                Console.WriteLine("Создание не было выполнено.");
            }
            else
            {
                Console.WriteLine(transport.GiveInfo);
                Console.WriteLine(transport.Delivery());
            }
        }
    }
}
