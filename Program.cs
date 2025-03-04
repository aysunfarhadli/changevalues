using System;

class Program
{
    static void Main()
    {
        Console.Write("Birinci ədədi daxil edin (a): ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("İkinci ədədi daxil edin (b): ");
        int b = Convert.ToInt32(Console.ReadLine());

        // Dəyişənlərin yerini dəyişirik
        int temp = a;
        a = b;
        b = temp;

        Console.WriteLine("Dəyişdirildikdən sonra:");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
    }
}