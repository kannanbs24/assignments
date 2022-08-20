
/*
int number1, number2, temp;
Console.WriteLine("enter the first number");
number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter the second number");
number2 = Convert.ToInt32(Console.ReadLine());
temp = number1;
number1 = number2;
number2 = temp;
Console.WriteLine("\nAfter Swapping : ");
Console.WriteLine("\nFirst Number : " + number1);
Console.WriteLine("\nSecond Number : " + number2);
*/            //1

/*   double d1, d2, d3;
   Console.WriteLine("enter the first number");
   d1=Convert.ToDouble(Console.ReadLine());
   Console.WriteLine("enter the second number");
   d2 = Convert.ToDouble(Console.ReadLine());
   Console.WriteLine("enter the third number");
   d3 = Convert.ToDouble(Console.ReadLine());
   double ans;
   ans = d1 * d2 * d3;
   Console.WriteLine("multiplication of three numbers is"+" "+ans); */   //2

/*double firstno, secondno, result;
Console.WriteLine("enter the first no");
firstno=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("enter the second no");
secondno=Convert.ToDouble(Console.ReadLine()); 



result = firstno + secondno;
Console.WriteLine("{0} + {1} = {2}", firstno, secondno, result);

 result = firstno - secondno;
Console.WriteLine("{0} - {1} = {2}", firstno, secondno, result);

result = firstno * secondno;
Console.WriteLine("{0} * {1} = {2}", firstno, secondno, result);

result = (firstno)/(secondno);
Console.WriteLine("{0} / {1} = {2}", firstno, secondno, result);

int num1, num2, rem;
Console.WriteLine("enter the num1");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter the num2");
num2 = Convert.ToInt32(Console.ReadLine());
rem = num1 % num2;
Console.WriteLine("{0} % {1} = {2}", num1, num2, rem);  */   //3


/*float f1, f2, f3, f4;
Console.WriteLine("enter the first no");
f1=Convert.ToSingle(Console.ReadLine());
Console.WriteLine("enter the second no");
f2=Convert.ToSingle(Console.ReadLine());
Console.WriteLine("enter the third no");
f3=Convert.ToSingle(Console.ReadLine());
Console.WriteLine("enter the fourth no");
f4=Convert.ToSingle(Console.ReadLine());

double sum = f1 + f2 + f3 + f4;
double ans = sum / 4;
Console.WriteLine("the average of four numbers is"+" "+ans); */  //4


/*int x, y, z;
Console.WriteLine("enter the first no");
x=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter the second no");
y=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter the third no");
z=Convert.ToInt32(Console.ReadLine());

int ans1 = (x + y) * z;
int ans2 = x * y + y * z;
Console.WriteLine("the value of (x+y).z"+" "+ans1);
Console.WriteLine("the value of x.y+y.z"+" "+ans2); */   //5

/* int age;
Console.WriteLine("enter the age");
age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("you are looking older than"+" " +age); */   //6


/*Console.WriteLine("Enter the number: ");
int a = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write("{0} ", a);
    }
    Console.Write("\n");
    for (int j = 0; j < 4; j++)
    {
        Console.Write("{0}", a);
    }
    Console.Write("\n");
} 
*/    //7
/*int x;

Console.WriteLine("Enter a number: ");
x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("{0}{0}{0}", x);
Console.WriteLine("{0} {0}", x);
Console.WriteLine("{0} {0}", x);
Console.WriteLine("{0} {0}", x);
Console.WriteLine("{0}{0}{0}", x);

*/           //8

/* Console.WriteLine("Enter the amount of Celsius: ");
int celsius = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Kelvin = {0}", celsius + 273);
Console.WriteLine("Fahrenheit = {0}", celsius * 18 / 10 + 32); */     //9

/*Console.WriteLine("\nInput first integer:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second integer:");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Check if one is negative and one is positive:");
Console.WriteLine((x < 0 && y > 0) || (x > 0 && y < 0)); */     //10

/*Console.WriteLine("\nInput first integer:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second integer:");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Check if one is negative and one is positive:");
Console.WriteLine((x > 0 && y > 0));  */    //11

/*string s1 = "Hello C#";
string s2 = "";
bool b1 = string.IsNullOrEmpty(s1);
bool b2 = string.IsNullOrEmpty(s2);
Console.WriteLine(b1);
Console.WriteLine(b2); */    //12




/*double meter;
double km = 0;
Console.WriteLine("enter the meter");
meter=Convert.ToDouble(Console.ReadLine());
km = meter / 1000;
Console.WriteLine(km+"km"); */ //13

/* double fahrenheit;

double celsius;
Console.WriteLine("enter the value of celsius");
celsius=Convert.ToDouble(Console.ReadLine());

fahrenheit = (celsius * 9) / 5 + 32;
Console.WriteLine("Fahrenheit: " + fahrenheit);   */   //14

/* double usd = 0;
double inr = 0;
double value = 0;

Console.WriteLine("Enter amount in USD: ");
usd = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the USD value :");
value = Convert.ToDouble(Console.ReadLine());

inr = usd * value;
Console.WriteLine("USD " + usd + "-> INR " + inr);  */  //15 

/* string first_name;
string last_name;
Console.WriteLine(  "enter the first name");
first_name = Console.ReadLine();
Console.WriteLine("enter the last name");
last_name = Console.ReadLine();
if(first_name=="userid" && last_name=="password")
{
    Console.WriteLine("user has succesfully login in");
    Console.WriteLine("welcome to my app");
}
else
{
    Console.WriteLine("incorrect first_name and password");
}

*/                    //16
