using Notepad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad.ViewModels
{
    public class MainViewModel
    {
        private DocumentModel _document;
        public EditorViewModel Editor { get; set; }
        public FileViewModel File { get; set; }
        public HelpViewModel Help { get; set; }
        public TabViewModel Tab { get; set; }
        public Tabs Tabs { get; set; }
        public TabItem TabItem { get; set; }
        public SearchViewModel Search { get; set; }

        public MainViewModel()
        {
            _document = new DocumentModel();
            Help = new HelpViewModel();
            Editor = new EditorViewModel(_document);
            Tab = new TabViewModel(_document);
            File = new FileViewModel(_document);
            Tabs = new Tabs();
            TabItem = new TabItem();
            Search = new SearchViewModel();
        }
    }
}
