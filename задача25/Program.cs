Console.WriteLine("Введите числа A и B для возведения числа A в степень B");
double A = Convert.ToInt32(Console.ReadLine());
double B = Convert.ToInt32(Console.ReadLine());
double result;
result = Math.Pow(A, B);
Console.WriteLine($"Результат возведения числа {A} в степень {B} равен {result}");