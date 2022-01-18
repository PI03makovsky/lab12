using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace шарпик8 {

static void Main(string[] args)

{
    date[,] date2 = new date[3, 2];

    date[] date1 = new date[2];

    for (int i = 0; i < 1; i++)

    {

        date1[i] = new date(12, 11, 2021);

        date1[i].print();

    }

    for (int i = 0; i < 3; i++)

    {

        for (int j = 0; j < 2; j++)

        {

            date2[i, j] = new date(12 + i, 11, 2021);

            date2[i, j].print();

            Console.Write(" ");

        }

    }
}

}



