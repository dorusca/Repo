/* прогорамма запрашивает имя пользователя, но любимчика приветствует особенно.*/



Console.WriteLine("Введите ваше имя: ");
string username = Console.ReadLine ();

if (username == "маша")
{
    Console.WriteLine ("Ура, это же Мария!");
}
else 
{
Console.Write("Привет, ");
Console.WriteLine (username);
}

