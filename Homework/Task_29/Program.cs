Console.WriteLine("Введите количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
FillArray();
Console.WriteLine(PrintArray());

void FillArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
}
string PrintArray()
{
    string result = String.Empty;
    foreach(int x in array)
    {
       result = result + x + " ";
    }
    return result;
}

