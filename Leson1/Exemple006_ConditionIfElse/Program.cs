//Особое приветствие пользователя "Маша"

Console.Write("Введите имя пользователя: ");
string username  = Console.ReadLine();

if(username.ToLower() == "маша") //добавили оператор ".ToLower()" не учитывает регистр
{
     Console.WriteLine("Ура, это же МАША!!!");
}
else
{
    Console.WriteLine("Привет," + username);
}
