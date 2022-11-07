class Values
{
    public static string pattern_phone_number = "^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$";
    public static string pattern_email = "[^@ \\t\\r\\n]+@[^@ \\t\\r\\n]+\\.[^@ \\t\\r\\n]+";
    public static string pattern_ip = "(\\b25[0-5]|\\b2[0-4][0-9]|\\b[01]?[0-9][0-9]?)(\\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)){3}";
    public static double Z, Y, X;
    public static int menu_number;
    public static string str_one_copy, str_two_copy, menu_str, strZ, strY, strX, str_one = null, str_two = null, input, menu_message = "[0] Exit\n[1] Hello World!\n[2] Calc: Z/X + 7*sqrt(Y)\n[3]Recursion date\n[4] Strings\n";
    public static DateTime output, startA, endA, startB, endB;
    public static long result;
    public static bool flag, string_comparison_flag;
}