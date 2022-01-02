using System;
using System.Text.RegularExpressions;

namespace PictureProduction
{
    interface IPicture
    {
        string LeftFrame { get; set; }
        string RightFrame { get; set; }
        string Color { get; set; }
        string Text { get; set; }
        bool IsPrintable { get; set; }

        void Print();
    }

    public class Picture : IPicture
    {
        public string LeftFrame { get; set; }
        public string RightFrame { get; set; }
        public string Color { get; set; }
        public string Text { get; set; }
        public bool IsPrintable { get; set; }

        public void Print()
        {
            if(IsPrintable)
            {
                if (Machine.p == Production.SimpleProduction)
                    Console.WriteLine($"{LeftFrame}{LeftFrame}{Color}{RightFrame}{RightFrame} {Text} {LeftFrame}{LeftFrame}{Color}{RightFrame}{RightFrame}");
                else
                {
                    if (string.IsNullOrEmpty(Color) && Regex.IsMatch(Text, @"^(\w\s)*$"))
                    {
                        Console.WriteLine($"{LeftFrame}{LeftFrame}{LeftFrame}{Color}{RightFrame}{RightFrame}{RightFrame} {Text} {LeftFrame}{LeftFrame}{LeftFrame}{Color}{RightFrame}{RightFrame}{RightFrame}");

                    }
                    else if (string.IsNullOrEmpty(Color) || Regex.IsMatch(Text, @"^(\w\s)*$"))
                    {
                        Console.WriteLine($"{LeftFrame}{LeftFrame}{Color}{RightFrame}{RightFrame} {Text} {LeftFrame}{LeftFrame}{Color}{RightFrame}{RightFrame}");
                    }
                    else
                    {
                        Console.WriteLine($"{LeftFrame}{Color}{RightFrame} {Text} {LeftFrame}{Color}{RightFrame}");
                    }
                }
            }
        }
    }


}
