public void enter()

{

	int day, month, year;

	bool enter;

	do

	{

		try

		{

			Console.WriteLine("������� ����:");

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

			Console.WriteLine("������ �����. ��������� ����");

			enter = true;

		}

	} while (enter);

	do

	{

		try

		{

			Console.WriteLine("������� �����:");

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

			Console.WriteLine("������ �����. ��������� ����");

			enter = true;

		}

	} while (enter);

	do

	{

		try

		{

			Console.WriteLine("������� ���:");

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

			Console.WriteLine("������ �����. ��������� ����");

			enter = true;

		}

	} while (enter);

	Console.ReadLine();

}
