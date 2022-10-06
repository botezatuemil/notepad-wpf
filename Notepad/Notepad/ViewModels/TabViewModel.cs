using Notepad;
using Notepad.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using MessageBox = System.Windows.Forms.MessageBox;
using TabItem = Notepad.Models.TabItem;

namespace Notepad.ViewModels
{
    public class TabViewModel
    {
        public ICommand AddTabCommand { get; }
        public ICommand RemoveTabCommand { get; }
        public DocumentModel Document { get;  set; }
       
        public TabViewModel(DocumentModel document)
        {
            
            Document = document;
            AddTabCommand = new RelayCommands(AddTab);
            RemoveTabCommand = new RelayCommands(RemoveTab);
        }
       
        public void AddTab()
        {
            Tabs.AddTab(Document);
        }

        public void RemoveTab()
        {
            if (!Tabs.TabsArray[Tabs.activeTabIndex].IsChanged)
            {
                Tabs.RemoveTab();
            }
            else
            {
                string message = "The file was not saved. Do you want to save your file?";
                string caption = "Unsaved Document";

                DialogResult dialogResult = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    Tabs.RemoveTab();
                }
            }
        }
    }
}

