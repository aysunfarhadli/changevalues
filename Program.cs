using System;

class Program
{
    static void Main()
    {
        Console.Write("Birinci ədədi daxil edin");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("İkinci ədədi daxil edin");
        int b = Convert.ToInt32(Console.ReadLine());

        int temp = a;
        a = b;
        b = temp;
        
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
    }
}
