   M S B A M L   `   `   `  ����O  KCommandDesignPattern, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:CommandDesignPatternCommandDesignPattern  5   	   %    CommandDesignPattern.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:CommandDesignPattern     5   	     � 
ResizeMode$  NoResize=�6:    � SizeToContent$ WidthAndHeight=�5       � Title$ Command Design Pattern��5   	   .��5
      ��  �� Orientation$ Vertical=�6   .+�5   
   �� $ 
Horizontal=�6   $��10q�6.   .+�5      �� -   5        $��	B1Setting��5      $��20��6(   $	��100��64   ��5      ��  �� Path$ MyCommandList� �� SelectedValue 5      �� $ SelectedCommandButton1� �� Mode$ TwoWay=�6\   �� 5      -   5         ��Name$
 Btn1��5      $��5q�6#   ��6.   �� *
Button1Cmd+.��6M   
Button 16W   5      �� 5   
   $ 
Horizontal=�6   $��10q�6.   .+�5      �� -   5        $��	B2Setting��5      $��20��6(   $	��100��64   ��5      �� $ MyCommandList� 5      �� $ SelectedCommandButton2�$ TwoWay=�6\   �� 5      -   5        $
 Btn2��5      $��5q�6#   ��6.   �� *
Button2Cmd+.��6M   
Button 26W   5      5      5)      