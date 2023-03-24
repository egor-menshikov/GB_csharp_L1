double Fact(int num)
{
    if (num == 1) return 1;
    else return num * Fact(num - 1);
}

for (int i = 1; i <= 40; i++)
{
    Console.Write($"{i}   ");
    Console.WriteLine(Fact(i));
}
