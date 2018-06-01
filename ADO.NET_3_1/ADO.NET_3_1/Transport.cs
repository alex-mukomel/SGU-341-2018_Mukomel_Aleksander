using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_3_1
{
    public abstract class Transport
    {
        //Нужно использовать исключения для этих данных, проверить скорость на неотрицательность и т.д.

        public double Speed { get; set; }
        public double Carrying { get; set; }
        public string Mark { get; set; }
        public int NumberOfStaff { get; set; }
        public int NumberOfPassengers { get; set; }

        public Transport(double speed, double carrying, string mark, 
            int numberOfStaff, int numberOfPassengers)
        {
            Speed = speed;
            Carrying = carrying;
            Mark = mark;
            NumberOfStaff = numberOfStaff;
            NumberOfPassengers = numberOfPassengers;
        }

        public string GiveInfo
        {
            get
            {
                string massage = "Скорость = {0}; грузоподъёмность = {1}; марка = {2};" +
                    " количество персонала = {3}; количество пассажиров = {4}.";
                return string.Format(massage, Speed.ToString(), Carrying.ToString(),
                    Mark, NumberOfStaff.ToString(), NumberOfPassengers.ToString());
            }
        }



        public abstract string Delivery();
    }
}
