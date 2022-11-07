class menu_item_3 : Task
{
    public override void Execute()
    {
        Console.Clear();
        do
        {
            Console.WriteLine("Введите начало первого промежутка в формате дд.мм.гггг");
            Values.startA = input.GetDate();
            Console.WriteLine("Введите конец первого промежутка в формате дд.мм.гггг");
            Values.endA = input.GetDate();
            Console.WriteLine("Неправильный промежуток. Попробуй еще!");
        } while (Values.startA.CompareTo(Values.endA) > 0);
        Console.Clear();
        do
        {
            Console.WriteLine("Введите начало второго промежутка в формате дд.мм.гггг");
            Values.startB = input.GetDate();
            Console.WriteLine("Введите конец второго промежутка в формате дд.мм.гггг");
            Values.endB = input.GetDate();
            Console.WriteLine("Неправильный промежуток. Попробуй еще!");
        } while (Values.startB.CompareTo(Values.endB) > 0);
        Console.Clear();
        Console.WriteLine(Values.startA.ToString("Первый промежуток dd.MM.yyyy - "));
        Console.WriteLine(Values.endA.ToString("                  dd.MM.yyyy"));
        Console.WriteLine(Values.startB.ToString("Второй промежуток dd.MM.yyyy - "));
        Console.WriteLine(Values.endB.ToString("                  dd.MM.yyyy"));
        TimeSpan N = Values.startB - Values.startB;
        if (Values.endB < Values.startA || Values.startB > Values.endA)
        {
            Console.WriteLine($"N = {N.Days}");
        }
        if (Values.startB > Values.startA && Values.startB < Values.endA)
        {
            if (Values.endB > Values.endA)
            {
                N = Values.endA - Values.startB;
                Console.WriteLine($"N = {N.Days + 1}");

            }
            else
            {
                N = Values.endB - Values.startB;
                Console.WriteLine($"N = {N.Days + 1}");

            }
        }
        if (Values.startB < Values.startA && Values.endB > Values.startA)
        {
            if (Values.endB > Values.endA)
            {
                N = Values.endA - Values.startA;
                Console.WriteLine($"N = {N.Days + 1}");
            }
            else
            {
                N = Values.endB - Values.startA;
                Console.WriteLine($"N = {N.Days + 1}");

            }

        }
        if (N.Days > 0)
            Values.result = N.Days + 1;
    }
}