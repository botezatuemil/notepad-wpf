   M S B A M L   `   `   `  ????B  >Notepad, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Notepad.ModelsNotepad.Models  5   	   7 clr-namespace:Notepad.ViewModelsNotepad.ViewModels  5   	       Notepad.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Notepad.Models     5   	   7
viewmodels clr-namespace:Notepad.ViewModels     5   	     ? Title$  	Notepad++??5	   	   $	??450??6   $	??800??6(    ? DataContext 5
      &    Notepad.ViewModels.MainViewModel  5   
   .??5      ]? $??1q?6   .+?5   
   o? $	??Top=?6   @?5      m? 5      $
??File??6   ???#959aa1$
??25px??6>   $
??40px??6L   
???   ? 6m   ?? *File+.@?5      m? $	??New??6    m? Command 6,   ?? *
NewCommand+m? 5      $
??Open??6    6-   ?? *OpenCommand+m? 5      $
??Save??6    6-   ?? *SaveCommand+m? 5      $??
Save as...??6    63   ?? *SaveAsCommand+m? 5      $
??Exit??6    6-   ?? *ExitCommand+5      m? 5      $??Search??6   ???#959aa1$
??25px??6@   $
??60px??6N   
???   ? 6o   ?? *Search+.@?5      m? $
??Find??6    6-   ?? *FindCommand+m? 5      $??Replace??6    60   ?? *ReplaceCommand+m? 5      $??Replace All??6    64   ?? *ReplaceAllCommand+5      m? 5      $??Format??6   ???#959aa1$
??25px??6@   $
??60px??6N   
???   ? 6o   ?? *Editor+.@?5      m? $??Format??6    6/   ?? *FormatCommand+5"      m? 5$      $
??Help??6   ???#959aa1$
??25px??6>   $
??40px??6L   
???   ? 6m   ?? *Help+.@?5%      m? $??About??6    6.   ?? *HelpCommand+5&      m? 5)      ???#959aa1$??
Remove Tab??60   $
??25px??6D   $
??80px??6R   
???   ? 6s   ?? *Tab+ 6?   ?? *RemoveTabCommand+5+      5-      ?? 5/   
   -   5        $??TabControlName??5/   ?   $	??Top=?6   ??6*   ?? *Tabs.TabsArray+ ?? SelectedIndex 6Q   ?? *Tabs.activeTabIndex+ ?? Mode$ TwoWay=? ?? UpdateSourceTrigger$ PropertyChanged=???50      ?? 51      .R?52      ??  ?? Orientation$ 
Horizontal=?6!   .+?53      ?? ??6$   ?? *
Filename+$ TwoWay=?$ PropertyChanged=?55      56       ?? ContentTemplate 59      ?? 5:      .R?5;      ]? .+?5<      ?? $??Bottom=?6$   ??6<   ?? *Path+$ TwoWay=?$ PropertyChanged=?"   Notepad.Models.CustomTextBox  5=      $	??Top=?62   " ?? VerticalScrollBarVisibility$ Visible=?5>   "   	 ?? AcceptsReturn	 . 
 ?? 
AcceptsTab
 . ??5?   "   ?? *Family+??5@   "   ?? *Size+??5A   "   ?? *	FontStyle+$ TwoWay=?$ PropertyChanged=???5B   "   ?? *Weight+$ TwoWay=?$ PropertyChanged=? ?? TextWrapping 5C   "   ?? *TextWrapping+??5F   "   ?? *Text+$ TwoWay=?$ PropertyChanged=?   BindableSelectionStart 5G   "   ?? *
StartFocus+$ TwoWay=?$ PropertyChanged=?   BindableSelectionLength 5H   "   ?? *
EndFocus+$ TwoWay=?$ PropertyChanged=?5K      5L      5O      5P      5Q      