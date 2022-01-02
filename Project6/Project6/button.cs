using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiPlatform.Interfaces;

namespace MultiPlatform.Products
{
    public class iOSButton : IButton
    {
        public iOSButton()
        {
            Console.WriteLine($"{nameof(iOSButton)} created");
        }

        private string content;
        public string Content {
            get { return content; }
            set { content = value; }
        }

        public void ButtonPressed()
        {
            Console.WriteLine(this.Content);
        }

        public void DrawContent()
        {
            Console.WriteLine($"IOS Button pressed, content - {content}");
        }
    }

    public class windowsButton : IButton
    {
        public windowsButton()
        {
            Console.WriteLine($"{nameof(windowsButton)} created");
        }

        private string content;
        public string Content {
            get { return content; }
            set
            {
                content = value.ToUpper();
            }
        }

        public void ButtonPressed()
        {
            Console.WriteLine("Windows Button pressed.");
        }

        public void DrawContent()
        {
            Console.WriteLine(this.Content);
        }
    }

    public class androidButton : IButton
    {
        
        public androidButton()
        {
            Console.WriteLine($"{nameof(androidButton)} is created");
        }

        private string content;
        public string Content {
            get { return content; }
            set {

                if (value.Length > 8)
                    content = value.Substring(0, 8);
                else content = value;
            }
        }

        public void ButtonPressed()
        {
            Console.WriteLine($"Sweet {content}!");
        }

        public void DrawContent()
        {
            Console.WriteLine(this.Content);
        }
    }

}
