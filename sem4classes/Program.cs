/* String(char)

string? stroka = Console.ReadLine();
Console.WriteLine(Convert.ToInt32(stroka[0].ToString()) * 10);*/

  /*ДЛЯ УКАЗАНИЯ, ЧТО НЕ СОБИРАЕМСЯ ВВОДИТЬ нулль, ПОСЛЕ СЛОВА СТРОКА СТАВИМ "?"

НУМЕРАЦИЯ В СТРОКАХ, КАК И В МАССИВАХ, НАЧИНАЕТСЯ С НУЛЯ:
 0, 1 , 2, 3 ... N-1

char - это обозначение символьных данных. При переводе символа в число 
выдается его номер в системе кодировки UTF-8.

Поэтому переводим не в символы, а в строку. Используем функцию ToString()):
string? stroka = Console.ReadLine();
Console.WriteLine(Convert.ToInt32(stroka[1].ToString()));
[1] - это номер 2-го элемента массива*/

/*Как вводить сам массив?


Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
   // array[i] = new Random().Next(-10, 11); // [-10, 10]
//array[i] = 1; 2; -так писать нельзя. А как надо?
Console.WriteLine($"Результат: [{string.Join("  ", array)}]");

Для вывода элементов массива */
/*Console.Write("Введите 8 элементов массива: ");
string = 
int n = Convert.ToInt32(Console.ReadLine());*/

int n= 8;
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Результат: [{string.Join("  ", array)}]");
}
   // array[i] = new Random().Next(-10, 11); // [-10, 10]
//array[i] = 1; 2; -так писать нельзя. А как надо?



/*Функция передачи по ссылке:  используется только при работе с переменными
В нашем случае мы обращаясь к элементам массива по номеру элемента,
 автоматически обращаемся к ячейке памяти, где находится этот эл-т. 
 Поэтому ф-ия передачи по ссылке нам пока не нужна.
void f(ref int n)
{
    n=n+5;
}

int n = 10;
f(ref n);
Console.WriteLine(n);*/
