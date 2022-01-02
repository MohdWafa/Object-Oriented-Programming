using System;

namespace PictureProduction
{
    interface IMachine
    {
        // you can add required methods here
        void Handle(Order order, IPicture picture);
    }
    
    abstract class Machine : IMachine
    {
        protected Machine next;
        static public Production p;

        public void SetNextMachine(Machine machine)
        {
            this.next = machine;
        }


        public abstract void Handle(Order order, IPicture picture);
    }
    class ColorMachine : Machine
    {
        
        public override void Handle(Order order, IPicture picture)
        {
            picture.IsPrintable = true;

            if (Machine.p == Production.SimpleProduction)
            {
                if (order.Color == "red")
                    picture.Color = order.Color;
                else
                    picture.Color = "";
            }
            else
            {
                if (order.Color == "red" || order.Color == "green" || order.Color == "blue")
                    picture.Color = order.Color;
                else
                    picture.Color = "";
            }

            next.Handle(order, picture);
        }
    }
    class TextMachine : Machine
    {
        public override void Handle(Order order, IPicture picture)
        {
            if (Machine.p == Production.SimpleProduction)
            {
                picture.Text = order.Text;
            }
            else
            {
                if (order.Operation != "spacing" && order.Operation != "uppercase" && order.Operation != "lowercase")
                {
                    Console.WriteLine("Error: Cannot create picture!");
                    picture.IsPrintable = false;
                }
                else if (order.Operation == "spacing")
                {
                    string str = "";

                    foreach (var x in order.Text)
                    {
                        str += x;
                        str += ' ';
                    }

                    picture.Text = str;
                }
                else if (order.Operation == "uppercase")
                {
                    picture.Text = order.Text.ToUpper();
                }
                else if (order.Operation == "lowercase")
                {
                    picture.Text = order.Text.ToLower();
                }
            }
            
            next.Handle(order, picture);

        }
    }
    class ShapeMachine : Machine
    {

        public override void Handle(Order order, IPicture picture)
        {

            if (Machine.p == Production.SimpleProduction)
            {
                if (order.Shape != "circle" && order.Shape != "square" && order.Shape != "triangle")
                {
                    Console.WriteLine("Error: Picture cannot be created!");
                    picture.IsPrintable = false;

                }
                else if (order.Shape == "circle")
                {
                    picture.LeftFrame = "(";
                    picture.RightFrame = ")";
                }
                else if (order.Shape == "square")
                {
                    picture.LeftFrame = "[";
                    picture.RightFrame = "]";
                }
            }
            else
            {
                if (order.Shape != "circle" && order.Shape != "square" && order.Shape != "triangle")
                {
                    Console.WriteLine("Error: Picture cannot be created!");
                    picture.IsPrintable = false;
                }
                else if (order.Shape == "circle")
                {
                    picture.LeftFrame = "(";
                    picture.RightFrame = ")";
                }
                else if (order.Shape == "square")
                {
                    picture.LeftFrame = "[";
                    picture.RightFrame = "]";
                }
                else if (order.Shape == "triangle")
                {
                    picture.LeftFrame = "<";
                    picture.RightFrame = ">";
                }
            }
            

        }
    }

}
