   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$$  Dodaj pracownika [Twój Numer]��5      $	��350��6+   $	��600��68   
����İ�.��5	      � $��10q�6   .+�5   
   �� $��Dane pracownika��6   $
��Left=�6,   $	��Top=�6G   $	��250��6_   $	��150��6k   .��5      � $��10q�6   .+�5      �� $��Imię:��6   $
��Left=�6(   $	��Top=�6C   �� 5      -   5         ��Name$ FirstNameBox��5      $
��Left=�60   $	��Top=�6K   $	��150��6c   $��0,20,0,0q�6o   �� 5      $��	Nazwisko:��6   $
��Left=�6,   $	��Top=�6G   $��0,50,0,0q�6_   �� 5      -   5        $ LastNameBox��5      $
��Left=�6/   $	��Top=�6J   $	��150��6b   $��0,70,0,0q�6n   �� 5      $��Stanowisko:��6   $
��Left=�6.   $	��Top=�6I   $��	0,100,0,0q�6a   �� 5      -   5         ��Name$ PositionBox��5      $
��Left=�60   $	��Top=�6K   $	��150��6c   $��	0,120,0,0q�6o   .@�5      �� $��	Kierownik��6#   �� 5      $��Starszy programista��6#   �� 5      $��Młodszy programista��6#   �� 5      $��Tester��6#   5      5      5      �� 5   
   $��Generowanie hasła��6   $��Right=�6.   $	��Top=�6J   $	��250��6b   $	��150��6n   .��5      � $��10q�6   .+�5      �� $��Ile znaków?��6   $
��Left=�6.   $	��Top=�6I   �� 5       -   5        $ PasswordLengthBox��5       $
��Left=�65   $	��Top=�6P   $��50��6h   $��90,0,0,0q�6s   $��8��6�   �� 5"      -   5         ��Name$ IncludeUpperLower��5"      $��Małe i wielkie litery��66    d� 	IsChecked$
 TrueY�6V   $��0,30,0,0q�6g   �� 5#      -   5        $ IncludeDigits��5#      $��Cyfry��62   $��0,60,0,0q�6B   �� 5$      -   5        $ IncludeSpecialChars��5$      $��Znaki specjalne��68   $��0,90,0,0q�6R   �� 5&      -   5         ��Name$ GeneratePasswordButton��5&      $��Generuj hasło��69   $
��Left=�6Q   $	��Top=�6l   $	��100��6�   $��
100,60,0,0q�6�   6�   5'      5(      �� 5*   
   -	   5        $ ConfirmButton��5*      $��
Zatwierdź��6(   $��Center=�6<   $��Bottom=�6Y   $	��200��6t   $��30��6�   
�����F�
�������6�   5+      5,      