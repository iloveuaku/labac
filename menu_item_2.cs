using static System.Net.Mime.MediaTypeNames;

class menu_item_2 : Task
{
    public override void Execute()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Z/X + 7*sqrt(Y)\n");
            Console.Write("z = ");
            input.input_Z();
            if (Test.check_Z())
            {
                break;
            }
            else
            {
                continue;
            }
        }
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Z/X + 7*sqrt(Y)\n");
            Console.WriteLine("z = " + Values.Z);
            Console.Write("y = ");
            input.input_Y();
            if (Test.check_Y())
            {
                break;
            }
            else
            {
                continue;
            }
        }
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Z/X + 7*sqrt(Y)\n");
            Console.WriteLine("z = " + Values.Z);
            Console.WriteLine("y = " + Values.Y);
            Console.Write("x = ");
            input.input_X();
            if (Test.check_X())
            {
                break;
            }
            else
            {
                continue;
            }
        }
        Console.WriteLine("Z/X + 7*sqrt(Y)=" + Values.Z / Values.Y + 7 * Values.X);
    }
}