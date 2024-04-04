using System;
using task_3_4;
class Program
{
 static void Main()
    {
        Odnomerniy<int> int_mass = new();
        int_mass.PrintMass();
        int_mass.AddEl(1);
        int_mass.AddEl(16);
        int_mass.AddEl(346);
        int_mass.PrintMass();
        int_mass.DelEl(1);
        int_mass.PrintMass();
        int_mass.Sort();
        int_mass.PrintMass();
        Console.WriteLine(int_mass.Max());
        Console.WriteLine(int_mass.Min());

        Odnomerniy<double> double_mass = new();
        double_mass.PrintMass();
        double_mass.AddEl(13.786);
        double_mass.AddEl(701.25);
        double_mass.AddEl(567.7);
        double_mass.AddEl(0.654);
        double_mass.AddEl(17);
        double_mass.PrintMass();
        double_mass.DelEl(3);
        double_mass.PrintMass();
        double_mass.Sort();
        double_mass.PrintMass();
        Console.WriteLine(double_mass.Max());
        Console.WriteLine(double_mass.Min());
    }
}
