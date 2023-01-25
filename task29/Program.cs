int n= 8;
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Результат: [{string.Join("  ", array)}]");
}