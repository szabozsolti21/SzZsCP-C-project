   M S B A M L   `   `   `  ����G  COrvos_Kliens, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Orvos_KliensOrvos_Kliens  5   	       Orvos_Kliens.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Orvos_Kliens     5   	     � Title$  Orvos klliens��5   	   $	��600��6   $	��800��6,   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��
Páciensek��6   $
��Bold"�61   $��
15,15,15,0q�6C   �� 5   
   -   5         ��Name$ PatientsListBox��5      $��1��6+   $��15q�68    �� SelectionMode$ Single=�6D   6[   �� 5   
   -   5        $��2��5      $��Frissítés��6   $��Right=�62   $	��100��6N   $��
15,0,15,15q�6Z   6n   5      5      