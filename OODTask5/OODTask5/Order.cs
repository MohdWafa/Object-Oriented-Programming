using System;
using System.Text.RegularExpressions;

namespace PictureProduction
{
    class Order
    {
        public string Shape { get; private set; }
        public string Color { get; private set; }
        public string Text { get; private set; }
        public string Operation { get; private set; }

        public bool ValidateTheOrder()
        {
            if (string.IsNullOrEmpty(Shape) || string.IsNullOrEmpty(Color) || string.IsNullOrEmpty(Text) || string.IsNullOrEmpty(Operation))
            {
                Console.WriteLine("Error: Invalid order!");
                return false;
            }
            else if ( !Regex.IsMatch(Shape, @"^[a-zA-Z]+$") || !Regex.IsMatch(Color, @"^[a-zA-Z]+$") || !Regex.IsMatch(Text, @"^[a-zA-Z]+$") || !Regex.IsMatch(Operation, @"^[a-zA-Z]+$"))
            {
                Console.WriteLine("Error: Invalid order!");
                return false;
            }
            
            return true;
        }

        public Order(string shape, string color, string text, string operation)
        {
            Shape = shape;
            Color = color;
            Text = text;
            Operation = operation;
        }
    }
}
