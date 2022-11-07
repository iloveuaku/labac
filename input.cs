class input
{
    public static void input_menu_number()
    {
        Values.menu_str = Console.ReadLine();
    }
    public static void input_Z()
    {
        Values.strZ = Console.ReadLine();
    }
    public static void input_Y()
    {
        Values.strY = Console.ReadLine();
    }
    public static void input_X()
    {
        Values.strX = Console.ReadLine();
    }
    public static DateTime GetDate()
    {
        do
        {
            Values.input = Console.ReadLine();
            Console.WriteLine("Неверный ввод! Введите дату в формате дд.мм.гггг");
        } while (!DateTime.TryParse(Values.input, out Values.output));
        Console.Clear();
        return Values.output;
    }
    public static void str1()
    {
        Console.Write("str1 = ");
        Values.str_one = Console.ReadLine();
    }
    public static void str2()
    {
        Console.Write("str2 = ");
        Values.str_two = Console.ReadLine();
    }
}