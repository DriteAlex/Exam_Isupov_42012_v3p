   M S B A M L   `   `   `  ����O  KExam_Isupov_42012_v3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Exam_Isupov_42012_v3Exam_Isupov_42012_v3  5   	   %    Exam_Isupov_42012_v3.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Exam_Isupov_42012_v3     5   	     � Title$  Politex SPORT��5   	   $	��600��6   $	��950��6/    � 	Resources 5
       �� 
TargetType   InterButton �� Property �� Value��%�   &	        �� 5   
   " ��6   .�5      ��  � ��$ 25��6'   �� 5       � ��$	 100��6&   �� 5       � ��$ 25q�6'   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5       � RowDefinitions 5   
   �� 5      $��5* �6   �� 5      $��2* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	DataTable��5   C   $��128,64,118,52q�6   $	��NaN��6*   $	��NaN��67      AutoGenerateColumns .  	   
IsReadOnly	 . 
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Номер��6A   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ��  �� Path$ Id�6A     5      $ Фамилия��6F    6%   �� $ Surname�6F     5      $ Имя��6C    6%   �� $
 Name�6C     5       $ Отчество��6I    6%   �� $ 
Patronymic�6I     5!      $! Серия паспорта��6H    6%   �� $ 	PassportS�6H     5"      $! Номер паспорта��6H    6%   �� $ 	PassportN�6H     5#      $ Инвентарь��6H    6%   �� $ 	Inventory�6H     5$      $ Стоимость��6L      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6_    6%   �� $ CostInventory�6_     5%      $ 
Залог��6F    6%   �� $ Deposit�6F     5&      $ 
Тариф��6E    6%   �� $ Tarrif�6E     5'      $ Дата начала��6L    6%   �� $ DateTimeBegin�6L     5(      $! Дата окончания��6J    6%   �� $ DateTimeEnd�6J     5)      $% Стоимость аренды��6G    6%   �� $ CostRent�6G   5+      �� 5-   
   
�������$	��125��6(   $��1��65    �� Orientation$ 
Horizontal=�6B   $��	0,21,0,21q�6[   $��Center=�6n   .+�5.      �� -   5         ��Name$ BtnOpen��5.      $��Открыть��6<   #��[  6O   �� 5/      -   5        $ BtnAdd��5/      $��Добавить��6;   #��[  6O   �� 50      -   5        $ 	BtnSaveAs��50      $��Сохранить как��6@   #��[  6Y   �� 51      -   5        $ BtnSave��51      $��Сохранить��6<   #��[  6Q   52      53      54      