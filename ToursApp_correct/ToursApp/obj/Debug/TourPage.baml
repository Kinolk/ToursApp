   M S B A M L   `   `   `  ����C  ?ToursApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ToursAppToursApp  5          ToursApp.TourPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:ToursApp     5        N� Title$  TourPage��5	      .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      $
��auto �6    �� 5      $��* �6    �� 5      $��73 �6    .+�5      �  � Orientation$ 
Horizontal=�6   $��Center=�62   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $9��3Введите название для поиска��6    $	��175��6C    �� TextAlignment$ Right=�6O   �� 5      -   5        $��
TBoxSearch��5   5   $��5q�6   $	��225��6)   6G   5      �� 5      $ 
Horizontal=�6   .+�5      �� $��Выберите тип��6    $	��175��64   $ Right=�6@   �� 5      -   5         ��Name$ 	ComboType��5       �� DisplayMemberPath$
 Name��6`   5      �� 5       -   5         ��Name$ CheckActual��5       $C��=Показывать только актульные туры��61   $��Center=�6\    d� 	IsChecked$
 TrueY�6z   5!   9   5#      �� 5%      -   5        $��
LViewTours��5%   $   $��1��6   $��Disabled=�66   $��Center=�6l   ��5&      �� 5'      .R�5(      � $ 
Horizontal=�6$   $��Center=�6>   6]   5)      ��5,      �� 5-      .R�5.      � $��20q�6   $	��400��6+    5/      �� 50   "   $��70 �60   �� 51   "   $	��310 �60   �� 52   "   $
��auto �60   �� 53   "   $
��auto �60   .+�5:      �� $��ImageS��60   $	��400��6$   $��1��6?   $��UniformToFill=�6L   $��Center=�6d   $��5q�6�   ��5;   "   �� 5=   &   	 �� Path$	 ImagePreview�6.   
 �� TargetNullValue
 5?   (   ��5@   .   ?;C:\Users\Dima0\source\repos\Tour\Tour\Resources\picture.png��5H   /   5K   '   5M      �� 5O      $��Center=�6>   $ Center=�6Y   $	��390��6p   $
��Wrap=�5P   (   $��Center=�6<   $
�� 5 5q�6Y   $��26(�6g   $��0��6u   ��5O   (   �� *Name+5P   u   �� 5Q      $��2��6[   $��5 5 5 15q�6h   $��Center=�6z   $��26(�6�   $
��Bold"�6�   ��6(   �� *Price+ �� StringFormat$ {0:N2} Руб��6�   �� 5R      $��3��6j   $��14(�6w   $��Right=�6�   ��6(   �� *TicketCount+$) #Билетов осталось:{0}��6�   �� 5S      $��3��6D   $��14(�6Q   $
��Left=�6_   ��6(   �� *
ActualText+6_   5T      5U      5W      �� 5X      -   5        $��BtnAdd��5X   (   $��Добавить��6   $
��Left=�66   $��20q�6Q   $��2��6]   6j   �� 5Y      -   5        $��	Btndelete��5Y   '   $��Удалить��6   $��Right=�68   $��20q�6T   $��2��6`   6m   5[      5]      5_      