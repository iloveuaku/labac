
using System.Text.RegularExpressions;

class ValidationException : Exception
{
    public static void withoutREG()
    {
        try
        {
            if (Values.str_one_copy.CompareTo(Values.str_two_copy) == 0)
            {
                throw new Exception("Строчки совпадают посимвольно, если привести к одному регистру, удалить пробелы в начале и в конце + дублирование пробелов");
            }
            else
                throw new Exception("Строчки не совпадают посимвольно, если привести к одному регистру, удалить пробелы в начале и в конце + дублирование пробелов");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
    public static void matchcharacterbycharacter()
    {
        try
        {
            Values.string_comparison_flag = false;
            if (Values.str_one.Length == Values.str_two.Length)
            {
                for (int i = 0; i < Values.str_one.Length; i++)
                {
                    if (Values.str_one[i] == Values.str_two[i])
                    {
                        Values.string_comparison_flag = true;
                    }
                    else
                    {
                        Values.string_comparison_flag = false;
                    }
                }
            }
            if (Values.string_comparison_flag == true)
            {
              throw new Exception("Строчки равны");
            }
            else
                throw new Exception("Строчки не равны");
        }
        catch (Exception a)
        {
            Console.WriteLine(a.Message);
        }
    }
    public static void reversestrings()
    {
        try
        {
            var str_one_copy1 = Values.str_one;
            Values.str_two_copy = Values.str_two;
            Values.str_one_copy = new string(str_one_copy1.Reverse().ToArray());

            if (Values.str_one_copy.CompareTo(Values.str_two_copy) == 0)
            {
                throw new Exception("Строка является перевертышем\n");
            }
            else
            {
                throw new Exception("Строка не является перевертышем\n");
            }
        }
        catch(Exception b)
        {
            Console.WriteLine(b.Message);
        }
    }
    public static void numbermailipstr1()
    {
        try 
        {
            bool flag = false;
            Values.str_one_copy = Values.str_one;
            if (Regex.IsMatch(Values.str_one_copy, Values.pattern_phone_number, RegexOptions.IgnoreCase))
            {
               throw new Exception("Первая строка является номером телефона\n");
                flag = true;
            }
            if (Regex.IsMatch(Values.str_one_copy, Values.pattern_email, RegexOptions.IgnoreCase))
            {
                throw new Exception("Первая строка является email'ом\n");
                flag = true;
            }
            if (Regex.IsMatch(Values.str_one_copy, Values.pattern_ip, RegexOptions.IgnoreCase))
            {
                throw new Exception("Первая строка является  IP-адресом\n");
                flag = true;
            }
            if (!flag)
            {
                throw new Exception("Первая строка не является номером телефона, email'ом, IP-адресом\n");
            }
        }
        catch(Exception c)
        {
            Console.WriteLine(c.Message);
        }
    }
    public static void numbermailipstr2()
    {
        try 
        {
            bool flag2 = false;
            Values.str_two_copy = Values.str_two;
            if (Regex.IsMatch(Values.str_two_copy, Values.pattern_phone_number, RegexOptions.IgnoreCase))
            {
                throw new Exception("Вторая строка является номером телефона\n");
                flag2 = true;
            }
            if (Regex.IsMatch(Values.str_two_copy, Values.pattern_email, RegexOptions.IgnoreCase))
            {
                throw new Exception("Вторая строка является email'ом\n");
                flag2 = true;
            }
            if (Regex.IsMatch(Values.str_two_copy, Values.pattern_ip, RegexOptions.IgnoreCase))
            {
                throw new Exception("Втораястрока является  IP-адресом\n");
                flag2 = true;
            }
            if (!flag2)
            {
                throw new Exception("Вторая строка не является номером телефона, email'ом, IP-адресом\n");
            }
        }
        catch(Exception d)
        {
            Console.WriteLine(d.Message);
        }
    }
}