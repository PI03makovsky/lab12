using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace шарпик8
{
    interface Sale
{
    void Sale(out int discount);
}
public class t : Sale
{
    private static int count; //Статическое поле
    private int id;
    private int sum;
    private string address;
    private int hours;
    private int minutes;
    private Passenger passenger = new Passenger();


    public int Sum
    {
        get { return sum; }

        set
        {
            if (value < 0)
                Console.WriteLine("Сумма не может быть отрицательной");
            else
                sum = value;
        }
    }

    public string Destination
    {
        get { return address; }

        set
        {
                address = value;
        }
    }

    public int Hours
    {
        get { return hours; }

        set
        {
            if (value < 0 || value > 24)
                Console.WriteLine("Часы должны быть в диапазоне от 0 до 24");
            else
                hours = value;
        }
    }

    public int Minutes
    {
        get { return minutes; }

        set
        {
            if (value < 0 || value > 60)
                Console.WriteLine("Минуты должны быть в диапазоне от 0 до 60");
            else
                minutes = value;
        }
    }

    public static void ChangeDestination(t ticket, string address) //Статический метод
    {
        ticket.address = address;
    }

    public void Output()
    {
        if (sum <= 0 || String.IsNullOrEmpty(address) || hours < 0 || minutes < 0)
        {
            Console.WriteLine("Ошибка инициализации данных о билете! Были переданы неверные значения!");
        }
        else
        {
            Console.WriteLine("\nИнформация о билете:");
            Console.WriteLine($"\nId: {id}");
            Console.WriteLine($"\nЦена: {sum}");
            Console.WriteLine($"\nПункт назначения: {address}");
            Console.WriteLine($"\nВремя отправления: {hours}:{minutes}");
            Console.WriteLine("\nИнформация о пассажире:");
            passenger.ToString();
        }
    }

    public t() { } //Конструктор без параметров

    public t(int value) //Конструктор с одним параметром
    {
        sum = value;
    }

    t(int sum, string address, int hours, int minutes, Passenger passenger) //Конструктор с параметрами
    {
        if (sum > 0)
        {
            Sum = sum;
        }
        if (!String.IsNullOrEmpty(address))
        {
            Destination = address;
        }
        if (hours >= 0)
        {
            Hours = hours;
        }

        if (minutes >= 0)
        {
            Minutes = minutes;
        }
        this.passenger = passenger;
        count++;
        id = count;
    }

    public void Input()
    {
        int sum, hours, minutes;
        string address;
        Passenger passenger = new Passenger();
        do
        {
            Console.WriteLine("Введите цену билета:");
            while (!int.TryParse(Console.ReadLine(), out sum))
            {
                Console.WriteLine("Ошибка ввода! Введите целое число!");
            }
        } while (sum <= 0);
        Sum = sum;
        do
        {
            Console.WriteLine("\nВведите пункт назначения: ");
                address = Console.ReadLine();
            if (String.IsNullOrEmpty(address) || String.IsNullOrWhiteSpace(address))
            {
                Console.WriteLine("\nВы ничего не ввели! Повторите ввод: ");
            }
        } while (String.IsNullOrEmpty(address) || String.IsNullOrWhiteSpace(address));
            address = address;
        do
        {
            Console.WriteLine("Введите часы:");
            while (!int.TryParse(Console.ReadLine(), out hours))
            {
                Console.WriteLine("Ошибка ввода! Введите целое число!");
            }
        } while (hours < 0);
        Hours = hours;
        do
        {
            Console.WriteLine("Введите минуты:");
            while (!int.TryParse(Console.ReadLine(), out minutes))
            {
                Console.WriteLine("Ошибка ввода! Введите целое число!");
            }
        } while (minutes < 0);
        Minutes = minutes;
        Console.WriteLine("\nВведите информацию о зрителе:");
        passenger.Input();
        this.passenger = passenger;
        count++;
        id = count;
    }

    void Sale.Sale(out int discount)
    {
        discount = 30;
        int sl1 = discount;
        discount = sum - (sum * sl1 / 100);
        Console.WriteLine($"\n\nЦена с учетом скидки {sl1} процент(ов): {discount}");
        Console.ReadLine();
    }
}
}