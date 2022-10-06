using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Notepad.Models
{
    public class TabItem : ObservableObject
    {
        private string _header;
        private string _text;
        private string _path;
        private string _filename;
        private bool _isChanged = false;

        private int first = 0;

        public TabItem()
        {
        }
        public TabItem(string header, string text, string path, string filename)
        {
            Header = header;
            Text = text;
            Path = path;
            Filename = filename;
        }

        public string Header 
        {
            get { return _header; }
            set 
            { 
                OnPropertyChanged(ref _header, value); 
            }
        }

        public string Text
        {
            get { return _text; }
            set 
            {
                OnPropertyChanged(ref _text, value);
                first++;
                if (first == 2)
                {
                    IsChanged = true;
                }
            }
        }

        public string Path
        {
            get { return _path; }
            set { OnPropertyChanged(ref _path, value); }
        }

        public string Filename
        {
            get { return _filename; }
            set { OnPropertyChanged(ref _filename, value); }
        }

        public bool IsChanged
        {
            get { return _isChanged; }
            set 
            { 
                OnPropertyChanged(ref _isChanged, value);   
                if (!IsChanged)
                {
                    Filename = Filename.Remove(Filename.Length - 1, 1);
                    first = 1;
                }
                else
                {
                    if (first <= 2)
                    {
                        Filename += "*";
                        first++;
                    }
                }
            }
        }

        // Font style

        private FontStyle _style;
        public FontStyle Style
        {
            get { return _style; }
            set { OnPropertyChanged(ref _style, value); }
        }

        private FontWeight _weight;
        public FontWeight Weight
        {
            get { return _weight; }
            set { OnPropertyChanged(ref _weight, value); }
        }

        private FontFamily _family;
        public FontFamily Family
        {
            get { return _family; }
            set { OnPropertyChanged(ref _family, value); }
        }

        private TextWrapping _textWrapping;
        public TextWrapping TextWrapping
        {
            get { return _textWrapping; }
            set
            {
                OnPropertyChanged(ref _textWrapping, value);
                isWrapped = value == TextWrapping.Wrap ? true : false;
            }
        }

        private bool _isWrapped;
        public bool isWrapped
        {
            get { return _isWrapped; }
            set { OnPropertyChanged(ref _isWrapped, value); }
        }

        private double _size;
        public double Size
        {
            get { return _size; }
            set { OnPropertyChanged(ref _size, value); }
        }

        //Focus tab

        private int _startFocus;
        private int _endFocus;

        public int StartFocus
        {
            get { return _startFocus; }
            set { OnPropertyChanged(ref _startFocus, value); }
        }

        public int EndFocus
        {
            get { return _endFocus; }
            set { OnPropertyChanged(ref _endFocus, value); }
        }
    }

    public class Tabs
    {
        public static ObservableCollection<TabItem> TabsArray { get; set; }
        private static int tabs = 0;
        public static int activeTabIndex { get;  set; }
        public Tabs () 
        { 
            TabsArray = new ObservableCollection<TabItem>();
        }
        public static void AddTab(DocumentModel document)
        {

            tabs++;
            if (document.FileName == "")
            {
                document.FileName = "Untitled " + tabs;
            }
           
            TabItem tabItem = new TabItem (document.FileName, document.Text,document.FilePath, document.FileName);
            TabsArray.Add(tabItem);
        }

        public static void RemoveTab()
        {
            TabsArray.Remove(TabsArray[activeTabIndex]);
            tabs--;
        }
    }

}
