using Notepad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Notepad.ViewModels
{
    public class SearchViewModel : ObservableObject
    {
        public ICommand FindCommand { get; }

        public ICommand FindCurrentCommand { get; }
        public ICommand FindTabsCommand { get; }
        public ICommand FindAll { get; }
        public ICommand ReplaceCommand { get; }
        public ICommand ReplaceAllCommand { get; }
        public ICommand ReplaceAllCurrentCommand { get; }
        public ICommand ReplaceTabsCommand { get; }
        public ICommand ReplaceAllTabsCommand { get; set; }
        public ICommand ReplaceCurrentCommand { get; set; }

        private string _textReplace;
        private string _textReplaceWith;

        public bool IsSelectedCurrent { get; set; }
        public bool IsSelectedAll { get; set; }

        public string TextReplace 
        { 
            get { return _textReplace; }
            set { OnPropertyChanged(ref _textReplace, value); }
        }
        public string TextReplaceWith
        {
            get { return _textReplaceWith; }
            set { OnPropertyChanged(ref _textReplaceWith, value); }
        }

        private List<string> Response { get; set; }
        public SearchViewModel()
        {
            ReplaceAllCommand = new RelayCommands(ReplaceAll);
            ReplaceAllCurrentCommand = new RelayCommands(ReplaceAllCurrent);
            ReplaceAllTabsCommand = new RelayCommands(ReplaceAllTabs);

            ReplaceCommand = new RelayCommands(Replace);
            ReplaceTabsCommand = new RelayCommands(ReplaceTabs);
            ReplaceCurrentCommand = new RelayCommands(ReplaceCurrent);

            FindCommand = new RelayCommands(Find);
            FindCurrentCommand = new RelayCommands(FindCurrent);
            FindTabsCommand = new RelayCommands(FindTabs);
        }

        public void Replace()
        {
            var replaceAllDialog = new Replace();

            if (Tabs.TabsArray.Count == 0)
            {
                MessageBox.Show("Please open a file first!");
            }
            else
            {
                replaceAllDialog.ShowDialog();
            }
        }

        public void ReplaceAll()
        {
            var replaceAllDialog = new ReplaceAll();

            if (Tabs.TabsArray.Count == 0)
            {
                MessageBox.Show("Please open a file first!");
            }
            else
            {
                replaceAllDialog.ShowDialog();
            }
        }

        public void ReplaceAllCurrent()
        {
            var current = Tabs.TabsArray[Tabs.activeTabIndex];
            Tabs.TabsArray[Tabs.activeTabIndex].Text = current.Text.Replace(_textReplace, _textReplaceWith);
        }

        public void ReplaceAllTabs()
        {
            for (int i = 0; i < Tabs.TabsArray.Count; i++)
            {
                Tabs.TabsArray[i].Text = Tabs.TabsArray[i].Text.Replace(_textReplace, _textReplaceWith);           
            }
        }

        public void ReplaceCurrent()
        {
            var current = Tabs.TabsArray[Tabs.activeTabIndex];
            var regex = new Regex(Regex.Escape(_textReplace));
            Tabs.TabsArray[Tabs.activeTabIndex].Text = regex.Replace(current.Text, _textReplaceWith, 1);

        }
        public void ReplaceTabs()
        {
            
            var regex = new Regex(Regex.Escape(_textReplace));

            for (int i = 0; i < Tabs.TabsArray.Count; i++)
            {
                Tabs.TabsArray[i].Text = Tabs.TabsArray[i].Text = regex.Replace(Tabs.TabsArray[i].Text, _textReplaceWith, 1);
            }
           
        }
        
        public void Find()
        {
            var findDialog = new Find();

            if (Tabs.TabsArray.Count == 0)
            {
                MessageBox.Show("Please open a file first!");
            }
            else
            {
                findDialog.Show();
            }
        }

        public void FindCurrent()
        {
            int start = Tabs.TabsArray[Tabs.activeTabIndex].Text.IndexOf(_textReplace);
            int end = _textReplace.Length;

            Tabs.TabsArray[Tabs.activeTabIndex].StartFocus = start;
            Tabs.TabsArray[Tabs.activeTabIndex].EndFocus = end;
        }

        public void FindTabs()
        {
            
            for (int i = 0; i < Tabs.TabsArray.Count; i++)
            {
                int start = Tabs.TabsArray[i].Text.IndexOf(_textReplace);
                int end = _textReplace.Length;

                Tabs.TabsArray[i].StartFocus = start;
                Tabs.TabsArray[i].EndFocus = end;
            }
        }
    }
}
