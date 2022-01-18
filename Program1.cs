Program.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ������8

{

    class Program

    {

        static void Main(string[] args)

        {
            Console.Write("���������� ��������������� ������: ");
            Console.WriteLine(tenant.CheckRetirementStatus()); // "�����" ��� �������� ���������� ��������������� �� ������� �����

            Players();
            functionOut();
            functionRef();

            // ���� ������
            void Players()
            {
                int size;
                Console.WriteLine("  ������� ������� �� ������ �������: ");
                while (!int.TryParse(Console.ReadLine(), out size)) { Console.WriteLine("������. ������� �����: "); }
                player[] list = new player[size];
                for (int i = 0; i < size; i++)
                {
                    date playerDate = new date();
                    list[i] = new player();
                    list[i].enter();
                    playerDate.enterD();
                    list[i].PlrD = playerDate;
                }
                Console.WriteLine("  �������� ���� ������: ");
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
                TenantOut.enterT(); // ���� ���
                Date.enterD(); // ���� ����

                String name;
                String surname;
                String patronymic;

                TenantOut.OutData(out name, out surname, out patronymic);

                Console.Write("\n  ���: {0}, ������� {1}, �������� {2}\n", name, surname, patronymic);
            }

            void functionRef()
            {
                tenant TenantOut = new tenant();
                date Date = new date();

                TenantOut.enterT(); // ���� ���
                Date.enterD(); // ���� ����

                String name = "";
                String surname = "";
                String patronymic = "";

                TenantOut.RefData(ref name, ref surname, ref patronymic);

                Console.Write("\n  ���: {0}, ������� {1}, �������� {2}\n", name, surname, patronymic);
            }
        }

    }

}
