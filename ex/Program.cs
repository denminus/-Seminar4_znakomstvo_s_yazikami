//задать массив из 12 элементов, заполненых числами из [-9,9]
//Найти сумму положитеельных и отрицательных элементов массива

/*void Newarray(int[]array)
{
    int len= array.Length;
    int index=0;
    while(index<len)
    {
        array[index]= new Random().Next(-9,10);
        index++;
            }
}
int[] array =new int[12];
Newarray (array);
int sum1=0;
int sum2=0;

for (int i=0; i<array.Length; i++)
{
    if(array[i]<0)
    {
        sum1=sum1+array[i];

    }
    else if (array[i]>0)
    {
        sum2=sum2+array[i];

    }
}
Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"{sum1},{sum2}");
*/

/*Console.Write("Введите длинну массива");
int size=int.Parse(Console.ReadLine()!);
Console.Write("Введите левую часть диапазона");
int min=int.Parse(Console.ReadLine()!);
Console.Write("Введите правую часть диапазона");
int max=int.Parse(Console.ReadLine()!);
int[]array = new int[size];
Random random= new Random();
for (int i=0; i< array.Length; i++)
array[i] = random.Next(min, max+1);
Console.Write("Ваш массив");
for (int i=0; i< array.Length; i++)
Console.Write(array [i] +" ");
Console.WriteLine();
for (int i=0; i< array.Length; i++)
array [i]= -array [i];
Console.Write("изменённый массив ");
for (int i=0; i< array.Length; i++)
Console.Write(array [i] +" ");
*/

/*void PrintArray(int[] array)                // вариант вывода на консоль массива
{
    foreach (int element in array)
    
    Console.Write(element + " ");

    Console.WriteLine();
}

*/

/*void PrintArray(int[] array)              // вариант вывода на консоль массива
{
    for (int i=0; i< array.Length; i++)
    Console.Write(array [i] +" ");
    Console.WriteLine();
}
*/
void PrintArray(int[] array)                     // вариант вывода на консоль массива
{
    Console.Write(String.Join(' ', array));
    Console.WriteLine();
}



int[] CreateArray (int size, int min, int max)
{
    int[]array = new int[size];
    for (int i=0; i< array.Length; i++)    
    array[i] = new Random().Next(min, max+1);
    return array;
}

void ChangeArray(int[] array)
{
    for (int i=0; i< array.Length; i++)
    array [i]= -array [i];
}

void Swap<T> (ref T first, ref T second) // замена значений
{ 
    T tmp =first;
    first = second;
    second = tmp;
}

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int size =ReadInt("Введите длинну массива");
int min =ReadInt("Введите левую часть диапазона");
int max =ReadInt("Введите правую часть диапазона");

/*
Console.Write("Введите длинну массива");
int size=int.Parse(Console.ReadLine()!);
Console.Write("Введите левую часть диапазона");
int min=int.Parse(Console.ReadLine()?? "0");            // для того чтобы не было желтых предупреждений ставится ! или ?? "0"
Console.Write("Введите правую часть диапазона");
int max=int.Parse(Console.ReadLine()!);
*/


if (min>max)
{
    Swap(ref min, ref max);
}

int[] massiv= CreateArray (size, min,max);
Console.Write("Ваш массив");

PrintArray(massiv);
ChangeArray(massiv);
Console.Write("изменённый массив ");
PrintArray(massiv);