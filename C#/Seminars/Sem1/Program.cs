System.Console.WriteLine("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if(num1 == num2 * num2)
{
    System.Console.WriteLine($"{num1} is quad of {num2}");
} else
{
   System.Console.WriteLine($"{num1} is not quad of {num2}"); 
}