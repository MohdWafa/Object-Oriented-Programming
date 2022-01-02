using System;
using System.Collections.Generic;

namespace PictureProduction
{
     enum Production { SimpleProduction, ComplexProduction };

    class Program
    {

        private readonly static Order[] orders =
        {
            new Order("circle", "red", "Hello", "spacing"),
            new Order("square", "green", "HelloWorld", "spacing"),
            new Order("triangle", "blue", "ChainIsBeauty", "spacing"),

            new Order("circle", "red", "Hello", "uppercase"),
            new Order("square", "green", "HelloWorld", "uppercase"),
            new Order("triangle", "blue", "ChainIsBeauty", "uppercase"),

            new Order("circle", "red", "Hello", "lowercase"),
            new Order("square", "yellow", "HelloWorld", "lowercase"),
            new Order("hash", "red", "ChainIsBeauty", "uppercase"),

            new Order("", "green", "ChainIsBeauty", "uppercase"), //invalid order
            new Order("star", "1234", "ChainIsBeauty", "uppercase"), //invalid order
            new Order("star", "green", null, "uppercase"), //invalid order
        };
        
        static void ProducePictures(IEnumerable<Order> orders, Production production)
        {
            Machine m1 = new ColorMachine();
            Machine m2 = new TextMachine();
            Machine m3 = new ShapeMachine();

            Machine.p = production;

            m1.SetNextMachine(m2);
            m2.SetNextMachine(m3);

            foreach (var order in orders)
            {
                if (order.ValidateTheOrder())
                {
                    Picture pic = new Picture();
                    m1.Handle(order, pic);
                    pic.Print();
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("--- Simple Production Line ---");
            ProducePictures(orders, Production.SimpleProduction);

            Console.WriteLine();
            
            Console.WriteLine("--- Complex Production Line ---");
            ProducePictures(orders, Production.ComplexProduction);
            
        }
    }
}
