namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            #region string
            //reference type
            //
            //
            //
            //

            //string Name;
            //Name = "Ali";
            //Console.WriteLine(Name);
            //string name1 = "ali";
            //string name2 = "nada";
            //Console.WriteLine($"anme1:{name1}");
            //Console.WriteLine($"hashcode:{name1.GetHashCode()}");
            //    Console.WriteLine($"anme1:{name2}");
            //Console.WriteLine($"hashcode:{name2.GetHashCode()}");
            //name1 = name2;
            //console.WriteLine("after");
            //Console.WriteLine($"anme1:{name1}");
            //Console.WriteLine($"hashcode:{name1.GetHashCode()}");
            //Console.WriteLine($"anme1:{name2}");
            //Console.WriteLine($"hashcode:{name2.GetHashCode()}");

            #endregion

            #region string builder 
            //دا لو الاسم بيتغير الفرق بينه وبين الاسترنج بس ان الاسترنج لو الاسم ثابت
            //    StringBuilder message;
            //message = new StringBuilder("hello");
            //  Console.WriteLine($"Message:{Message}");
            //Console.WriteLine($"the hashcpde is {Message.heshcode()}");
            ////Message append("ali);

            //Console.WriteLine($"Message:{Message}");
            //Console.WriteLine($"the hashcpde is {Message.heshcode()}");

            #endregion

            #region 1D Array
            //int[] num01 =new int [3]{6,2,3 };
            //  int[] num02 =new int []{1,2,3 };
            //int[] num03 = {1,2,3, };
            //Console.WriteLine(num01[0]);
            //Console.WriteLine(num01[1]);
            //Console.WriteLine(num01[2]);
            //Console.WriteLine($"len:{num01.Length}: rank: {num01.Rank}");
            ////----
            //foreach( int num in num01 )
            //{
            //    Console.WriteLine( num );
            //}
            #endregion

            #region 2D Array
            //int[,] a = new int[3, 5];
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"please enter the grades for student{i+1}");
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.WriteLine($"please enter the grades for subject{j + 1}");
            //        a[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            #endregion
        }
    }
}
