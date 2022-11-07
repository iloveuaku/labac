using System.Text.RegularExpressions;

class menu_item_4 : Task
{
    public override void Execute()
    {
        Console.Clear();
        input.str1();
        input.str2();
        Values.str_one_copy = Values.str_one;
        Values.str_two_copy = Values.str_two;
        Values.str_one_copy = Values.str_one.Trim();
        Values.str_two_copy = Values.str_two.Trim();
        Values.str_one_copy = Values.str_one_copy.ToLower();
        Values.str_two_copy = Values.str_two_copy.ToLower();
        Values.str_one_copy = Values.str_one_copy.Replace("  ", " ");
        Values.str_two_copy = Values.str_two_copy.Replace("  ", " ");
        ValidationException.matchcharacterbycharacter();
        ValidationException.withoutREG();
        ValidationException.reversestrings();
        ValidationException.numbermailipstr1();
        ValidationException.numbermailipstr2();
    }

}