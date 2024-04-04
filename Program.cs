using System;
using task_3_4;
class Program
{
 static void Main()
    {
        Odnomerniy<int> intArray = new();
        intArray.PrintMass();
        Odnomerniy<double> doubleArray = new();
        doubleArray.PrintMass();
        intArray.AddEl(5);
        intArray.AddEl(25);
        intArray.AddEl(453);
        intArray.AddEl(4354);
        intArray.AddEl(75373);
        intArray.AddEl(15);
        intArray.PrintMass();
        doubleArray.AddEl(874.44);
        doubleArray.AddEl(701.25);
        doubleArray.AddEl(942.5);
        doubleArray.AddEl(0.241);
        doubleArray.AddEl(0.5);
        doubleArray.AddEl(94);
        doubleArray.AddEl(6.4);
        doubleArray.PrintMass();
        intArray.DelEl(2);
        intArray.PrintMass();
        doubleArray.DelEl(6);
        doubleArray.PrintMass();
        intArray.Sort();
        intArray.PrintMass();
        doubleArray.Sort();
        doubleArray.PrintMass();
        Console.WriteLine(intArray.Max());
        Console.WriteLine(intArray.Min());
        Console.WriteLine(doubleArray.Max());
        Console.WriteLine(doubleArray.Min());
    }
}
