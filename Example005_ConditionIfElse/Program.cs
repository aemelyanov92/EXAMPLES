Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if(username.ToLower() == "прохор")
{
    Console.WriteLine("Прохор, индеец ты такой, ёб твою мать");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}