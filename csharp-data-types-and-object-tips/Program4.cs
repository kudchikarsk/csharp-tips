using System;
using static System.Console;

namespace csharp_data_types_and_object_tips
{
    [Flags]
    public enum TextStyles
    { 
        Normal = 0,
        Bold = 1,
        Italics = 2,
        Underlined = 4,
        BoldItalics = Bold | Italics
    }

    class Program4
    {
        
        public static void Run(string[] args)
        {
            var style = TextStyles.Bold;
            var text = "Hello world!";
            switch (style)
            {
                case TextStyles.Normal:
                    WriteLine($"<span>{text}<span>");
                    break;

                case TextStyles.Bold:
                    WriteLine($"<b>{text}<b>");
                    break;

                case TextStyles.Italics:
                    WriteLine($"<i>{text}<i>");
                    break;
                case TextStyles.Underlined:
                    WriteLine($"<strike>{text}<strike>");
                    break;
            }
        }
    }
}
