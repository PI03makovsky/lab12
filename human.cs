using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace шарпик8
{
        abstract class Human
        {
            private string name;
            private string lastname;
            private date birthdate { get; set; }

            public string Name { get; set; }

            public string Lastname { get; set; }

            public Human()
            {  //Конструктор без параметров
            }

            public override string ToString()
            {
                return Name + " " + Lastname + " " + birthdate;
            }

            public Human(string value) //Конструктор с одним параметром
            {
                name = value;
            }

            public Human(string name, string lastname, date birthdate) //Конструктор с параметрами
            {
                if (String.IsNullOrEmpty(name))
                {
                    Name = "-";
                }
                else
                {
                    Name = name;
                }
                if (String.IsNullOrEmpty(lastname))
                {
                    Lastname = "-";
                }
                else
                {
                    Lastname = lastname;
                }
                this.birthdate = birthdate;
            }


            public void Input()
            {
                string name;
                string lastname;
                date birthdate = new date();

                do
                {
                    Console.WriteLine("\nВведите имя: ");
                    name = Console.ReadLine();
                    if (String.IsNullOrEmpty(name) || String.IsNullOrWhiteSpace(name))
                    {
                        Console.WriteLine("\nВы ничего не ввели! Повторите ввод: ");
                    }
                } while (String.IsNullOrEmpty(name) || String.IsNullOrWhiteSpace(name));
                Name = name;
                do
                {
                    Console.WriteLine("\nВведите фамилию: ");
                    lastname = Console.ReadLine();
                    if (String.IsNullOrEmpty(lastname) || String.IsNullOrWhiteSpace(name))
                    {
                        Console.WriteLine("\nВы ничего не ввели! Повторите ввод! ");
                    }
                } while (String.IsNullOrEmpty(lastname) || String.IsNullOrWhiteSpace(lastname));
                Lastname = lastname;
                Console.WriteLine("\nВведите дату рождения: ");
                birthdate.Input();
                this.birthdate = birthdate;
            }
        }

        class tenant1 : Human
        {
            private player tH;

            public void Inputdriver()
            {
                Console.WriteLine("\nВведите информацию о водителе:");
                Input();
                Console.WriteLine("\nВведите информацию об автобусе: ");
                tH.enter();
            }

            public void Outputdriver()
            {
                Console.WriteLine("\nИнформация о водителе:");
                ToString();
                Console.WriteLine("\nИнформация об автобусе: ");
               tH.print();
            }

            public tenant1(string name, string lastname, date birthdate, player tH) : base(name, lastname, birthdate)
            {
                this.tH = tH;
            }

        }

        class Passenger : Human
        {

        }
    }


