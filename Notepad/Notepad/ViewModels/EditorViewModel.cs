using Notepad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Notepad.ViewModels
{
    public class EditorViewModel
    {
        public ICommand FormatCommand { get; }
        public ICommand WrapCommand { get; }
        public FormatModel Format { get; set; }
        public DocumentModel Document { get; set; }
       
        public EditorViewModel(DocumentModel document)
        {
            Document = document;
            Format = new FormatModel();
            FormatCommand = new RelayCommands(OpenStyleDialog);
            WrapCommand = new RelayCommands(ToggleWrap);
        }

        private void OpenStyleDialog()
        {
            var fontDialog = new FontDialog();
            fontDialog.DataContext = Format;
            
            fontDialog.ShowDialog();

            Tabs.TabsArray[Tabs.activeTabIndex].Style = Format.Style;
            Tabs.TabsArray[Tabs.activeTabIndex].Weight = Format.Weight;
            Tabs.TabsArray[Tabs.activeTabIndex].Family = Format.Family;
            Tabs.TabsArray[Tabs.activeTabIndex].TextWrapping = Format.TextWrapping;
            Tabs.TabsArray[Tabs.activeTabIndex].Size = Format.Size;
            Tabs.TabsArray[Tabs.activeTabIndex].IsChanged = true;
        }

        private void ToggleWrap()
        {
            if (Format.TextWrapping == System.Windows.TextWrapping.Wrap)
            {
                Format.TextWrapping = System.Windows.TextWrapping.NoWrap;
            }
            else
            {
                Format.TextWrapping = System.Windows.TextWrapping.Wrap;
            }
        }
    }
}
