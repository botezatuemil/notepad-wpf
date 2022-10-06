using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Notepad.ViewModels
{
    public class HelpViewModel : ObservableObject
    {
        public ICommand HelpCommand { get; }
        public ICommand OpenLinkCommand { get; }
        public HelpViewModel()
        {
            HelpCommand = new RelayCommands(DisplayAbout);
            OpenLinkCommand = new RelayCommands(OpenLink);
        }

        public void DisplayAbout()
        {
            var aboutWindow = new About();
            aboutWindow.Show();
        }

        public void OpenLink()
        {
            System.Diagnostics.Process.Start("https://mail.unitbv.ro/");
        }
    }
}
