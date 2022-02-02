Console.Write("Введите имя пользователя: ");
string username = Console.WriteLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же МАША");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}