string[] array1 = new string[] { "hello", "2", "world", ":-)", "1567", "-2", "Russia", "Denmark", "Kazan"};
string[] array2 = new string[array1.Length];

void newArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
newArray(array1, array2);
PrintArray(array2);