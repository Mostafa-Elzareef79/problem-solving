using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp14
{
	#region Linq classes
	//class Subject
	//{
	//    public int Code { get; set; }
	//    public string Name { get; set; }
	//}

	//class Student
	//{
	//    public int ID { get; set; }
	//    public string FirstName { get; set; }
	//    public string LastName { get; set; }
	//    public Subject[] Subjects { get; set; }
	//}
	#endregion
	internal class Program
    {
        static void Main(string[] args)
        {
			#region Sheet 1 assuit
			//this for tasks algorithms and problem solving by c# from code forces
			#region watermellon
			//int w = int.Parse(Console.ReadLine());
			//if (w%2 == 0 && w>0 && w<100)
			//{
			//    Console.WriteLine("Yes");
			//}
			//else { Console.WriteLine("No"); }
			#endregion

			#region mostafa=>m4a

			//  int n = 4;
			//  //var Count = 0;
			//  // var b = "word";
			//  // var a = "localization";
			//  // var c = "thatis jnrbsjf lkjgvbrluibzfjavghre;bdijbzvdujharuihSGV:INsvidjrhgvrionfnnnnj";
			//  Console.WriteLine( "please enter your text ;");
			//  var a=Console.ReadLine();
			//  if (a.Length == n)
			//  {
			//      Console.WriteLine(a);
			//  }
			//else if (a.Length!=n) {
			//      if (a.Length >99) {
			//          Console.WriteLine("fuken you pro");

			//      }
			//      Console.Write(a[0]);
			//      Console.Write(a.Length-2);
			//Console.Write(a[a.Length-1]);





			//}
			#endregion

			#region hello name
			//string name = Console.ReadLine();
			//Console.WriteLine($"Hello,{name}");
			#endregion

			#region console.writelin
			//int x = 12;long y = (long)456952465651625145;char z = 's';float l = 0.02625825F;double n = 0.6514065194518487181710;
			//Console.WriteLine($"{x}\n{y}\n{z}\n{l}\n{n}\n");
			#endregion


			#region simple calc
			//            int x=5; long y=10;
			//            int sum=x+y;
			//            int mul = x * y;
			//            int sub=x-y;
			//            Console.WriteLine($@" {x}+{y} = {sum}
			// {x}*{y} = {mul} 
			//{x}-{y} = {sub}");


			#endregion


			#region diffrent equation
			//int a=2; long b=3; int c=4; long d=5;
			//long x = (a*b) - (c*d);
			//Console.WriteLine("diffrence = "+x);
			#endregion


			#region area circle

			//double x = double.Parse(Console.ReadLine());
			//double bi = Math.PI;
			//double eq = (bi * x * x);
			//Console.WriteLine($"circle area which radiouse is{x} = " + eq);
			#endregion

			#region digit summution
			//my logical thinking
			//long x = 12;

			// long y = 55;
			// string d = Convert.ToString(x + y);
			// d.ToString();
			// Console.WriteLine(d[1]);
			//the logical thinking/////////////////////
			//long y = long.Parse(Console.ReadLine()) % 10;
			//long x = long.Parse(Console.ReadLine()) % 10;
			//Console.WriteLine($"the sumution to the last two digits is =  { y + x}");




			#endregion

			#region summution from 1 to N
			//long sum = 0;
			//Console.WriteLine("enter the num do you want sumation to zero please ");
			//long x = long.Parse(Console.ReadLine());
			//for (long i = x; i > 0; i--)
			//{
			//    sum += i;

			//}
			//Console.WriteLine($"your sumation from 0 to {x} is ={sum}");
			// u can use (n(n+1))/2 to get a summutin number from 1 to number 


			#endregion

			#region two numbers
			//Console.WriteLine("enter num 1 ");
			//double a = double.Parse(Console.ReadLine());
			//Console.WriteLine("enter num 2 ");
			//double b = double.Parse(Console.ReadLine());
			//double s = a / b;
			//Console.WriteLine("the floor numer is ");
			//Console.WriteLine(Math.Floor(s));
			//Console.WriteLine("the cell numer is ");
			//Console.WriteLine(Math.Ceiling(s));
			//Console.WriteLine("the round numer is ");
			//Console.WriteLine(Math.Round(s));
			#endregion


			#region welcome condition
			//int a = int.Parse(Console.ReadLine());
			//int b = int.Parse(Console.ReadLine());
			//if (a == b || a >= b)
			//{
			//    Console.WriteLine("yes");
			//}
			//else { Console.WriteLine("no"); }
			#endregion

			#region multiples
			//int x = int.Parse(Console.ReadLine());
			//int y = int.Parse(Console.ReadLine());
			//if ((x % y) ==0 || (y % x) == 0)
			//{
			//    Console.WriteLine("multiples");
			//}
			//else
			//{
			//    Console.WriteLine("no multiples");
			//}
			#endregion

			#region max and min
			//Console.WriteLine("enter your first number ");
			//int x = int.Parse(Console.ReadLine());
			//Console.WriteLine("enter your second number ");
			//int y = int.Parse(Console.ReadLine());
			//Console.WriteLine("enter your third number ");
			//int z = int.Parse(Console.ReadLine());
			//var v=Math.Max(Math.Max(z, x),y);
			//var o = Math.Min(Math.Min(z, x), y);
			//Console.Write("max "+v); Console.Write("  min "+o);
			#endregion

			#region brothers or not
			//Console.WriteLine("enter your name1");
			//var name1= Console.ReadLine();
			//Console.WriteLine("enter your name2");
			//var name2 = Console.ReadLine();
			//var so1 = name1.Split(" ");
			//var so2 = name2.Split(" ");
			//if(so1[1] == so2[1])
			//{
			//    Console.WriteLine("are brother ");

			//}
			//else
			//{
			//    Console.WriteLine("not brothers");
			//}


			#endregion

			#region askii code
			//int a = int.Parse(Console.ReadLine());
			//the logical thing
			//////////////////char q;
			//////////////////Console.WriteLine("enter the chracter");
			//////////////////q = char.Parse(Console.ReadLine());
			//////////////////if (q >= '0' && q <= '1')
			//////////////////{
			//////////////////    Console.WriteLine("is digit");
			//////////////////}
			//////////////////else
			//////////////////{
			//////////////////    Console.WriteLine("alpha");
			//////////////////    if (q >= 'A' && q <= 'Z')
			//////////////////    {
			//////////////////        Console.WriteLine("capital");
			//////////////////    }
			//////////////////    else
			//////////////////    {
			//////////////////        Console.WriteLine("small");
			//////////////////    }
			//////////////////}
			///my logical think
			//            else if (q <= 9) { }
			//            Console.WriteLine("enter the caracteer");
			//            char z= char.Parse(Console.ReadLine());
			//            int f = (int)z;
			//            if (f >= 90&&f>=120)
			//            {
			//                Console.WriteLine(@"ALPHAPET
			//CAPITAL");
			//            }
			//            else if (f <= 122 && f > 90)
			//            {
			//                Console.WriteLine(@"ALPHAPET
			//not CAPITAL");
			//            }
			//            Console.WriteLine("aski code is "+f);
			//            //char x = (char)a;
			//            //if (x > 90)
			//            //{
			//            //    Console.WriteLine("not capital");
			//            //}
			//            //else
			//            //{
			//            //    Console.WriteLine("capital");
			//            //}

			//            //Console.WriteLine(x);
			#endregion







			#region conver a=>A
			//            bool invalid = true;

			//            char v;

			//            do
			//            {
			//                Console.WriteLine("enter character");
			//                v = char.Parse(Console.ReadLine());


			//                if (v >= '0' && v <= '9')
			//                {
			//                    Console.WriteLine(@"eror: please enter alphapet character
			//**************************************************************************************************");

			//                }
			//                else
			//                {
			//                    break;
			//                }
			//                invalid = false;
			//            } while (!invalid);
			//            if (v >= 'A' && v <= 'Z')
			//            {
			//                Console.WriteLine((char)((int)(v + 32)));
			//            }
			//            else if (v >= 'a' && v <= 'z')
			//            {
			//                Console.WriteLine((char)((int)(v - 32)));
			//            }

			#endregion




			#region claculltor

			////Console.WriteLine("enter number 1");
			//int x=int.Parse(Console.ReadLine());
			////Console.WriteLine("whate is opreation do you want it");
			//char s= char.Parse(Console.ReadLine());
			////Console.WriteLine("enter number 2");
			//int y = int.Parse(Console.ReadLine());
			//float sum=0;
			//if (s == '+')
			//{
			//    sum = x + y;
			//}
			//if (s == '-')
			//{
			//    sum = x - y;
			//}
			//if (s == '*')
			//{
			//   sum = x * y;
			//}
			//if (s == '/')
			//{
			//    sum = x / y;
			//}

			//Console.WriteLine("result "+sum);





			#endregion




			#region first digt even or odd
			//my logical thing
			//int x=int.Parse(Console.ReadLine());
			//int y = (int)((x.ToString().Split()[0])[0]);
			//if (y % 2 == 0)
			//{
			//    Console.WriteLine("even first digit");
			//}
			//else
			//{
			//    Console.WriteLine("odd first digit");
			//}
			//Console.WriteLine();
			//the logical thing
			//////////////////////int c=int.Parse(Console.ReadLine());
			//////////////////////var x = c / 1000;
			//////////////////////Console.WriteLine(x);


			#endregion



			#region cordinat system

			//float x = float.Parse(Console.ReadLine());
			//float y = float.Parse(Console.ReadLine());
			//if (x > 0 && y > 0)
			//{
			//    Console.WriteLine("Q1");
			//}
			//if (x < 0 && y > 0)
			//{
			//    Console.WriteLine("Q2");
			//}
			//if (x < 0 && y < 0)
			//{
			//    Console.WriteLine("Q3");
			//}
			//if (x > 0 && y < 0)
			//{
			//    Console.WriteLine("Q4");
			//}
			//if (x == 0 && y == 0)
			//{
			//    Console.WriteLine("0");
			//}
			#endregion



			#region age of days
			//Console.WriteLine("enter number of days for man");
			//int age = int.Parse(Console.ReadLine());
			//int stable = age;

			//int years = 0;
			//int months = 0;
			//int days = 0;
			//for (int i = 0; i < stable; i++)
			//{
			//    if (age >= 365)
			//    {
			//        years++;
			//        age -= 365;
			//    }
			//    else if (age < 365 && age >= 30)
			//    {
			//        months++;
			//        age -= 30;
			//    }
			//    else if (age < 30)
			//    {
			//        days++;
			//        age -= 1;
			//    }

			//}
			////days = stable - (years * 365) - (months * 30);
			//Console.WriteLine(years + " years" + months + " month " + days + " days");


			#endregion



			#region interval
			//float z = float.Parse(Console.ReadLine());
			//if (z>=0&&z<=25)
			//{
			//    Console.WriteLine($@"interval[0,25]");
			//}
			//else if (z > 25 && z <= 50)
			//{
			//    Console.WriteLine($@"interval(25,50]");
			//}
			//if (z > 50 && z <= 75)
			//{
			//    Console.WriteLine($@"interval(50,75]");
			//}
			//if (z > 75 && z <= 100)
			//{
			//    Console.WriteLine($@"interval(75,100]");
			//}
			//if (z >100)
			//{
			//    Console.WriteLine($@"out of interval");
			//}
			#endregion



			#region asc and desc
			// int x = int.Parse(Console.ReadLine());
			// int y = int.Parse(Console.ReadLine());
			// int z = int.Parse(Console.ReadLine());


			// if(x>=y&&x>=z)
			// {
			//     if (y >= z) {
			//         Console.WriteLine(@$"
			//         {x}
			//         {y}
			//         {z}");
			//                             Console.WriteLine();
			//                             Console.WriteLine(@$"
			//         {z}
			//         {y}
			//         {x}");
			//     }
			//     else if(z>=y)
			//     {
			//                             Console.WriteLine(@$"
			//         {x}
			//         {z}
			//         {y}");
			//         Console.WriteLine();
			//         Console.WriteLine(@$"
			//         {y}
			//         {z}
			//         {x}");

			//     }


			// }
			//else if (y >= z && y >= x)
			// {
			//     if (z >=x )
			//     {
			//                             Console.WriteLine(@$"
			//         {y}
			//         {z}
			//         {x}");
			//         Console.WriteLine();
			//         Console.WriteLine(@$"
			//         {x}
			//         {z}
			//         {y}");
			//     }
			//     else if (x>=z)
			//     {
			//         Console.WriteLine(@$"
			//         {y}
			//         {x}
			//         {z}");
			//         Console.WriteLine();
			//         Console.WriteLine(@$"
			//         {z}
			//         {x}
			//         {y}");
			//     }


			// }
			// else if (z >= x && z>= y)
			// {
			//     if (y >= x)
			//     {
			//                                 Console.WriteLine(@$"
			//             {z}
			//             {y}
			//             {x}");
			//         Console.WriteLine();
			//         Console.WriteLine(@$"
			//         {x}
			//         {y}
			//         {z}");
			//     }
			//     else
			//     {
			//         if (y >= x)
			//         {
			//                                     Console.WriteLine(@$"
			//             {z}
			//             {x}
			//             {y}");
			//             Console.WriteLine();
			//             Console.WriteLine(@$"
			//         {y}
			//         {x}
			//         {z}");
			//         }
			//     }


			// }
			#endregion



			#region float or int
			////////float s=float.Parse(Console.ReadLine());
			////////int r = (int)s;
			////////if(r==s)
			////////{
			////////    Console.WriteLine("int"+r);
			////////}
			////////else
			////////{ Console.WriteLine("float "+s);

			////////}
			//string d=s.ToString();
			//string x= d.Split(".")[0];

			//uint o= uint.Parse(x);

			//string z = d.Split(".")[1];
			//uint l = uint.Parse(z);

			//if (l>0)
			//{Console.WriteLine($"float number{o}.{l}");

			//}
			//else
			//{
			//     Console.WriteLine("int number"+o);
			//}
			//if (r==o)
			//{
			//    Console.WriteLine("int number" + o);

			//}

			//Console.WriteLine();
			//s.Split(".");
			//int a = (int)s[0];
			//int c = ((int)s[1]);
			//Console.WriteLine(a);
			//if(c == 0 )
			//{
			//    Console.WriteLine("this int number");
			//}
			//else
			//{
			//    Console.WriteLine("this float number");
			//}
			//Console.WriteLine($"{a}.{c}");
			//Console.WriteLine();

			#endregion



			#region comparision

			//int s = int.Parse(Console.ReadLine());
			//char b = char.Parse(Console.ReadLine());
			//int x = int.Parse(Console.ReadLine());
			//if (b == '>' && s > x)
			//{
			//    Console.WriteLine($"right");
			//}
			//else if (b == '<' && s < x)
			//{
			//    Console.WriteLine($"right");
			//}
			//else if (b == '=' && s == x)
			//{
			//    Console.WriteLine($"right");
			//}
			//else
			//{
			//    Console.WriteLine("wrong");
			//    // }
			#endregion




			#region math ex..

			//int a = int.Parse(Console.ReadLine());
			//char s = char.Parse(Console.ReadLine());
			//int b= int.Parse(Console.ReadLine());
			//Console.WriteLine("=");
			//int o = int.Parse(Console.ReadLine());
			//var d = a + b;
			//var t= a * b;
			//var c= a - b;
			//if (s=='+') {
			//    if (a+b==d&&a+b==o) { Console.WriteLine("yes"); }
			//    else { Console.WriteLine("no "+d); }

			//}
			//else if (s == '*'  )
			//{
			//    if (a * b == t&&a*b==o) { Console.WriteLine("yes"); }
			//    else { Console.WriteLine("no "+t); }
			//}
			//else if(s == '-' )
			//{
			//    if (a - b == c&&a-b==o) { Console.WriteLine("yes"); }
			//    else { Console.WriteLine("no "+c); }
			//}


			#endregion

			#region intersection
			//Console.WriteLine("give me first didgt interval1");
			//int a = int.Parse(Console.ReadLine());
			//Console.WriteLine("give me last didgt interval1");
			//int b = int.Parse(Console.ReadLine());

			//Console.WriteLine("give me first didgt interval2");
			//int c = int.Parse(Console.ReadLine());

			//Console.WriteLine("give me last didgt interval2");
			//int d = int.Parse(Console.ReadLine());

			//int x = 0; int y=0;

			//if(b<c)
			//{
			//    Console.WriteLine(-1);
			//}
			//else if(b==c) 
			//{  Console.WriteLine(b);

			//}
			//else if(c<b&& d>b) {
			//    Console.WriteLine($"{c} {b}");
			//}
			//else if (c < b && d == b)
			//{
			//    Console.WriteLine($"{c} {d}");
			//}
			//else if (c < b&&d<b) { Console.WriteLine($"{c} {d}"); }

			#endregion


			#region last two digit
			//int a = int.Parse(Console.ReadLine());
			//int b = int.Parse(Console.ReadLine());
			//int c = int.Parse(Console.ReadLine());
			//int d = int.Parse(Console.ReadLine());
			//int e= a*b*c*d;
			//string s = e.ToString();
			//Console.WriteLine($"{s[s.Length-2] }{s[s.Length-1] }");
			#endregion


			#region hard compare
			//int a = int.Parse(Console.ReadLine());
			//int b = int.Parse(Console.ReadLine());
			//int c = int.Parse(Console.ReadLine());
			//int d = int.Parse(Console.ReadLine());

			//if(Math.Pow(a,b) > Math.Pow(c, d))
			//{
			//    Console.WriteLine("yes");
			//}
			//else { Console.WriteLine("no"); }
			#endregion
			//end shhet 1 assuit problem solving alhamdllah
			#endregion


			#region Sheet 2 assuit

			//start sheet 2 assuit


			#region 1>n
			//int a = int.Parse(Console.ReadLine());
			//for (int i = 1; i <= a; i++)
			//{
			//    Console.WriteLine(i);
			//}
			#endregion

			#region even loop number
			//int a = int.Parse(Console.ReadLine());
			//for (int i = 1; i <= a; i++)
			//{
			//    if (i%2==0)
			//    {
			//        Console.WriteLine(i);
			//    }

			//}

			#endregion


			#region even or odd or potive or negative
			//int a = int.Parse(Console.ReadLine());
			//int odd = 0;
			//int even = 0;
			//int pos = 0;
			//int neg = 0;

			//for (int i = 0; i < a; i++)
			//{
			//    int b = int.Parse(Console.ReadLine());
			//    if (b>0)
			//    {
			//        pos++;
			//        if (b %2== 0||b==0)
			//        {
			//                even++;
			//        }
			//        else
			//        { 
			//            odd++;

			//        }
			//    }
			//    else if (b < 0)
			//    {
			//        neg++;
			//        if (b % 2 == 0)
			//        {
			//            even++;
			//        }
			//        else
			//        {
			//            odd++;

			//        }
			//    }


			//}
			//Console.WriteLine("even "+even);
			//Console.WriteLine("odd "+odd);

			//Console.WriteLine("pos "+pos);

			//Console.WriteLine("neg "+neg);

			#endregion

			#region giss password
			//int x = 89921;
			//for (int i = 10000; i > 0; i++)
			//{
			//    if (i != x)
			//    {
			//        Console.WriteLine("wrong");
			//    }
			//    else { Console.WriteLine("correct is " + i); break; }
			//}
			#endregion


			#region max
			// int a = int.Parse(Console.ReadLine());
			//int b = 0;
			//int c = 0;
			//for (int i = 0; i < a; i++)
			//{
			//  b = int.Parse(Console.ReadLine());
			//    if (b >= c) {
			//        c=b;
			//    }

			//}
			//Console.WriteLine("max value is "+c);

			#endregion


			#region multiplication table
			//for(int i = 1; i <= 12; i++)
			//{
			//    Console.WriteLine($"1*{i}={1*i}");
			//}


			#endregion


			#region factorial
			//int a = int.Parse(Console.ReadLine());
			//int c = 1; int d=0; 

			//for (int i = 0; i < a; i++)
			//{
			//    int b = int.Parse(Console.ReadLine());
			//    for (int j = b; j >=1 ; j--)
			//    {
			//        c*=j;
			//    }  Console.WriteLine(c);
			//}

			#endregion

			#region prime or not
			/////////////////////////////not under stand it
			//int a = int.Parse(Console.ReadLine());
			//int v = 0;

			//for (int i = 2; i < a; i++)
			//{
			//    if (a%i==0)
			//    {
			//        v=1;

			//    }


			//}
			//if(v==0)
			//{
			//    Console.WriteLine("yes");
			//}
			//else 
			//Console.WriteLine("no");
			//for (int i = 2;; i++) {
			//    if (y==a&&x==1 &&a!=1 )
			//    {
			//        Console.WriteLine("prime");break;
			//    }
			//    else if (a == 1 || a % 2 == 0)
			//    {
			//        Console.WriteLine("not prime"); break;
			//    }
			//    else if (a%2 == 0)
			//    {
			//        Console.WriteLine("not prime"); break;
			//    }


			//    else { Console.WriteLine("not prime"); }
			//}
			#endregion


			#region plandirom
			//my logical 
			//string x = Console.ReadLine();
			//string p= x.Reverse();
			//Console.WriteLine(p);
			//string o = "";



			//for (int i = 0; i < x.Length - 1;)
			//{
			//    for (int j = x.Length - 1; j >= 1; j--)
			//    {
			//        if (x[i] == x[j])
			//        {
			//            o = x.Substring(i + 1, j - 1);
			//        }
			//        if (o.Count() == 1 || o.Count() == 0)
			//        {
			//            Console.WriteLine("plinder"); break;
			//        }


			//        i++;
			//    }
			//    break;
			//}
			//the logical
			//string n= Console.ReadLine();
			//int b = n.Length;
			//bool pn = false;

			//bool v = false;
			//for (int i = 0, j = b - 1; i < 100 && j >= 0; i++, j--)
			//{ 
			//    if (n[j] != '0') {
			//        v = true;
			//    }
			//    if (n[j] == '0' && v == false)
			//    {
			//        continue;
			//    }
			//    Console.Write(n[j]); 
			//   if (n[j] != n[i])
			//    {
			//        pn = true;
			//    }






			//}
			//Console.WriteLine();
			//if (pn==false)
			//{
			//    Console.WriteLine(" plinder");
			//}
			//else 
			//{
			//    Console.WriteLine("npt  plinder");
			//}



			#endregion


			#region tarek
			//Console.WriteLine("enter first number");
			//int firstNum=Convert.ToInt32(Console.ReadLine());
			//Console.WriteLine("enter opperation");
			//string opperation=(Console.ReadLine());
			//Console.WriteLine("enter second number");
			//int secondNum = Convert.ToInt32(Console.ReadLine());


			//if(opperation=="=" && firstNum==secondNum)
			//{ Console.WriteLine("true"); }

			//else if(opperation==">" && firstNum>secondNum)
			//{ Console.WriteLine("true"); }

			//else if (opperation == "<" && firstNum < secondNum)
			//{ Console.WriteLine("true"); }


			//else { Console.WriteLine("false"); }

			#endregion



			#region print prime 1>number
			//int h= int.Parse(Console.ReadLine());


			//for(int i=2; i<=h; i++)
			//{ bool b= false;
			//    for(int j=2; j<i; j++)
			//    {
			//        if(i% j==0)
			//        b = true;
			//    }
			//    if(b==false)
			//    {
			//        Console.Write(i);
			//    }

			//}

			#endregion

			#endregion

			#region ITI tasks
			#region OOP tasks 

			#endregion
			#region LINQ 
			//	List<int> numbers = new List<int>() { 2, 4, 6, 7, 1, 4, 2, 9, 1 };

			//	var num = numbers.Distinct().OrderBy(x => x).ToList();

			//	Console.WriteLine("***********************************************************");

			//	foreach (var item in num)
			//	{
			//		Console.WriteLine(item);

			//	}
			//	Console.WriteLine("***********************************************************");

			//	foreach (var item in num)
			//	{

			//		Console.WriteLine($"Number: {item}, Multiplication: {item * item}");


			//	}
			//	//task2
			//	string[] names = { "Tom", "Dick", "Harry", "MARY", "Jay" };
			//	var nam = from name in names
			//			  where name.Length == 3
			//			  select name;


			//	Console.WriteLine("***********************************************************");


			//	foreach (var item in nam)
			//	{
			//		Console.WriteLine(item);

			//	}
			//	Console.WriteLine("***********************************************************");
			//	var contnam = from name in names
			//				  where name.ToLower().Contains("a")
			//				  orderby name.Length
			//				  select name;

			//	foreach (var item in contnam)
			//	{
			//		Console.WriteLine(item);
			//	}
			//	Console.WriteLine("***********************************************************");

			//	var contnam2 = names.Where(name => name.ToLower().Contains("a")).OrderBy(name => name.Length);

			//	foreach (var result in contnam2)
			//	{
			//		Console.WriteLine(result);
			//	}


			//	Console.WriteLine("***********************************************************");


			//	var takenam = names.Where(name => name.ToLower().Contains("a")).OrderBy(name => name.Length).Take(2);

			//	foreach (var result in takenam)
			//	{
			//		Console.WriteLine(result);
			//	}
			//	Console.WriteLine("***********************************************************");
			//	//task3
			//	List<Student> students = new List<Student>()
			//{
			//	new Student() { ID = 1, FirstName = "Ali", LastName = "Mohammed", Subjects = new Subject[] { new Subject() { Code = 22, Name = "EF" }, new Subject() { Code = 33, Name = "UML" } } },
			//	new Student() { ID = 2, FirstName = "Mona", LastName = "Gala", Subjects = new Subject[] { new Subject() { Code = 22, Name = "EF" }, new Subject() { Code = 34, Name = "XML" }, new Subject() { Code = 25, Name = "JS" } } },
			//	new Student() { ID = 3, FirstName = "Yara", LastName = "Yousf", Subjects = new Subject[] { new Subject() { Code = 22, Name = "EF" }, new Subject() { Code = 25, Name = "JS" } } },
			//	new Student() { ID = 1, FirstName = "Ali", LastName = "Ali", Subjects = new Subject[] { new Subject() { Code = 33, Name = "UML" } } }
			//};


			//	var diction = students.Select(student => $"Fullname: {student.FirstName} {student.LastName} - Number of Subjects: {student.Subjects.Length}");


			//	foreach (var result in diction)
			//	{
			//		Console.WriteLine(result);
			//	}


			//	Console.WriteLine("***********************************************************");






			//	var selstudent = students
			//  .OrderByDescending(student => student.FirstName)
			//  .ThenBy(student => student.LastName)
			//  .Select(student => new { FirstName = student.FirstName, LastName = student.LastName });


			//	foreach (var result in selstudent)
			//	{
			//		Console.WriteLine($" {result.FirstName} {result.LastName}");
			//	}



			//	Console.WriteLine("***********************************************************");


			//	var queryResult = students
			// .SelectMany(student => student.Subjects, (student, subject) => new { student, subject })
			// .Select(result => $"{result.student.FirstName} {result.student.LastName} - Subject: {result.subject.Name}");


			//	foreach (var result in queryResult)
			//	{
			//		Console.WriteLine(result);
			//	}
			#endregion
			#endregion

















			Console.ReadLine();
        }
    }
}
