using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Notepad
{

    public partial class Replace : Window
    {
        public Replace()
        {
            InitializeComponent();
        }

       /* public List<double> GetResponseTexts()
        {
            IEnumerable<TextBox> textBoxes = mainGrid.Children.OfType<TextBox>();
            var response = new List<double>();
            foreach (var textBox in textBoxes)
            {
                if (textBox.Text.ToString().Trim().Length == 0 || IsNumeric(textBox.Text.ToString()) == false)
                    response.Add(0);
                else
                    response.Add(double.Parse(textBox.Text));
            }

            return response;
        }
        public List<String> GetResponseTexts2()
        {
            IEnumerable<TextBox> textBoxes = mainGrid.Children.OfType<TextBox>();
            var response = new List<String>();
            foreach (var textBox in textBoxes)
            {
                if (textBox.Text.ToString().Trim().Length == 0)
                    response.Add("");
                else
                    response.Add(textBox.Text);
            }

            return response;
        }
        public void CreateDialogBox(List<string> values)
        {
           
            dialogBoxWindow.Height = values.Count * 2 * 50 + 75;
            int index = 1;
            foreach (var val in values)
            {
                var textBlock = new TextBlock();
                textBlock.Text = val;
                mainGrid.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto });
                var textBox = new TextBox();
                mainGrid.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto });
                Grid.SetRow(textBlock, index++);
                mainGrid.Children.Add(textBlock);
                Grid.SetRow(textBox, index++);
                mainGrid.Children.Add(textBox);
            }
        }

        private void OKButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            dialogBoxWindow.Close();
        }

        private bool IsNumeric(string text)
        {
            double test;
            return double.TryParse(text, out test);
        }

        internal void CreateDialogBox(string v)
        {
            throw new System.NotImplementedException();
        }*/
    }
}
