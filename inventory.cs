using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace шарпик8

{
        public class inventory : System.ICloneable

    {

            private int nballs; // количество мячей

            private int ngates; // количество ворот

            private date createdate { get; set; }

            public int Nballs
            {
                get => nballs;
                set => nballs = value;
            }
            public int Ngates
            {
                get => ngates;
                set => ngates = value;
            }

        public void Output()
        {
            if (nballs <= 0 || ngates <= 0)
            {
                Console.WriteLine("Ошибка инициализации!");
            }
            else
            {
                Console.WriteLine("\nИнформация :");
                Console.WriteLine($"\nМячи {nballs}");
                Console.WriteLine($"\nВорота: {ngates} л.с.");
                Console.WriteLine("\nДата:");
                createdate.Output();
            }
        }
        public inventory() { } //Конструктор без параметров

        public inventory(int value) //Конструктор с одним параметром 
        {
            nballs = value;
        }
        public inventory(int nballs, int ngates, date createdate) //Конструктор с параметрами
        {
            if (nballs > 0)
            {
                Nballs = nballs;
            }
            if (ngates > 0)
            {
                Ngates = ngates;
            }
            this.createdate = createdate;
        }

        public object Clone()  //Глубокое копирование
        {
            date date = new date { Day = createdate.Day, Month = createdate.Month, Year = createdate.Year };
            return new inventory
            {
                Nballs = Nballs,
                Ngates = Ngates,
                createdate = date
            };

        }

        public void Input()
        {
            int number, power;
            date createdate = new date();
            do
            {
                Console.WriteLine("Введите серийный номер:");
                while (!int.TryParse(Console.ReadLine(), out nballs))
                {
                    Console.WriteLine("Ошибка ввода! Введите целое число!");
                }
            } while (nballs <= 0);
            Nballs = nballs;
            do
            {
                Console.WriteLine("Введите мощность(в л.с.):");
                while (!int.TryParse(Console.ReadLine(), out power))
                {
                    Console.WriteLine("Ошибка ввода! Введите целое число!");
                }
            } while (ngates <= 0);
            Ngates = ngates;
            Console.WriteLine("\nВведите дату производства: ");
            createdate.Input();
            this.createdate = createdate;
        }

        public void Tokvt()
        {
            double ls = 1000, res = 0;
            res = ngates * ls;
            Console.WriteLine($"\nМощность двигалеля в кВт: ", res);
        }
    }
}
