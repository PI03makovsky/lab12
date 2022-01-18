using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace шарпик8

{

    class player

    {

        private String position; //позиция

        private int weigh; // вес

        private int height; // рост

        private date plrD; // связка с классом дата

        public string Position
        {
            get => position;
            set => position = value;
        }

        public int Weigh
        {
            get => weigh;
            set => height = value;
        }

        public int Height
        {
            get => height;
            set => height = value;
        }

        public date PlrD
        {
            get => plrD;
            set
            {
                plrD = value;
            }
        }

        public void init(String p, int w, int h, date D2)

        { //Метод создания

            position = p;

            weigh = w;

            height = h;

            date plrD = D2;

        }

        public void enter()

        { //Метод ввода

            Console.Write("\nВведите позицию: ");

            position = Console.ReadLine();

            Console.Write("\nВведите вес: ");

            weigh = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nВведите рост: ");

            height = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите минимальную дату рожденияЖ");
        }

        public int print()

        { //Метод вывода

            Console.WriteLine($"\nПозиция: {this.Position} Вес: {this.Weigh} Рост: {this.Height} ");

            Console.WriteLine($"\nДень рождения {plrD} ");

            return 0;

        }

        public void printForMass()
        {
            //Метод вывода для массива

            Console.WriteLine($"\nПозиция: {this.Position} Вес: {this.Weigh} Рост: {this.Height} ");

            Console.WriteLine($"\nДень рождения {plrD.Day}.{plrD.Month}.{plrD.Day} ");
        }

    }

}
