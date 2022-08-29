Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int tmp = 0;
int sum = 0;
Console.WriteLine(Sum());

string Sum()
{    
    while (a > 0)
    {       
        tmp = a % 10;        
        sum = sum + tmp;
        a = a /10;        
    }
    return $"Сумма цифр в числе = {sum}";
}