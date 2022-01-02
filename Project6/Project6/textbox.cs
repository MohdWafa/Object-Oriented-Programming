using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiPlatform.Interfaces;

namespace MultiPlatform.Products
{
    public class iOSTextBox : ITextBox
    {
        public iOSTextBox()
        {
            Console.WriteLine($"{nameof(iOSTextBox)} is created");
        }

        public string Content { get; set; }

        public void DrawContent()
        {
            Console.WriteLine(this.Content);
        }
    }

    public class windowsTextBox : ITextBox
    {
        public windowsTextBox()
        {
            Console.WriteLine($"{nameof(windowsTextBox)} is created");
        }

        private string content;
        public string Content
        {
            get { return content; }
            set {
                int len = value.Length;
                content = value.Substring(len/2) + " by .Net Core"; 
            }
        }

        public void DrawContent()
        {
            Console.WriteLine(this.Content);
        }
    }

    public class androidTextBox : ITextBox
    {
        public androidTextBox()
        {
            Console.WriteLine($"{nameof(androidTextBox)} is created");
        }

        private string content;
        public string Content {
            get { return content; }
            set {
                char[] arr = value.ToCharArray();
                Array.Reverse(arr);
                content = new string(arr);
            }
        }

        public void DrawContent()
        {
            Console.WriteLine(this.content);
        }
    }



}
