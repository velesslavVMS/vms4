Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int x = n;
int y = 0;
int a=1;
int z = 0;
while(n/a>10)
{
y=((n/a)%10);
z=z+y;
x=x/10;
a =a*10;
}

Console.WriteLine($"X=: {x}");
Console.WriteLine($"Y=: {y}");
Console.WriteLine($"Z=: {z}");
Console.WriteLine($"a=: {a}");
Console.WriteLine($"Результат: {z+x}");