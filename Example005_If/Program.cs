Console.WriteLine("Введите имя пользователя:");
string username = Console.ReadLine();

if(username.ToLower() == "софи")
{
    Console.WriteLine("Ура,это же Софи");
}
else
{
    Console.Write("Привет,");
    Console.WriteLine(username);
}