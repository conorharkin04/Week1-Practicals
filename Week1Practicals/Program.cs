//TaskOne();
//TaskTwo();
//TaskThree();
//TaskFour();
TaskFive();

void TaskOne()
{
    Console.WriteLine("Please enter your name");
    string name = Console.ReadLine();
    Console.WriteLine("Please enter your age?");
    int age = Convert.ToInt32(Console.ReadLine());
    int result = age + 5;
    Console.WriteLine($"Hello {name}, you will be {result} in 5 years");
    
}

void TaskTwo()
{
    int age;

    Console.WriteLine("Please enter your age?");
    age = Convert.ToInt32(Console.ReadLine());

    if (age > -1 && age < 13)
    {
        Console.WriteLine("You are a child");
    }
    else if (age > 12 && age < 20)
    {
        Console.WriteLine("You are a teenager");
    }
    else if (age > 19 && age < 111)
    {
        Console.WriteLine("You are an adult");
    }
    else
    {
        Console.WriteLine("That age is outside the 0-110 range");
    }
}

void TaskThree()
{
    Console.WriteLine("Please enter an integer");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number < 0)
    {
        Console.WriteLine("This is a negative number");
    }
    else if (number > 1)
    {
        Console.WriteLine("This is a positive number");
    }
    else
    {
        Console.WriteLine("This is the number 0");
    }
}

void TaskFour()
{
    Console.WriteLine("Please enter a year");
    int year = Convert.ToInt32(Console.ReadLine());

    if (year % 4 == 0 && year % 100 != 0)
    {
        Console.WriteLine("This year is a leap year");
    }
    else if (year < 0)
    {
        Console.WriteLine("Please enter a valid year");
    }
    else if (year % 400 == 0)
    {
        Console.WriteLine("This year is a leap year");
    }
    else if (year == 200)
    {
        Console.WriteLine("This year is a leap year");
    }
    else
    {
        Console.WriteLine("This year is not a leap year");
    }
}

void TaskFive()
{
    int number;

    Console.WriteLine("Please enter a Number");

    number = Convert.ToInt32(Console.ReadLine());

    if (number % 2 == 0)
    {
        Console.WriteLine("This is an even number");
    }
    else
    {
        Console.WriteLine("This is an odd number");
    }
}