   M S B A M L   `   `   `  ����D  @kursovaya, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:kursovaya	kursovaya  5          kursovaya.DogovorsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:kursovaya     5      -   5          N� Title$  DogovorsPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $	��99* �6   �� 5      $
��298* �6   �� 5      $	��53* �6   .+�5   
   �  � Orientation$ 
Horizontal=�6   $��Center=�6-   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $6��0Выберите фамилию клиента: ��6   $	��175��6>    �� TextAlignment$ Right=�6J   6b   �� 5      -   5        $��ComboClientSearch��5   '   $	��225��6    �� DisplayMemberPath$ fio_cl��6v   6�   5      �� 5      $ 
Horizontal=�6   .+�5      �� $<��6Выберите фамилию сотрудника: ��6   $	��175��6A   $ Right=�6M   6e   �� 5      -   5        $��ComboSotrudSearch��5   '   $	��225��6   $ 
fio_sotrud��6v   6�   5      �� 5      $ 
Horizontal=�6   .+�5      �� $��Выберите тип: ��6   $	��175��62   $ Right=�6>   6V   �� 5      -   5        $��ComboTypeSearch��5   '   $	��225��6   $ 	name_type��6r   6�   5      �� 5       $ 
Horizontal=�6   .+�5!      �� $%��Выберите филиал: ��6   $	��175��65   $ Right=�6A   6Y   �� 5"      -   5        $��ComboFilialSearch��5"   '   $	��225��6   $ 	name_fill��6v   6�   5#      5$      &   System.Windows.Controls.DataGrid  5&   
   -   5          Name$ DGridDogovors��5&         AutoGenerateColumns .     
IsReadOnly . $��1��6X   	   Columns	 5'      0  *System.Windows.Controls.DataGridTextColumn  5(      ,  &System.Windows.Controls.DataGridColumn
   Header$
 ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *id+6T     5)      $
 Дата начала��6%   $	 150 6Y    6:   �� *
date_start+6g     5*      $!
 Дата окончания��6%   $	 150 6Z    6=   �� *
date_end+6h     5+      $'
 !Страховой процент��6%   $	 150 6]    6@   �� *
str_proc+6k     5,      $'
 !Страховая выплата��6%   $	 150 6\    6@   �� *	str_pay+6j     5-      $
 ФИО клиента��6%   $	 150 6]    6:   �� *clients.fio_cl+6k     5.      $#
 Тип страхования��6%   $	 150 6h    6>   �� *type_of_str.name_type+6v     5/      $!
 ФИО сотрудника��6%   $	 150 6c    6=   �� *sotrud.fio_sotrud+6q     50      $
 Филиал��6%   $	 150 6\    65   �� *fillials.name_fill+6j   4  .System.Windows.Controls.DataGridTemplateColumn  51      $
 auto 6)      CellTemplate 52      �� 53      .R�54      �� $��btnEdit��64   -   5        $
��Edit��54   %   $��1q�6C   ���#53377A6�   55      57        58      $
 auto 6)    59      �� 5:      .R�5;      �� $��btnPeint��65   -   5        $��Print��5;   %   $��1q�6E   ���#53377A6�   5<      5>      5@      �� 5A   
   -	   5        $��btnAdd��5A   }   $%��Добавить договор��6   $��2��6,   $��1q�69   ���#53377A$
��Left=�6b   $��	5,11,0,12q�6�   $	��150��6�   6�   �� 5B   
   -
   5        $��btnAddClient��5B   }   $%��Добавить клиента��6   $��2��6,   $��1q�69   ���#53377A$
��Left=�6b   $��184,11,0,12q�6�   $	��150��6�   6�   �� 5C   
   -   5        $��	btnDelete��5C   u   $��Удалить��6   $��2��6#   $��1q�60   ���#53377A$��Right=�6Y   $��	0,11,5,12q�6�   6�   5D      5E      