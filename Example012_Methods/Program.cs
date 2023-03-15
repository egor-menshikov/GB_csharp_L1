// Типы методов


// Вид 1: ничего не принимает, ничего не возвращает

void Method1()
{
    Console.WriteLine("Author..");
}
// Method1();

// +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


// Вид 2: что-то принимает, ничего не возвращает

void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg: "Some text");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method21(msg: "Text", count: 5);
// Method21(count: 5, msg: "Text");

// +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


// Вид 3: ничего не принимает, что-то возвращает

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
//Console.WriteLine(year);

// ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


// Вид 4: что-то принимает, что-то возвращает

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result += text;
        i++;
    }
    return result;
}
string res = Method4(6, "hello ");
Console.WriteLine(res);