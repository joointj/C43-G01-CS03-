using System.Runtime.Intrinsics.Arm;
using System.Text;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            // 1- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            //Console.WriteLine("write the number");
            //int number = int.Parse(Console.ReadLine());
            //if (number % 3 == 0)
            //{
            //    Console.WriteLine("Yes");
            //} 
            //else 
            //{
            //    Console.WriteLine("No");
            //}
            #endregion

            #region Q2 
            //Console.WriteLine("enter the number");
            //int number = int.Parse(Console.ReadLine());
            //if (number < 0) {
            //    Console.WriteLine("Negative");

            //}
            //else {
            //    Console.WriteLine("Positive");

            //}
            #endregion

            #region Q3
            //int[] numbers = new int[3];
            //int i = 0;
            //int max = 0;
            //int min = 999999;

            //while(i < 3)
            //{
            //    Console.WriteLine($"enter number {i}");
            //    int num= int.Parse(Console.ReadLine());
            //    numbers[i] = num;

            //    if ( numbers[i] > max ) max = numbers[i];
            //    if ( numbers[i] < min ) min = numbers[i];
            //    i++;
            //}
            //Console.WriteLine($"max number is {max}");
            //Console.WriteLine($"min number is {min}");
            #endregion

            #region Q4 
            //Console.WriteLine("enter the number");
            //int number = int.Parse(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("even");
            //}
            //else { Console.WriteLine("odd"); 
            //}
            #endregion

            #region Q5
            //Console.WriteLine("write a letter");
            //string name = Console.ReadLine();
            //switch (name)
            //{
            //    case "o":
            //        Console.WriteLine("vowel");
            //        break;
            //    case "a":
            //        Console.WriteLine("vowel");
            //        break;
            //    case "e":
            //        Console.WriteLine("vowel");
            //        break;
            //    case "i":
            //        Console.WriteLine("vowel");
            //        break;
            //    case "u":
            //        Console.WriteLine("vowel");
            //        break;
            //    default:
            //        Console.WriteLine("constant");
            //        break;
            //}
            #endregion

            #region Q6
            //Console.WriteLine("Enter a number");
            //int num = int.Parse(Console.ReadLine());

            //for (int i = 1; i < num; i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion


            #region Q7
            //Console.WriteLine("Enter a number");
            //int num = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine(num*i);
            //}
            #endregion

            #region Q8
            //Console.WriteLine("Enter a number");
            //int num = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= num; i++)
            //{
            //    if (i % 2 == 0) { Console.WriteLine(i); }

            //}
            #endregion

            #region Q9
            /*Console.WriteLine("Enter a number 1");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number 2");
            int num2 = int.Parse(Console.ReadLine());
            int result = 1; 

            for (int i = 0; i < num2; i++)
            {
                result *= num; 
            }

            Console.WriteLine($"{num} raised to the power {num2} is: {result}");
            */
            #endregion
            #region Q10
            ///*
            // * Write a program to enter marks of five subjects and calculate total, average and percentage.
            // */
            //Console.WriteLine("Enter Five Subjects");
            //int sum = 0;
            //for (int i = 0; i < 5; i ++)
            //{
            //    int number;
            //    do
            //    {
            //        Console.WriteLine($"Enter the {i + 1} subject");
            //    } while (!int.TryParse(Console.ReadLine(), out number));
            //    sum += number;
            //}
            //double average = sum / 5.0;
            //double percentage = sum / 500.0 * 100.0;
            //Console.WriteLine($"Total marks {sum} \nAverage Marks {average}\nPercentage {percentage}");
            #endregion
            #region Q11
            ///*
            // * Write a program to input the month number and print the number of days in that month.
            // */
            //int month;
            //do
            //{
            //    Console.WriteLine("Enter a month number:");
            //} while (!int.TryParse(Console.ReadLine(), out month));

            //if (month <= 7  )
            //{
            //    Console.WriteLine(month == 2 ? "Days in Month 29 or 28 based on type of year (leap or non leap)" : (month % 2 == 0) ? "Days in Month 30" : "Days in Month 31");
            //}
            //if (month >= 8)
            //{
            //    Console.WriteLine((month % 2 == 0) ? "Days in Month 31" : "Days in Month 30");
            //}
            #endregion
            #region Q12
            ///*
            // * Write a program to create a Simple Calculator.
            // */
            //Console.WriteLine("Simple calculator getting x , y and out + - * / % operations");
            //int x, y;
            //do
            //{
            //    Console.WriteLine("Enter First numnber");
            //} while (!int.TryParse(Console.ReadLine(), out x));
            //do
            //{
            //    Console.WriteLine("Enter Second numnber");
            //} while (!int.TryParse(Console.ReadLine(), out y));
            //Console.WriteLine($"x + y = {x + y}");
            //Console.WriteLine($"x - y = {x - y}");
            //Console.WriteLine($"x * y = {x * y}");
            //Console.WriteLine($"x / y = {x / y}");
            //Console.WriteLine($"x % y = {x % y}");
            #endregion
            #region Q13
            ///*
            // * Write a program to allow the user to enter a string and print the REVERSE of it.
            // */
            //Console.WriteLine("Enter a string");
            //StringBuilder str = new StringBuilder(Console.ReadLine());
            //StringBuilder strrev = new StringBuilder("");
            //for (int i = str.Length - 1; i >= 0; i --)
            //{
            //    strrev.Append(str[i]);
            //}
            //Console.WriteLine(strrev);
            #endregion
            #region Q14
            ///*
            // * Write a program to allow the user to enter int and print the REVERSED of it.
            // */
            //int number;
            //do
            //{
            //    Console.WriteLine("Enter a number");
            //} while (!int.TryParse(Console.ReadLine(), out number));
            //StringBuilder str = new StringBuilder(Convert.ToString(number));
            //StringBuilder strrev = new StringBuilder();
            //for (int i = str.Length - 1; i >= 0; i --)
            //{
            //    strrev.Append(str[i]);
            //}
            //Console.WriteLine(strrev);
            #endregion
            #region Q15
            ///*
            // * Write a program in C# Sharp to find prime numbers within a range of numbers.
            // */
            //int start , end;
            //do
            //{
            //    Console.WriteLine("Enter the start of the range");
            //} while (!int.TryParse(Console.ReadLine(), out start));
            //do
            //{
            //    Console.WriteLine("Enter the end of range");
            //} while (!int.TryParse(Console.ReadLine(), out end));
            //if (end < start)
            //{
            //    Console.WriteLine("start must be less than or equal the end try again and re run the code");
            //}else
            //{
            //    for (int i = start; i <= end; i++)
            //    {
            //        if (i == 1)
            //        {
            //            continue;
            //        }
            //        // check primirity
            //        bool isPrime = true;
            //        for (int j = 2; j * j <= i; j++)
            //        {
            //            if (i % j == 0)
            //            {
            //                isPrime = false;
            //                break;
            //            }
            //        }
            //        if (isPrime)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //}
            #endregion
            #region Q16
            ///*
            // * Write a program in C# Sharp to convert a decimal number into binary without using an array.
            // */
            //int number;
            //do
            //{
            //    Console.WriteLine("Enter a number");
            //} while (!int.TryParse(Console.ReadLine(), out number));
            //bool flag = false;
            //for (int i = 61; i >= 0; i --)
            //{
            //    //Console.WriteLine((1 << i));
            //    if ((number & (1l << i)) > 0)
            //    {
            //        Console.Write(1);
            //        flag = true;
            //    }else
            //    {
            //        if (flag)
            //        {
            //            Console.Write(0);
            //        }
            //    }
            //}
            #endregion
            #region Q17
            ///*
            // * Create a program that asks the user to input three points (x1, y1),
            // * (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.
            // */
            //double[] xarr = new double[3];
            //double[] yarr = new double[3];
            //for (int i = 0; i < 3; i ++)
            //{
            //    Console.WriteLine($"Enter point {i + 1}");
            //    double x;
            //    do
            //    {
            //        Console.WriteLine($"enter x{i + 1} value");
            //    } while(!double.TryParse(Console.ReadLine(), out x));
            //    xarr[i] = x;
            //    double y;
            //    do
            //    {
            //        Console.WriteLine($"enter y{i + 1} value");
            //    } while (!double.TryParse(Console.ReadLine(), out y));
            //    yarr[i] = y;
            //}
            //if (xarr[0] - xarr[1] == 0)
            //{
            //    // vertical line
            //    if (xarr[0] == xarr[1] && xarr[1] == xarr[2])
            //    {
            //        Console.WriteLine("Points on a straight line");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Points are not on a straight line");
            //    }
            //}else
            //{
            //    double slope = (yarr[0] - yarr[1]) / (xarr[0] - xarr[1]);
            //    double c = yarr[0] - xarr[0] * slope;

            //    double slope2 = (yarr[1] - yarr[2]) / (xarr[1] - xarr[2]);
            //    double c2 = yarr[1] - xarr[1] * slope;

            //    if (slope == slope2 && c == c2)
            //    {
            //        Console.WriteLine("Points on a straight line");
            //    }else
            //    {
            //        Console.WriteLine("Points are not on a straight line");
            //    }
            //}

            #endregion
            #region Q18
            //double time_per_task;
            //do
            //{
            //    Console.WriteLine("Enter time per taks for the employee the least number is 2");
            //}while (!double.TryParse(Console.ReadLine(), out time_per_task) || time_per_task < 2);
            //if (time_per_task >= 2 && time_per_task <= 3)
            //    Console.WriteLine("highly efficiente");
            //if (time_per_task > 3 && time_per_task <= 4)
            //    Console.WriteLine("they are instructed to increase their speed");
            //if (time_per_task > 4 && time_per_task <= 5)
            //    Console.WriteLine("provided with training to enhance their speed");
            //if (time_per_task > 5)
            //    Console.WriteLine("required to leave the company");
            #endregion
            #region Q19
            //int number;
            //do
            //{
            //    Console.WriteLine("Enter the degree of the identity matrix");
            //} while (!int.TryParse(Console.ReadLine(), out number));
            //for (int i = 0; i < number; i ++)
            //{
            //    for (int j = 0; j < number; j ++)
            //    {
            //        if (i == j)
            //        {
            //            Console.Write(1);
            //        }
            //        else
            //        {
            //            Console.Write(0);
            //        }
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region Q20
            ///*
            // * Write a program in C# Sharp to find the sum of all elements of the array.
            // */
            //int number;
            //do
            //{
            //    Console.WriteLine("Enter the number of elements in the array");
            //} while (!int.TryParse(Console.ReadLine(), out number));
            //int[] arr = new int[number];
            //for (int i = 0; i < arr.Length; i ++)
            //{
            //    do
            //    {
            //        Console.WriteLine($"Enter the {i + 1} element of the array");
            //    } while (!int.TryParse(Console.ReadLine() , out arr[i]));
            //}
            //int sum = 0;
            //for (int i = 0; i < arr.Length; i ++)
            //{
            //    sum += arr[i];
            //}
            //Console.WriteLine("The sum of the array elements are");
            //Console.WriteLine(sum);
            #endregion
        }
    }
}
