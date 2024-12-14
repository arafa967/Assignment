using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            #region 1

            //double[,] point = new double[3, 2];
            //Console.WriteLine("pls enter the point: ");

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"pls enter X{i + 1}");
            //    point[i, 0] = double.Parse(Console.ReadLine());

            //    Console.WriteLine($"pls enter Y{i + 1}");
            //    point[i, 1] = double.Parse(Console.ReadLine());


            //}
            //double x1 = point[0, 0], y1 = point[0, 1];
            //double x2 = point[1, 0], y2 = point[1, 1];
            //double x3 = point[2, 0], y3 = point[2, 1];



            //if ((y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1))
            //{
            //    Console.WriteLine("The points lie on a single straight line");
            //}
            //else { Console.WriteLine("The points do not lie on a single straight line"); }

            #endregion

            #region 2
            //Console.WriteLine("pls enter the time the worker takes: ");
            //double.TryParse(Console.ReadLine(), out double times);

            //if (times >= 2 && times <= 3)
            //{
            //    Console.WriteLine("they are considered highly efficient ");
            //}
            //else if (times >= 3 && times <= 4)
            //{
            //    Console.WriteLine("The worker needs to improve their speed");
            //}
            //else if (times >= 4 && times <= 5)
            //{
            //    Console.WriteLine("they are provided with training to enhance their speed");
            //}
            //else if (times > 5) { Console.WriteLine("they are required to leave the company"); }
            #endregion

            #region 3
            //Console.WriteLine("pls enter the size of array: ");
            //int.TryParse(Console.ReadLine(), out int n);

            //int[,] matrix = new int[n, n];

            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    Console.WriteLine($"pls enter value of X{i + 1}");

            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"enter Y{j + 1}");
            //        matrix[i, j] = int.Parse(Console.ReadLine());

            //    }

            //}
            //for (int i = 0; i < matrix.GetLength(0); i++) // Rows
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++) // Columns
            //    {
            //        Console.Write(matrix[i, j] + "\t");
            //    }
            //    Console.WriteLine("\n");


            //}
            #endregion

            #region 4
            //int[] Num1 = { 1, 10, 5, 9, 7 };
            //int[] Num2 = { 2, 3, 4, 5, 0 };

            //int[] Sum_array = Num1.Concat(Num2).ToArray();

            //Array.Sort(Sum_array);
            //foreach (int i in Sum_array)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region 5
            //Console.WriteLine("pls enter number of elemanet in array:");
            //int.TryParse(Console.ReadLine(), out int num);

            //int[] items = new int[num];
            //Console.WriteLine("pls enter the item in array:");
            //for (int i = 0; i < num; i++)
            //{
            //    Console.WriteLine($"item{i + 1}");
            //    items[i] = int.Parse(Console.ReadLine());

            //}


            #endregion

            #region 6

            //Console.Write("Enter Size Of The Array: ");
            //int.TryParse(Console.ReadLine(), out int size);
            //if (size <= 0)
            //    Console.WriteLine("Invaild Input ");
            //else
            //{
            //    int[] arr03 = new int[size];
            //    Console.WriteLine("Enter The Elements Of The Array: ");
            //    for (int i = 0; i < size; i++)
            //    {
            //        Console.Write($"Enter Element {i + 1} ==> ");
            //        while (!(int.TryParse(Console.ReadLine(), out arr03[i])))
            //            Console.WriteLine("Please Enter An Integer");   
            //    }
            //    bool[] visited = new bool[size]; // Array to keep track of visited elements

            //    Console.WriteLine("\nFrequency of Each Element:");
            //    for (int i = 0; i < size; i++)
            //    {
            //        if (visited[i]) 
            //            continue;

            //        int count = 1; 
            //        for (int j = i + 1; j < size; j++)
            //        {
            //            if (arr03[i] == arr03[j])
            //            {
            //                count++;
            //                visited[j] = true;
            //            }
            //        }

            //        Console.WriteLine($"Element {arr03[i]} occurs {count} time(s).");
            //    }
            #endregion

            #region 7

            //Console.WriteLine("pls enter number of element in arrey: ");
            //int.TryParse(Console.ReadLine(), out int N);

            //double[] Item = new double[N];
            //double[] Item2 = new double[N];

            //for (int i = 0; i < N; i++) 
            //{
            //    Console.WriteLine($"item{i+1}");
            //    Item[i] = double.Parse(Console.ReadLine());



            //}
            //Array.Sort(Item);
            //for (int j = 0; j < N; j++)
            //{
            //    Item2[j]=Item[j];

            //}
            //double second_Largest = Item2[N - 2]; 
            //Console.WriteLine($"\nThe second largest value is: {second_Largest}");




            #endregion

            #region 8
            //Console.Write("Enter Size Of The Array: ");
            //int.TryParse(Console.ReadLine(), out int size);
            //if (size < 1)
            //    Console.WriteLine("Invaild Input ");
            //else
            //{
            //    int[] arr06 = new int[size];
            //    Console.WriteLine("Enter The Elements Of The Array: ");
            //    for (int i = 0; i < size; i++)
            //    {
            //        Console.Write($"Enter Element {i + 1} ==> ");
            //        while (!(int.TryParse(Console.ReadLine(), out arr06[i])))
            //            Console.WriteLine("Please Enter An Integer");
            //    }
            //    int MaxDistance = 0;
            //    for (int i = 0; i < size; i++)
            //    {
            //        for (int j = size - 1; j > 0; j--)
            //        {
            //            if (arr06[i] == arr06[j])
            //            {
            //                int distance = j - i;
            //                if (distance > MaxDistance) 
            //                {
            //                    MaxDistance = distance;
            //                }
            //            }

            //        }

            //    }
            //    Console.WriteLine($"The Longest Distance Between Two Equal Elements Is: {MaxDistance}");
            #endregion

            #region 9

            //Console.WriteLine("enter the string: ");
            //String Str = Console.ReadLine();

            //String[] word = Str.Split(' ');

            //Array.Reverse(word);
            //Console.WriteLine(String.Join(" ", word));

            #region  anethor solution 

            //Console.WriteLine("enter the string: ");
            //String Str = Console.ReadLine();

            //String[] word = Str.Split(' ');

            //Array.Reverse(word);
            //for (int i = 0; i < word.Length; i++) 
            //{ 

            //    Console.WriteLine(word[i]);
            //}


            #endregion

            #endregion

            #region 10
            //    Console.WriteLine("pls enter element of first array: ");

            //    int[,] num1 = new int[2, 3];
            //    int[,] num2 = new int[2, 3] { { 1, 2, 4 }, { 3, 5, 6 } };

            //    for (int i = 0; i <  2; i++)
            //    {
            //        Console.WriteLine($"Pls enter value of X{i + 1}");

            //        for (int j = 0; j < 3; j++)
            //        {
            //            Console.WriteLine($" enter y{j + 1}");
            //            num1[i, j] = int.Parse(Console.ReadLine());
            //    }

            //    }
            //   Array.Copy(num1, num2, num1.Length);


            //for (int i = 0; i < num2.GetLength(0); i++) // Rows
            //    {
            //        for (int j = 0; j < num2.GetLength(1); j++) // Columns
            //        {
            //            Console.Write(num2[i, j] +  "\t");



            //        }
            //        Console.WriteLine("\n");

            //}

            #endregion

            #region 11
            //int[] array = { 1, 2, 3, 4, 5 };
            //for (int i = array.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(array[i]);
            //}
            #endregion

            #region 12

            //Console.WriteLine("pls enter the Fnumber ");
            //double.TryParse(Console.ReadLine(), out double Num1);

            //Console.WriteLine("pls enter the Snumber ");
            //double.TryParse(Console.ReadLine(), out double Num2);

            //Console.WriteLine("pls enter the operation(+,*,-,/) ");
            //char.TryParse(Console.ReadLine(),out char operation);


            //switch (operation)
            //{ 
            //    case '+':
            //        Console.WriteLine(Num1+Num2);
            //        break;
            //    case '-':
            //        Console.WriteLine(Num1-Num2);
            //        break;
            //    case '*':
            //        Console.WriteLine(Num1 * Num2);
            //        break;
            //    case '/':
            //        Console.WriteLine(Num1 / Num2);
            //        break;
            //    default: Console.WriteLine("pls enter the operation");
            //        break;


            //}





            #endregion

            #region 13 
            //Console.Write("Enter A String: ");
            //string taxt = Console.ReadLine();
            //char[] chars = taxt.ToCharArray();
            //for (int i = chars.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(chars[i]);
            //}

            #endregion

            #region  14 
            //Console.Write("Enter an integer: ");
            //string input = Console.ReadLine();


            //if (int.TryParse(input, out int number))
            //{

            //    if (number < 0)
            //    {
            //        Console.Write("-");
            //        input = input.Substring(1); 
            //    }

            //    char[] val = input.ToCharArray();
            //    for (int i = val.Length - 1; i >= 0; i--)
            //    {
            //        Console.Write(val[i]);
            //    }

            //    Console.WriteLine();
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //}
            #endregion

            #region  15 

            Console.WriteLine("pls enter the start number ");
            int.TryParse(Console.ReadLine(), out int start);

            Console.WriteLine("pls enter the end number ");
            int.TryParse(Console.ReadLine(), out int end);

            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i);
                }


            }

            #endregion

            #region  16 
            Console.WriteLine("Enter A Decimal Number: ");
            int.TryParse(Console.ReadLine(), out int decimall);
            string bin = "";
            while (decimall > 0)
            {
                int remainder = decimall % 2; // --> binary
                bin = remainder.ToString() + bin;
                decimall /= 2;
            }
            Console.WriteLine(bin);

            #endregion





            static bool IsPrime(int number)
            {
                if (number <= 1) return false;

                for (int j = 2; j <= Math.Sqrt(number); j++)
                {
                    if (number % j == 0)
                        return false;
                }

                return true;
            }


        }
    }
               

}
