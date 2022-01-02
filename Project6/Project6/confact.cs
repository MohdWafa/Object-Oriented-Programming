using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiPlatform.Interfaces;
using MultiPlatform.Products;

namespace MultiPlatform.confact
{
    public class WindowsFactory : IGUIFactory
    {
        public IButton createButton()
        {
            return new windowsButton();
        }

        public IGrid createGrid()
        {
            return new windowsGrid();
        }

        public ITextBox createTextBox()
        {
            return new windowsTextBox();
        }
    }

    public class iOSFactory : IGUIFactory
    {
        public IButton createButton()
        {
            return new iOSButton();
        }

        public IGrid createGrid()
        {
            return new iOSGrid();
        }

        public ITextBox createTextBox()
        {
            return new iOSTextBox();
        }
    }

    public class AndroidFactory : IGUIFactory
    {
        public IButton createButton()
        {
            return new androidButton();
        }

        public IGrid createGrid()
        {
            return new androidGrid();
        }

        public ITextBox createTextBox()
        {
            return new androidTextBox();
        }
    }

}
