using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiPlatform.Interfaces;

namespace MultiPlatform.Products
{
    public class iOSGrid : IGrid
    {

        public iOSGrid()
        {
            Console.WriteLine($"{nameof(iOSGrid)} is created");
        }

        private List<IButton> buttonsi = new List<IButton>();
        private List<ITextBox> textBoxesi = new List<ITextBox>();
        public void AddButton(IButton button)
        {
            buttonsi.Add(button);
        }

        public void AddTextBox(ITextBox textBox)
        {
            textBoxesi.Add(textBox);
        }

        public IEnumerable<IButton> GetButtons()
        {
            foreach (var b in buttonsi)
               yield return b;
        }

        public IEnumerable<ITextBox> GetTextBoxes()
        {
            foreach (var t in textBoxesi)
                yield return t;
        }
    }

    public class windowsGrid : IGrid
    {
        public windowsGrid()
        {
            Console.WriteLine($"{nameof(windowsGrid)} is created");
        }

        private List<IButton> buttonsw = new List<IButton>();
        private List<ITextBox> textBoxesw = new List<ITextBox>();
        public void AddButton(IButton button)
        {
            buttonsw.Add(button);
        }

        public void AddTextBox(ITextBox textBox)
        {
            textBoxesw.Add(textBox);
        }

        public IEnumerable<IButton> GetButtons()
        {
            for (int i = buttonsw.Count - 1; i >= 0; i--)
            {
                yield return buttonsw[i];
            }
        }

        public IEnumerable<ITextBox> GetTextBoxes()
        {
            yield return textBoxesw[0];
            for (int i = textBoxesw.Count - 1; i >= 1; i--)
            {
                yield return textBoxesw[i];
            }
        }
    }

    public class androidGrid : IGrid
    {
        public androidGrid()
        {
            Console.WriteLine($"{nameof(androidGrid)} is created");
        }

        private List<IButton> buttonsa = new List<IButton>();
        private List<ITextBox> textBoxesa = new List<ITextBox>();
        public void AddButton(IButton button)
        {
            buttonsa.Add(button);
        }

        public void AddTextBox(ITextBox textBox)
        {
            textBoxesa.Add(textBox);
        }

        public IEnumerable<IButton> GetButtons()
        {
            foreach (var button in buttonsa)
                yield return button;
        }

        public IEnumerable<ITextBox> GetTextBoxes()
        {
            return Enumerable.Empty<ITextBox>();
        }
    }



}
