Program.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace шарпик8

{

    class Program

    {

        static void Main(string[] args)

        {
            Console.Write("Количество администраторов сейчас: ");
            Console.WriteLine(tenant.CheckRetirementStatus()); // "метка" для подсчёта количества администраторов на рабочем месте

            Players();
            functionOut();
            functionRef();

            // Твой массив
            void Players()
            {
                int size;
                Console.WriteLine("  Сколько игроков вы хотите создать: ");
                while (!int.TryParse(Console.ReadLine(), out size)) { Console.WriteLine("Ошибка. Введите число: "); }
                player[] list = new player[size];
                for (int i = 0; i < size; i++)
                {
                    date playerDate = new date();
                    list[i] = new player();
                    list[i].enter();
                    playerDate.enterD();
                    list[i].PlrD = playerDate;
                }
                Console.WriteLine("  Введённые вами данные: ");
                for (int i = 0; i < size; i++)
                {
                    list[i].printForMass();
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            // Out Ref

            void functionOut()
            {
                tenant TenantOut = new tenant();
                date Date = new date();
                TenantOut.enterT(); // ввод фио
                Date.enterD(); // ввод даты

                String name;
                String surname;
                String patronymic;

                TenantOut.OutData(out name, out surname, out patronymic);

                Console.Write("\n  Имя: {0}, Фамилия {1}, Отчество {2}\n", name, surname, patronymic);
            }

            void functionRef()
            {
                tenant TenantOut = new tenant();
                date Date = new date();

                TenantOut.enterT(); // ввод фио
                Date.enterD(); // ввод даты

                String name = "";
                String surname = "";
                String patronymic = "";

                TenantOut.RefData(ref name, ref surname, ref patronymic);

                Console.Write("\n  Имя: {0}, Фамилия {1}, Отчество {2}\n", name, surname, patronymic);
            }
        }

    }

}
