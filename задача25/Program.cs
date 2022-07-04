Console.WriteLine("Введите числа a и b для возведения числа a в степень b");
long a = Convert.ToInt32(Console.ReadLine());
long b = Convert.ToInt32(Console.ReadLine());
long power(long a, long b) {
    long result = 1;

    for(long i = 0; i < b; i++) {
        result *= a;
    }

    return result;
}
long res = power(a, b);
Console.WriteLine($"Число {a} возведенное в степень {b} равно {res}");