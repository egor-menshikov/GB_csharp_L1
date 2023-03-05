Console.Write("Please enter username: ");
string username = Console.ReadLine();

if(username.ToLower() == "mary")
{
    Console.WriteLine("Wow, it's Mary herself!");
}
else
{
    Console.Write("Hello ");
    Console.WriteLine(username);
}