using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ������8

{

    class tenant

    {

        String name; //���

        String surname; //�������

        String patronymic; //��������

        static int quantityA = 0; // ����������� ���� ���-�� ��������������� �� �����

        private readonly date tntD; // ������ � ������� ����

        public static int CheckRetirementStatus() // ����������� �����
        {

            quantityA++;
            return quantityA;
        }


        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Surname
        {
            get => surname;
            set => surname = value;
        }
        public string Patronymic
        {
            get => patronymic;
            set => patronymic = value;
        }

        public tenant() { } //����������� ��� ����������

        public tenant(string value) //����������� � ����� ����������

        {

            name = value;

        }


        public tenant(String n, String s, String p, date D1) //����������� �� ����� �����������

        {

            name = n;

            surname = s;

            patronymic = p;

            date tndD = D1;



        }

        public void enterT() //����� �����

        {

            Console.Write("\n������� ���: ");

            name = Console.ReadLine();

            Console.Write("\n������� �������: ");

            surname = Console.ReadLine();

            Console.Write("\n������� ��������: ");

            patronymic = Console.ReadLine();

            Console.Write("\n������� ���� ��������\n");

        }

        public int printer() //����� ������

        {

            Console.WriteLine($"\n���: {this.Name} �������: {this.Surname} ��������: {this.Patronymic} ");

            Console.WriteLine($"\n���� �������� {tntD} ");

            return 0;

        }

        // Out ref
        public void OutData(out string name, out string surname, out string patronymic)
        {
            name = this.name;
            surname = this.surname;
            patronymic = this.patronymic;
        }
        public void RefData(ref string name, ref string surname, ref string patronymic)
        {
            name = this.name;
            surname = this.surname;
            patronymic = this.patronymic;
        }
    }

}
