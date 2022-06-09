Console.WriteLine ("Введите первое число: ");
string input1 = Console.ReadLine ();
int number1 = Convert.ToInt32(input1);

Console.WriteLine ("Введите второе число: ");
string input2 = Console.ReadLine ();
int number2 = Convert.ToInt32(input2);

Console.WriteLine ("Введите третье число: ");
string input3 = Console.ReadLine ();
int number3 = Convert.ToInt32(input3);

int max = number1;

if (number1 > max ) max = number1;
if (number2 > max ) max = number2;
if (number3 > max ) max = number3;


Console.Write("max = ");
Console.WriteLine(max);