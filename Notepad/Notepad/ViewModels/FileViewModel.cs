using Microsoft.Win32;
using Notepad.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Notepad.ViewModels
{
    public class FileViewModel
    {
        public DocumentModel Document { get; private set; }
        public TabViewModel TabViewModel { get;  set; }
        public ICommand NewCommand { get; }
        public ICommand SaveCommand { get; }
        public ICommand SaveAsCommand { get; }
        public ICommand OpenCommand { get; }
        public ICommand ExitCommand { get; }
        public FileViewModel(DocumentModel document)
        {
            Document = document;
            NewCommand = new RelayCommands(NewFile);
            SaveCommand = new RelayCommands(SaveFile);
            SaveAsCommand = new RelayCommands(SaveFileAs);
            OpenCommand = new RelayCommands(OpenFile);
            ExitCommand = new RelayCommands(Exit);
        }
        
        public void NewFile()
        {
            Document.FileName = "";
            Document.FilePath = String.Empty;
            Document.Text = String.Empty;

            TabViewModel = new TabViewModel(Document);
            TabViewModel.AddTab();
        }

        private void SaveFile()
        {
            string text = Tabs.TabsArray[Tabs.activeTabIndex].Text;
            string filepath = Tabs.TabsArray[Tabs.activeTabIndex].Path;

            Tabs.TabsArray[Tabs.activeTabIndex].IsChanged = false;

            if (filepath == "")
            {
                SaveFileAs();
            }
            else
            {
                File.WriteAllText(filepath, text);
            }
        }

        private void SaveFileAs()
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File (*.txt)|*.txt";
           
            string text = Tabs.TabsArray[Tabs.activeTabIndex].Text;
            Tabs.TabsArray[Tabs.activeTabIndex].IsChanged = false;

            if (saveFileDialog.ShowDialog() == true)
            {
                DockFile(saveFileDialog);
                File.WriteAllText(saveFileDialog.FileName, text);
                Tabs.TabsArray[Tabs.activeTabIndex].Filename = saveFileDialog.SafeFileName;
                Tabs.TabsArray[Tabs.activeTabIndex].Path = saveFileDialog.FileName;
               
            }
        }

        private void OpenFile()
        {
            var openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == true)
            {
                DockFile(openFileDialog);
                Document.Text = File.ReadAllText(openFileDialog.FileName);
                TabViewModel = new TabViewModel(Document);
                TabViewModel.AddTab();
            }

        }

        private void DockFile<T>(T dialog) where T : FileDialog
        {
            Document.FilePath = dialog.FileName;
            Document.FileName = dialog.SafeFileName;
        }

        private void Exit()
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
