   M S B A M L   `   `   `  ����G  COrvos_Kliens, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Orvos_KliensOrvos_Kliens  5   	        Orvos_Kliens.PatientWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Orvos_Kliens     5   	     � Title$  Páciensek kezelése��5   	   $	��400��6$   $	��600��61   .��5	      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $	��150 �6#   �� 5      $��* �6#    5      �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    .+�5      �� $��0��6   $��0��6$   $
��Név��61   $��10q�6?   �� 5      -   5         ��Name$ 	NameLabel��5      $��1��6'   $��0��67   $��10q�6D   �� 5!      $��0��6   $��1��6$   $��Lakcím��61   $��10q�6B   �� 5"      -   5        $ AdressLabel��5"      $��1��6)   $��1��69   $��10q�6F   �� 5$      $��0��6   $��2��6$   $��	TAJ szám��61   $��10q�6D   �� 5%      -   5        $ TAJLabel��5%      $��1��6&   $��2��66   $��10q�6C   �� 5'      $��0��6   $��3��6$   $��Panasz��61   $��10q�6B   �� 5(      -   5        $ ComplaintLabel��5(      $��1��6,   $��3��6<   $��10q�6I   $
��60px��6U   �� 5*      $��0��6   $��4��6$   $��
Diagnózis��61   $��10q�6E   �� 5+      -   5         ��Name$ DiagnoseTextBox��5+      $��1��6/   $��4��6?   $��10q�6L   $
��60px��6X   5-      �� 5/   
   $��1��6    �� Orientation$ 
Horizontal=�6"   $��Bottom=�6;   .+�50      �� -   5         ��Name$ UpdateButton��50      $��Módosítás��6+   $��80��6?   $��10q�6J   6V   �� 51      -   5        $ DeleteButton��51      $��Törlés��6+   $��80��6<   $��10q�6G   6S   52      54      55      