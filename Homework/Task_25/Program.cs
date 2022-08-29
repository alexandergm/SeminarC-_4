Console.Write("Введите 1ое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2ое число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Function());

string Function()
{
    var x = Math.Pow(a,b);
    return $"Число {a} в степени {b} = {x}";
}