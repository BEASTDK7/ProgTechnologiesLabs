   M S B A M L   `   `   `  ����A  =LW__20, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:LW__20LW__20  5   	       LW__20.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:LW__20     5   	     � Title$%  ИНС191 Кошевой ЛР20��5   	   $	��500��6%   $
��1000��62   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� -   5         ��Name$ 	sldSource��5       � Value$ 40Q�6$    � Maximum$	 100Q�6/    � Minimum$ 1Q�6=   
����p�� �� TickFrequency$ 7Q�5       �� TickPlacement$
 Both=�6#   $��0��5      $��5q�6    �� AutoToolTipPlacement$ TopLeft=�6)   � 5   
   $��1��6   
�������	 � ColumnDefinitions	 5      �� 5      $
��Auto �6#   �� 5      �� 5      $
��Auto �6#   .+�5      �� -   5        
 ��Name$
 	listColor��5      $��0��6)   $	��150��69    �� SelectedIndex$ 0��6E   
�������.@�5      �� $��Красный��6   
 � Tag$ Crimson��60   �� 5      $��Оранжевый��6   $ 	OrangeRed��62   �� 5      $��Жёлтый��6   $ Yellow��6/   �� 5      $��Зелёный��6   $ 
LightGreen��60   �� 5      $��Голубой��6   $ SkyBlue��60   �� 5       $��
Синий��6   $ 
DodgerBlue��6.   �� 5!      $��Фиолетовый��6   $ 
BlueViolet��63   5"      �� 5$      -   5         ��Name$ 	txtTarget��5$      $��1��6+   
���   � �� TextAlignment$ Center=�5%      $��Center=�6+   ��5&      �� *Value+ �� ElementName$ 	sldSource�� �� Mode$ TwoWay=���5'      �� $ 	listColor�� �� Path$ SelectedItem.Tag���5(      �� *Text+$ txtTextSource���� 5*      $��2��6   
���iii�.+�5+      � .+�5,      �� -   5         ��Name$ btnCreateBinding��5,      $�� Привязать ��67   
������$��6q�5-      $��30��5.      5/      �� 50      -   5        $ btnDeleteBinding��50      $��  Отвязать  ��67   
���\\��$��6q�51      $��30��52      53      54      �� 55      -   5        $
 listFont��55      $ 0��6,   $��0 10 0 0q�56      .@�57      �� $��Tahoma��6"   $ Tahoma��63   $��Tahoma)�6@   �� 58      $��Calibri��6"   $ Calibri��64   $��Calibri)�6B   �� 59      $��Times New Roman��6"   $ Times New Roman��6<   $��Times New Roman)�6R   5:      �� 5<      -   5        $
 
listWeight��5<      $ 0��6.   $��0 10 0 0q�5=      .@�5>      �� $��Regular��6"   $ Regular��64   �� 5?      $
��Bold��6"   $
 Bold��61   $
��Bold"�6<   5@      5A      5B      �� 5C   
   $��2��6   $��10q�6"   .+�5D      �� -   5         ��Name$ enableButton��5D      $+��%Редактировать текст��6-    d� 	IsChecked$
 TrueY�6K   $��16(�5E      �� 5F      -	   5         ��Name$ txtTextSource��5F      $��Пример Example��6-   $��2��6C   $��15(�5H      {�5G      �� $ enableButton��$ 	IsChecked�5H      5I      5J      5K      