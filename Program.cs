// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N включительно.
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int x=0;

while ( x < N )
{
    x = x + 2;
    
    Console.Write("Четные числа: ");
    Console.WriteLine(x);
}
