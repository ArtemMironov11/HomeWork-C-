string RandomDay = Console.ReadLine();

switch (RandomDay)
{
    case "6":
        Console.WriteLine("Да! Выходной - суббота!");
        break;
    case "7":
        Console.WriteLine("Да! Выходной - воскресенье!");
        break;

    default:
        Console.WriteLine("Нет. Еще работаем - будний день.");
        break;
}
