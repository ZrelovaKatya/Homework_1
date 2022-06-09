Console.WriteLine ("Введите число: ");
string input = Console.ReadLine ();
int number = Convert.ToInt32(input);

if (number % 2 == 0)
{
   Console.WriteLine ("Четное"); 
}
else
{
    Console.WriteLine ("Нечетное");
}
