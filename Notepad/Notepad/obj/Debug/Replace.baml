   M S B A M L   `   `   `  ????B  >Notepad, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Notepad.ViewModelsNotepad.ViewModels  5   	   !clr-namespace:NotepadNotepad  5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U<clr-namespace:System.Windows.Media;assembly=PresentationCoreSystem.Windows.Media 5   	   I6clr-namespace:System.Windows;assembly=PresentationCoreSystem.Windows 5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	       Notepad.Replace   5   	   /
viewmodels clr-namespace:Notepad.ViewModels  5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5	   	   @d2http://schemas.microsoft.com/expression/blend/2008     5
   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Notepad     5   	   Nmedia<clr-namespace:System.Windows.Media;assembly=PresentationCore     5   	   Fwin6clr-namespace:System.Windows;assembly=PresentationCore     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	   -   5          ?Name$  dialogBoxWindow??5   	    ? Title$ Replace??5   	   $	??200??5   	   $	??300??5   	    ? Left$	 200??5   	   
 ? Top$	 200??5   	    ? 
ResizeMode$ NoResize=?5   	    ? WindowStartupLocation$ CenterScreen=?5   	    ? DataContext 5      (   "Notepad.ViewModels.SearchViewModel  5   
   .??5      ? -   5         ?Name$ mainGrid??5      ???#E5F9E0 ? RowDefinitions 5   
   ?? 5      $??40 ?6   .+?5   
   ?  5      ?? 5      $??* ?6    5!      ? 5"   
   $??0,124,0,-124q?6   $	??300??6%   	 ? ColumnDefinitions	 5#      ?? 5$      $	??83* ?6#   ?? 5%      $	??18* ?6#   ?? 5&      $	??12* ?6#   .+?5)      ?? 
 ?? Orientation$
 Vertical=?6   ?? 5*      $
 
Horizontal=?6   $??Center=?62   $??3??6O    ? 	Resources 5,       ?? 
TargetType ?? Property ?? Value??%Y   '??       ?? 5-      " ??6   .?5.      ??  ? ??$ 	30,0,30,0q?63   5/      50      .+?51      ?? $??Current??6   $?? ??6U   $??50??6k   $??30??6v   ??6+   ?? *ReplaceCurrentCommand+6v   ?? 52      $	??All??6   $??50??6N   $??30??6Y   ??6'   ?? *ReplaceTabsCommand+6Y   53      54      ?? 55   
   $??40,8,-40,-8q?6   .??6%   Find6+   ?? 56   
   $??40,30,40,-8q?6   ??6'   ?? *TextReplace+ ?? Mode$ TwoWay=? ?? UpdateSourceTrigger$ PropertyChanged=??? 57   
   $??40,48,-40,-48q?6   .??6(   	Replace61   ?? 58   
   $??40,74,40,-52q?6   ??6(   ?? *TextReplaceWith+$ TwoWay=?$ PropertyChanged=?59      5:      