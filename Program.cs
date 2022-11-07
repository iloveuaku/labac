using static System.Net.Mime.MediaTypeNames;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {

            Console.WriteLine(Values.menu_message);
            input.input_menu_number();
            if (Test.check_menu_number() == true)
            {
                Menu a = new Menu();
                a.Execute();

            }
            else
                Console.WriteLine("Такой команды не существует, попробуйте снова\n");
        }
    }

}