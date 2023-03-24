int Fibo(int num)
{
    if (num == 1 || num == 2) return 1;
    if (num == 0) return 0;
    else return Fibo(num - 1) + Fibo(num - 2);
}

for (int i = 0; i <= 50; i++)
{
    Console.Write($"{i}   ");
    Console.WriteLine(Fibo(i));
}
