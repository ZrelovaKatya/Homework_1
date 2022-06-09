Console.WriteLine ("Введите число: ");
string input = Console.ReadLine ();
int number = Convert.ToInt32(input);
int min = number / number + 1;
int max = number;

while (min <= max)
{
    Console.Write(min + " ");
    min = min + 2;
}