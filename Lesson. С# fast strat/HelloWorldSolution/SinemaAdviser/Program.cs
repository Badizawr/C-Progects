// написать программу которая поможет подобрать фильм

Console.WriteLine("Эта программа поможет найти фильм, который будет вам по душе.");
Console.WriteLine("Как вас зовут?");
String name = Console.ReadLine();

Console.WriteLine("Здравствуйте," + name);

Console.WriteLine("Фильм какого жанра вы бы хотели посмотреть: комедия, драмма или фантастика");
String gener = Console.ReadLine();

Console.WriteLine("В таком случае, рекомендую посмотреть вам следующие фильмы:");
if (gener.ToLower() == "комедия")
{
    Console.WriteLine("* Иван Васильевич меняет проффесию");
    Console.WriteLine("* Операция 'Ы' и другие приключения Шурика");
    Console.WriteLine("* Мы Миллеры");
    Console.WriteLine("* Почему Он");
    Console.WriteLine("* Брюс всемогущий");
    Console.WriteLine("* Мальчишник в Вегасе");
}
else if (gener.ToLower() == "фантастика")
{
    Console.WriteLine("*Люди икс");
    Console.WriteLine("Железный Человек");
    Console.WriteLine("Тор");
}    
else
{
    Console.WriteLine("* Зелёная миля");
    Console.WriteLine("* Побег из Шоушенга");
    Console.WriteLine("* Красота по-американски");
    Console.WriteLine("* Спасти рядового Раяна");
}

Console.ReadKey();
