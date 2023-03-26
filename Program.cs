string[] array1;
Console.WriteLine("Введите массив строк через запятую");
string stroka = Console.ReadLine();
array1 = stroka.Split(',');

string[] array2 = new string[array1.Length];

int count = 0;
for (int i = 0; i < array1.Length; i++)
{
if(array1[i].Length <= 3)
    {
    array2[count] = array1[i];
    count++;
    }
}
PrintArray(array2);

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}