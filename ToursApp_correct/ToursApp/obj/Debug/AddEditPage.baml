   M S B A M L   `   `   `  ����C  ?ToursApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ToursAppToursApp  5          ToursApp.AddEditPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:ToursApp     5        N� Title$  AddEditPage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��150 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��Название��6   $��Center=�6$   $��10,0,0,0q�6?   �� 5   
   $%��Количество звёзд��6   $��1��6,   $��Center=�69   $��10,0,0,0q�6T   �� 5   
   $��Страна��6   $��2��6"   $��Center=�6/   $��10,0,0,0q�6J   �� 5   
    �� 	MaxLength$	 100��6(   $��1��68   $��Center=�6H   $��	10,0,10,0q�6c   ��6   �� *Name+6x   �� 5   
   $��1��60   $��1��6@   $	��152��6M   $��Center=�6Y   $
��Left=�6t   $��10,0,0,0q�6�   ��6   �� *CountOfStars+6�   �� 5   
   -   5         ��Name$ ComboCountries��5   4    �� DisplayMemberPath$
 Name��6L   $��2��6e   $��1��6r   $��Center=�6�   $��10q�6�    �� SelectedItem 6   �� *	Country+6�   �� 5   
   -   5        $��Btn_Save��5   %   $��Сохранить��6   $��1��65   $��3��6E   $��Center=�6R   $��Center=�6m   6�   5      5      