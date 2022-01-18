public void enter()

{

	int day, month, year;

	bool enter;

	do

	{

		try

		{

			Console.WriteLine("Введите день:");

			day = Convert.ToInt32(Console.ReadLine());

			if (1 < day || day > 31)

			{

				throw new Exception();

			}

			enter = false;

			Day = day;

		}

		catch

		{

			Console.WriteLine("Ошибка ввода. Повторите ввод");

			enter = true;

		}

	} while (enter);

	do

	{

		try

		{

			Console.WriteLine("Введите месяц:");

			month = Convert.ToInt32(Console.ReadLine());

			if (1 < month || month > 12)

			{

				throw new Exception();

			}

			enter = false;

			Month = month;

		}

		catch

		{

			Console.WriteLine("Ошибка ввода. Повторите ввод");

			enter = true;

		}

	} while (enter);

	do

	{

		try

		{

			Console.WriteLine("Введите год:");

			year = Convert.ToInt32(Console.ReadLine());

			if (1 < year || year > 2021)

			{

				throw new Exception();

			}

			enter = false;

			Year = year;

		}

		catch

		{

			Console.WriteLine("Ошибка ввода. Повторите ввод");

			enter = true;

		}

	} while (enter);

	Console.ReadLine();

}
