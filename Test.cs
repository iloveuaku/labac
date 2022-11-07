using System.Diagnostics;

class Test
{
    public static bool check_Z()
    {
        if (double.TryParse(Values.strZ, out Values.Z))
            return true;
        else
        {
            return false;
        }
    }
    public static bool check_X()
    {
        if (double.TryParse(Values.strX, out Values.X) && Values.X != 0)
            return true;
        else
        {
            return false;
        }
    }
    public static bool check_Y()
    {
        if (double.TryParse(Values.strY, out Values.Y) && Values.Y >= 0)
            return true;
        else
        {
            return false;
        }
    }
    public static bool check_menu_number()
    {
        if (int.TryParse(Values.menu_str, out Values.menu_number))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static public long Time_Check(in long result)
    {
        long n = result;
        var sw = new Stopwatch();
        sw.Reset();
        sw.Start();
        IsPowerOfTwo(n);
        sw.Stop();
        return sw.ElapsedMilliseconds;
    }
    public static bool IsPowerOfTwo(in long n)
    {
        if (n == 1)
            return true;
        else
        if (n > 1 && n < 2 || n % 2 != 0 || n == 0)
            return false;
        else
            return IsPowerOfTwo(n / 2);
    }
}