   M S B A M L   `   `   `  ����Z  VInformation_Security_Conference, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:Information_Security_ConferenceInformation_Security_Conference  5   	   0    *Information_Security_Conference.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:Information_Security_Conference     5   	     � Title$  
MainWindow��5   	   $	��600��6   $
��1000��6)   $	��600��66   $
��1000��6F   .��5
      �  � RowDefinitions 5   
   �� 5      $	��120 �6   �� 5      $	��396 �6   �� 5      .+�5   
   �� ���#99FFFF6&   � 5   
   $��0��6    � ColumnDefinitions 5      �� 5      $
��250* �6#   �� 5      $
��293* �6#   �� 5      $
��293* �6#   �� 5      $
��164* �6#   .+�5      �� $��1��6   $��Center=�6)   $��	10,0,10,0q�6D   $��62��6W   .+�5      �� -   5         ��Name$ textBlockDate��5      $��Дата��63   $��0,0,0,5q�6?   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ 
datePicker��5      $��40��63    � 	Resources 5      :  4System.Windows.Controls.Primitives.DatePickerTextBox �� 
TargetType �� Property �� Value��%�   '        �� 5      "  6    .�5      ��  �@��
IsReadOnly . 6;   �� 5       � ��$ 15(�69   �� 5       � ��$ Comic Sans MS)�6;   5       5!      5"      5#      �� 5$      $��2��6   $��Center=�6*   $��	10,0,10,0q�6E   $��52��6X   .+�5%      �� -   5        $ textBlockEvent��5%      $��Направления��64   $��17��6G   $��0,0,0,5q�6S   �� 5&      -   5        	 ��Name$	 ComboBoxEvent��5&      $��62��63   
 �� SelectedValuePath$
 IDEvent��6@    �� DisplayMemberPath$ Title��6\   5'      �� 5*      $��../Image/logo.png��6   $
��Left=�6/   $��5,5,0,5q�6J   $	��110��6[   �� 5-      -   5         ��Name$ buttonSearch��5-   %   $��3��6   $��
Поиск��6;   $��5,20,5,0q�6K   6]   5/      �� 51   
   -   5         ��Name$ 
ListAction��51   !   $��1��6   ��65   �� *Logo+ �� View 52      �� 53      .P�54      �� $��Логотип��6%    �� CellTemplate 55      �� 56      .R�57   "   �� $��80��6@   $	��100��6L   ��6(   �� *Path+6L   58      5:      �� 5;      $-��'Название мероприятия��6%    �� Width$	 600��6D    5<      �� 5=      .R�5>   "   �� ��6,   �� *	Action1+6H   5?      5A      �� 5B      $��Направление��6%   $	 115��6;    5C      �� 5D      .R�5E   "   �� ��6,   �� *Event.Title+6L   5F      5H      �� 5I      $#��Дата проведения��6%   $	 120��6?    5J      �� 5K      .R�5L   "   �� ��6,   �� *Date+6E   5M      5O      5P      5R      �� 5S   
   -   5        $ button��5S      $��2��6   $��Авторизация��6.   $��	0,0,10,10q�6D   $��Right=�6W   $	��162��6s   $��34��6   $��Bottom=�6�   6�   5V      5W      