Console.WriteLine("Введите число для получения суммы его цифр");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = n; i > 0; i = i / 10)
{
sum = sum + i % 10;
}
Console.WriteLine(sum);