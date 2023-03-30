// string StringAB(int a, int b)
// {   
//     string answer = string.Empty;
//     for (int i = a; i <= b; i++)
//     {
//         answer += $" {i}";
//     }
//     return answer;
// }

// Console.WriteLine(StringAB(4, 30));

// string NumbersRec(int a, int b)
// {
//     if (a <= b) return NumbersRec(a + 1, b) + $" {a}";
//     else return string.Empty;
// }

// Console.WriteLine(NumbersRec(5, 25));

// int SumRec(int n)
// {
//     if (n > 0) return n + SumRec(n - 1);
//     else return 0;
// }

// Console.WriteLine(SumRec(10));

// int PowerRec(int a, int n)
// {
//     return n == 0 ? 1 : n % 2 == 0 ? PowerRec(a * a, n / 2) : PowerRec(a, n - 1) * a;
// }
// Console.WriteLine(PowerRec(2, 17));

