using System;

public class Class1
{
    public static double AddNumber1(int no1, float no2, double no3)
    {
        return no1 + no2 + no3;
    }

    public static void AddNumber2(int no1, float no2, double no3)
    {
        Console.WriteLine("The sum of the numbers is: " + (no1 + no2 + no3));
    }

    public static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    public delegate double AddDelegate1(int no1, float no2, double no3);
    public delegate void AddDelegate2(int no1, float no2, double no3);
    public delegate bool IsEvenDelegate(int number);


    public static void Main(string[] args)
    {
        /*
        AddDelegate1 add1 = new AddDelegate1(AddNumber1);
        double result1 = add1(5, 3.2f, 4.5);
        Console.WriteLine("Result of AddNumber1: " + result1);

        AddDelegate2 add2 = new AddDelegate2(AddNumber2);
        add2.Invoke(5, 3.2f, 4.5);

        IsEvenDelegate isEven = new IsEvenDelegate(IsEven);
        bool checkEven = isEven(7);
        Console.WriteLine("Is 7 even? " + checkEven);
        */

        Func<int, float, double, double> addFunc = new Func<int, float, double, double>(AddNumber1);
        double result = addFunc(5, 3.2f, 4.5);
        Console.WriteLine("Result of AddNumber1: " + result);

        Action<int, float, double> addAction = new Action<int, float, double>(AddNumber2);
        addAction.Invoke(5, 3.2f, 4.5);

        Predicate<int> isEvenPredicate = new Predicate<int>(IsEven);
        bool checkEven = isEvenPredicate(7);
        Console.WriteLine("Is 7 even? " + checkEven);
    }

}
