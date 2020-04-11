using System;
using static System.Console;

namespace csharp_data_types_and_object_tips
{
    class Program5
    {

        public static void Run(string[] args)
        {
            var style = TextStyles.Bold | TextStyles.Underlined;
            var text = "Hello world!";
            if (style.HasFlag(TextStyles.Normal))
            {
                text = $"<span>{text}<span>";
            }

            if (style.HasFlag(TextStyles.Bold))
            {
                text = $"<b>{text}<b>";
            }

            if (style.HasFlag(TextStyles.Italics))
            {
                text = $"<i>{text}<i>";
            }

            if (style.HasFlag(TextStyles.Underlined))
            {
                text = $"<strike>{text}<strike>";
            }

            WriteLine(text);
        }
    }
}
