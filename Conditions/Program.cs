using System;

namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //1.User gives 2 numbers a and b. If a>b then output a+b, if a=b then output a*b, if a<b then a-b.

            //Console.Write("Enter number a: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter number b: ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //if (a > b)
            //{
            //    Console.WriteLine($"a + b = {a+b}");
            //}
            //else if (a == b)
            //{
            //    Console.WriteLine($"a * b = {a * b}");
            //}
            //else
            //{
            //    Console.WriteLine($"a - b = {a-b}");

            //}
            #endregion

            #region Task 2
            //2.User gives 2 numbers x and y. Find out coordinate quarter of point with location(x, y).
            //Console.Write("Enter number x: ");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter number y: ");
            //int y = Convert.ToInt32(Console.ReadLine());
            //if(x > 0 && y > 0)
            //{
            //    Console.WriteLine("Point is in 1st quadrant (top right)");
            //}
            //else if (x < 0 && y > 0)
            //{
            //    Console.WriteLine("Point is in 2nd quadrant (top left)");
            //}
            //else if (x < 0 && y < 0)
            //{
            //    Console.WriteLine("Point is in 3rd quadrant (bottom left)");
            //}
            //else if (x > 0 && y < 0)
            //{
            //    Console.WriteLine("Point is in 4th quadrant (bottom right)");
            //}
            //else
            //{
            //    Console.WriteLine("Point is in (0,0) coordinate");
            //}
            #endregion

            #region Task 3
            //3.User gives 3 numbers a, b, c. Output them in the ascending order.
            //Console.Write("Enter number a: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter number b: ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter number c: ");
            //int c = Convert.ToInt32(Console.ReadLine());
            //if (a == b && b == c)
            //{
            //    Console.WriteLine($"{a}, {b}, {c}");
            //}
            //else if (a > b && b > c)
            //{
            //    Console.WriteLine($"{c}, {b}, {a}");
            //}
            //else if (a > b && c > a)
            //{
            //    Console.WriteLine($"{b}, {a}, {c}");
            //}
            //else if (a > b && b < c && c < a)
            //{
            //    Console.WriteLine($"{b}, {c}, {a}");
            //}
            //else if (a > b && b > c && c < a)
            //{
            //    Console.WriteLine($"{c}, {b}, {a}");
            //}
            //else if (a < b && b < c && c < a)
            //{
            //    Console.WriteLine($"{b}, {c}, {a}");
            //}
            //else if (a < b && b > c && c > a)
            //{
            //    Console.WriteLine($"{a}, {c}, {b}");
            //}
            //else if (a < b && c < a)
            //{
            //    Console.WriteLine($"{c}, {a}, {b}");
            //}
            //else if (a > b && b == c)
            //{
            //    Console.WriteLine($"{b}, {c}, {a}");
            //}
            //else
            //{
            //    Console.WriteLine($"{a}, {b}, {c}");
            //}
            #endregion

            #region Task 4
            //4.User gives 3 numbers a, b, c. Find out solution of quadratic equation ax ^ 2 + bx + c = 0.
            //Console.Write("Enter number a: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter number b: ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter number c: ");
            //int c = Convert.ToInt32(Console.ReadLine());
            //double D = (b * b) - (4 * a * c);
            //if(D >= 0)
            //{
            //    double x1 = (-b + Math.Sqrt(D)) / (2 * a);
            //    double x2 = (-b - Math.Sqrt(D)) / (2 * a);
            //    Console.WriteLine($"x1: {x1} , x2: {x2}");
            //}
            //else
            //{
            //    Console.WriteLine("Discriminant is negative number");
            //}

            #endregion

            #region Task 5 
            //5.User gives 2-digit number. Output the word according to this number. F.e. : 13 – thirteen, 25 – twenty five and so on.
            //Console.Write("Enter 2 digit number: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //if(num == 10)
            //{
            //    Console.WriteLine("ten");
            //}
            //else if (num == 11)
            //{
            //    Console.WriteLine("eleven");
            //}
            //else if (num == 12)
            //{
            //    Console.WriteLine("twelve");
            //}
            //else if (num == 13)
            //{
            //    Console.WriteLine("thirteen");
            //}
            //else if (num == 14)
            //{
            //    Console.WriteLine("fourteen");
            //}
            //else if (num == 15)
            //{
            //    Console.WriteLine("fifteen");
            //}
            //else if (num == 16)
            //{
            //    Console.WriteLine("sixteen");
            //}
            //else if (num == 17)
            //{
            //    Console.WriteLine("seventeen");
            //}
            //else if (num == 18)
            //{
            //    Console.WriteLine("eighteen");
            //}
            //else if (num == 19)
            //{
            //    Console.WriteLine("nineteen");
            //}
            //else
            //{
            //    int firstDigit = num / 10;
            //    int secondDigit = num % 10;
            //    string[] firstDigits = { "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            //    string[] secondDigits = { "", "one", "two","three","four","five","six","seven","eight","nine" };
            //    Console.WriteLine($"{firstDigits[firstDigit-2]} {secondDigits[secondDigit]}");
            //}
            #endregion

            #region Task 6
            //6.User gives 3 numbers x, y, r. Find out if point with location (x,y) is inside the circle with radius r?
            //Console.Write("Enter number x: ");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter number y: ");
            //int y = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter number r: ");
            //int r = Convert.ToInt32(Console.ReadLine());
            //double d = Math.Sqrt((x * x) + (y * y));
            //if(d < r)
            //{
            //    Console.WriteLine("Point is inside the circle");
            //}
            //else if (d == r)
            //{
            //    Console.WriteLine("Point is on the circle");
            //}
            //else
            //{
            //    Console.WriteLine("Point is outside the circle");
            //}
            #endregion

            #region Task 7
            /* 7.Write a program with 4 different options. Below you’ll see what should happen if user will choose one of those options:
                a.Take a 3 - digit number as input, and say if square of this number equals sum of all it’s digits to the power of 3.
                b.Take a 4 - digit number and say if sum of first two digits equals sum of last 2 digits.
                c.Take a 3 - digit number as input.Say if there any 2 similar digits in it.
                d.Take a float number. Say if first 3 digits after comma contains 0.
            */
            //Console.Write("Choose option: ");
            //string option = Console.ReadLine();
            //if(option == "a")
            //{
            //    Console.Write("Enter 3 digit number: ");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    int temp = num;
            //    int[] arr = new int[3];
            //    int i = 0;
            //    int sum = 0;
            //    while(temp > 0)
            //    {
            //        int digit = temp % 10;
            //        temp = (temp - digit) / 10;
            //        arr[i] = digit;
            //        i++;
            //    }
            //    for(int j = 0; j < arr.Length; j++)
            //    {
            //        sum += arr[j];
            //    }
            //    if(num * num == Math.Pow(sum, 3))
            //    {
            //        Console.WriteLine("True");
            //    }
            //    else
            //    {
            //        Console.WriteLine("False");
            //    }
            //}
            //else if(option == "b")
            //{
            //    Console.Write("Enter 4 digit number: ");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    int temp = num;
            //    int[] arr = new int[4];
            //    int i = 0;
            //    int sum1 = 0;
            //    int sum2 = 0;
            //    while (temp > 0)
            //    {
            //        int digit = temp % 10;
            //        temp = (temp - digit) / 10;
            //        arr[i] = digit;
            //        i++;
            //    }
            //    for (int j = 0; j < arr.Length; j++)
            //    {
            //        if(j <= 1)
            //        {
            //            sum1 += arr[j];
            //        }
            //        else
            //        {
            //            sum2 += arr[j];
            //        }
            //    }
            //    if(sum1 == sum2)
            //    {
            //        Console.WriteLine("equal");
            //    }
            //    else
            //    {
            //    Console.WriteLine("not equal");
            //    }

            //}
            //else if (option == "c")
            //{
            //    Console.Write("Enter 3 digit number: ");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    int temp = num;
            //    int[] arr = new int[3];
            //    int i = 0;
            //    bool check = false;
            //    while (temp > 0)
            //    {
            //        int digit = temp % 10;
            //        temp = (temp - digit) / 10;
            //        arr[i] = digit;
            //        i++;
            //    }
            //    for (int k = 0;  k < arr.Length; k++)
            //    {
            //        for (int j = k+1; j < arr.Length; j++)
            //        {
            //            if (arr[k] == arr[j])
            //            {
            //                check = true;
            //            }
            //        }
            //    }
            //    if (check)
            //    {
            //        Console.WriteLine("yes");
            //    }
            //    else
            //    {
            //        Console.WriteLine("no");
            //    }

            //}
            #endregion
        }
    }
}
