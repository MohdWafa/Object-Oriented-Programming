using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiPlatform.Interfaces;
using MultiPlatform.confact;

namespace MultiPlatform
{
	class Program
	{
		private static void BuildUI(IGUIFactory platform) //... type of platform
		{
            IGrid grid = platform.createGrid();
            //create 3 buttons
            IButton b1 = platform.createButton();
            IButton b2 = platform.createButton();
            IButton b3 = platform.createButton();
            //set the contents
            b1.Content = "BigPurpleButton";
            b2.Content = "SmallButton";
            b3.Content = "Baton";
                                                                                                       //add buttons to the grid
            grid.AddButton(b1);
            grid.AddButton(b2);
            grid.AddButton(b3);
                                                                                                       //create 3 textboxes
            ITextBox text1 = platform.createTextBox();
            ITextBox text2 = platform.createTextBox();
            ITextBox text3 = platform.createTextBox();
                                                                                                       //set the contents
            text1.Content = "";
            text2.Content = "EmptyTextBox";
            text3.Content = "xoBtxeT";
                                                                                                       //add textboxes
            grid.AddTextBox(text1);
            grid.AddTextBox(text2);
            grid.AddTextBox(text3);


            foreach(var b in grid.GetButtons())
            {
                b.ButtonPressed();
                b.DrawContent();
            }

            foreach(ITextBox t in grid.GetTextBoxes())
            {
                t.DrawContent();
            }
        }

		static void Main(string[] args)
		{

			Console.WriteLine("<---------------------iOS--------------------->");
            iOSFactory iOS = new iOSFactory();
            BuildUI(iOS);

			Console.WriteLine("<---------------------Windows--------------------->");
            WindowsFactory windows = new WindowsFactory();
            BuildUI(windows);
			

			Console.WriteLine("<---------------------Android--------------------->");
            AndroidFactory android = new AndroidFactory();
            BuildUI(android);
			
		}
	}
}
