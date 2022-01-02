using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiPlatform.Interfaces
{
    interface IGUIFactory
    {
        IButton createButton();
        IGrid createGrid();
        ITextBox createTextBox();

    }

}
