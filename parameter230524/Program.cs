using parameter230524;
using System;
using System.ComponentModel.DataAnnotations;

class myclass
{
    public int index;
    int[] Arr = { 9, 3, 7, 3, 10 };

    public int maxvaluefinder(out int max, out int index)
    {
        max = 0;
        index = 0;
        for (int i = 0; i < Arr.Length; i++)
        {
            if (Arr[i] > max)
            {
                max = Arr[i];
                index = i;
            }
        }
        return max;
    }
}


internal class program
{
    private static void Main(string[] args)
    {
        divide_function obj = new divide_function();
        //obj.maxvaluefinder(out int Max, out int index);
        //Console.WriteLine("maximum number is : " + Max + "on index is :" + index);

        //int a, b, rem, que;
        //Console.WriteLine("\nenter the numbers :");
        //a = Convert.ToInt32(Console.ReadLine());
        //b = Convert.ToInt32(Console.ReadLine());
        //obj.dividefun(a, b, out rem, out que);
        //Console.WriteLine("rem is :" + rem + "que is :" + que);

        //Triangle obj1= new Triangle();
        //int s1, s2, s3;
        //double area, peri;
        //Console.WriteLine("\nenter the sides of Trinagle");
        //s1 = Convert.ToInt32(Console.ReadLine());
        //s2 = Convert.ToInt32(Console.ReadLine());
        //s3 = Convert.ToInt32(Console.ReadLine());

        //obj1.triareacalculator(s1, s2, s3, out area, out peri);
        //Console.WriteLine("Area of triangle is :" + area + "perimiter of triangle :" + peri);

        Factorial obj2 = new Factorial();
        int num, fact;
        Console.WriteLine("\nenter the number :");
        num = Convert.ToInt32(Console.ReadLine());
        obj2.calculatefactrorial(num, out fact);
        Console.WriteLine("the factorial of {0} is {1} ", num, fact);
    }
} 