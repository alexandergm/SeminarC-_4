Console.WriteLine("Введите количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
int tmp = 0;
int count = 0;
FillArray();
Console.WriteLine(PrintArray());
Console.WriteLine(Sort());
Console.WriteLine(Mediana());

void FillArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
}
string Sort()
{
    string result = String.Empty;
    for(int i=0; i<array.Length; i++)
        for(int j = i+1; j < array.Length; j++)
            if (array[i] < array[j])
            {
                tmp = array[j];
                array[j] = array[i];
                array[i] = tmp;
            } 
    foreach (int x in array) 
    {
        result = result + x + " ";
    }
    return $"Массив отсортированный от max к min = {result}";
}
string Mediana()
{    
    for(int i = 0; i < (array.Length / 2) + 1; i++)
    {        
        count = i;
    }
    if (array.Length % 2 == 0)
    {
        count = (array[count] + array[count - 1]) / 2;
    }    
    else count = array[count];
    return $"Медианное значение = {count}";
}
string PrintArray()
{
    string result = String.Empty;
    foreach(int x in array)
    {
       result = result + x + " ";
    }
    return $"Сгенерированный массив = {result}";
}

