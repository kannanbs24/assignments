/* int a;
int b;
int min;
int max;
Console.WriteLine("Enter first number : ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number: ");
b = Convert.ToInt32(Console.ReadLine());
if (a > b)
    max = a;
else
    max = b;

if (a < b)
    min = a;
else
    min = b;

Console.WriteLine("Minimum number = {0}", min);
Console.WriteLine("Maximum number = {0}", max); */    //1

/*  int a;
int b;
int c;
int large;
Console.WriteLine("Enter first number : ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number: ");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter third number : ");
c = Convert.ToInt32(Console.ReadLine());

if (a > b && a > c)
    large = a;
else if (b > a && b > c)
    large = b;
else large = c;
Console.WriteLine("Largest number is {0}", large);  */    //2

/* char c1, c2;

Console.WriteLine("Enter the first character : ");
c1 = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Enter the second character : ");
c2= Convert.ToChar(Console.ReadLine());

if (c1 == c2)
    Console.WriteLine("Both characters are equal");
else
    Console.WriteLine("Characters are not equal"); */    //3


/* string s1 = "kannan";
string s2;



Console.WriteLine("Enter the second string : ");
s2 = Console.ReadLine();

if (s1.Equals(s2))

    Console.WriteLine("Both string are equal");
else
    Console.WriteLine("string are not equal"); */ //4

/* int firstNumber, secondNumber;
Console.WriteLine("Enter the first number : ");
firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number : ");
secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber > secondNumber)
{
 Console.WriteLine("First number is greater than the second number");
}
else
{
 Console.WriteLine("First number is smaller than the second number");
}    */               //5

/* int year;
Console.WriteLine("Enter the Year :");
year = Convert.ToInt32(Console.ReadLine());
if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
    Console.WriteLine("{0} is Leap Year", year);
else
    Console.WriteLine("{0} is not a Leap Year", year); */        //6

/* int a, b, c;
Console.WriteLine("enter the first subject");
a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter the second subject");
b=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter the third subject");
c=Convert.ToInt32(Console.ReadLine());
int tot_mark = a + b + c;
Console.WriteLine("total_marks="+" "+tot_mark);
float per = tot_mark / 3;
if(per<35)
{
    Console.WriteLine("fail");
}
else if(per>35 && per<45)
{
    Console.WriteLine("third ");
}
else if (per > 45 && per < 60)
{
    Console.WriteLine("second ");
}
else
{
    Console.WriteLine("first");
}  */                       //7


/* Console.Write("Enter number of rows :");
int rows = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= rows; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine("\n");
}  */   //8

/*  int i, n, sum = 0;
Console.WriteLine("Input number of terms : ");
n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\nThe odd numbers are :");
for (i = 1; i <= n; i++)
{
    Console.Write("{0} ", 2 * i - 1);
    sum += 2 * i - 1;
}
Console.WriteLine("\nThe Sum of odd Natural Number upto {0} terms : {1} \n", n, sum); */ //9

/* int n, reverse = 0, rem;
Console.Write("Enter a number: ");
n = Convert.ToInt32(Console.ReadLine());
while (n != 0)
{
    rem = n % 10;
    reverse = reverse * 10 + rem;
    n /= 10;
} 
Console.Write("Reversed Number: " + reverse);   */       //10

/* int sum = 0;
for (int i = 100; i <= 200; i++)
{
    
    sum = sum + i;
}
Console.WriteLine("the sum of 100 to 200 is"+" "+sum);  */   //11

/* int sum = 0;
for (int i = 100; i <= 200; i++)
{

    if (i % 9 == 0)
    {
        Console.WriteLine("{0}  ", i);
        sum += i;
    }
}
    Console.WriteLine("the sum of 100 to 200 is,divisible by 9" + " " + sum); */ //12

/* int n;
Console.WriteLine("enter the inuput");
n=Convert.ToInt32(Console.ReadLine());  
if(n!=0)
{
   if(n%2==0)
    {
        Console.WriteLine("given input is even");
    }
    else
    {
        Console.WriteLine("given input is odd");
    }
   
}
else
{
    Console.WriteLine("given input is zero");
}
*/                        //13

/* int n;
Console.WriteLine("enter the inuput");
n = Convert.ToInt32(Console.ReadLine());

switch(n==0)
{
    case true:
        Console.WriteLine("given inuput is zero");
        break;

    case false:
        if (n % 2 == 0)
        {
            Console.WriteLine("given input is even");
        }
        else
        {
            Console.WriteLine("given input is odd");
        }
        break;

}
   */                        //14

/* for (int i = 1, j = 25; i <= j; i++, j--)
{
   Console.WriteLine("i ={0} and j = {1}", i, j);
}
Console.WriteLine("Crossed Over");   */     //15


/* int score = 100;
string input;
Console.WriteLine("enter the given input hit or miss");

for(int i=0;i<=3;i++)
{
    input = Console.ReadLine();
    if (input=="hit")
    {   
        score += 10;
    }
    else if(input=="miss")
    {
        score -= 20;
    }
}
Console.WriteLine(score);  */    //16