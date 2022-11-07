using static System.Net.Mime.MediaTypeNames;

class Menu:Task
{
    public override void Execute()
    {
        switch (Values.menu_number)
        {
            case 0:
                {
                    Environment.Exit(0);
                    break;
                }
            case 1:
                {
                    Console.Clear();
                    new menu_item_1().Execute();
                    break;
                }
            case 2:
                {
                    Console.Clear();
                    new menu_item_2().Execute();
                    break;
                }
            case 3:
                {
                    Console.Clear();
                    new menu_item_3().Execute();
                    if ((Test.Time_Check(Values.result)) > 3000)
                    {
                        Console.Clear();
                        Console.WriteLine("Работа длится больше трёх секунд((((");

                    }
                    else
                    {
                        if (Test.IsPowerOfTwo(Values.result) == true)
                        {
                            Console.WriteLine("YES");
                        }
                        else
                            Console.WriteLine("NO");
                    }
                    break;
                }
            case 4:
                {
                    Console.Clear();
                    new menu_item_4().Execute();
                    break;
                }
            default:
                {
                    Console.WriteLine("Такой команды не существует, попробуйте снова\n");
                    return;
                }
        }
    }
}