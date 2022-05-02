//Напишите программу, которая будет выдавать название дня недели по заданному номеру.

Console.Write("Введите порядковое число дня недели -> ");
string DayOfWeek = Console.ReadLine();
switch (DayOfWeek)
{
    case "1":
        Console.WriteLine("Сегодня понедельник. Сожалею!");
        break;
    case "2":
        Console.WriteLine("Сегодня вторник. Желаю удачи!");
        break;
    case "3":
        Console.WriteLine("Сегодня среда. Бывало и лучше!");
        break;
    case "4":
        Console.WriteLine("Сегодня четверг. Держитесь! Осталось совсем немного!");
        break;
    case "5":
        Console.WriteLine("Сегодня пятница. Ю-хуууу!");
        break;
    case "6":
        Console.WriteLine("Сегодня суббота. Поздравляю! Вы пережили эту неделю!");
        break;
    case "7":
        Console.WriteLine("Сегодня воскресенье. Готовьтесь к следующей неделе!");
        break;
     default:
        Console.WriteLine("Не понятно т.т");
        break;
}
