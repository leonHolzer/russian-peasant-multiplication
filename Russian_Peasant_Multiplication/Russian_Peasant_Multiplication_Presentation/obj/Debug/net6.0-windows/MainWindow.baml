   M S B A M L   `   `   `  ����f  bRussian_Peasant_Multiplication_Presentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulli9clr-namespace:Russian_Peasant_Multiplication_Presentation+Russian_Peasant_Multiplication_Presentation  5   	   <    6Russian_Peasant_Multiplication_Presentation.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Klocal9clr-namespace:Russian_Peasant_Multiplication_Presentation     5   	     � Title$$  Russian Peasant Multiplication��5   	   $	��500��60   $	��500��6=   $��/#Montserrat VariableFont)�5	   	    � 	Resources 5       �� 
TargetType �� Property �� Value��%�  '��       '	� �     '�� �     �� 5   
   " ��6   .�5      ��  � ��$ Center=�6;   �� 5       � ��$ Center=�69   �� 5       � �� �#005b9a6,   5      �� 5   
   " 	�6   .�5      ��  � ��$ 5 0 5 0q�6'   5      �� 5   
   " ��6   .�5      ��  � ��
 �����6+   �� 5       � �� �#a5c4006+   �� 5       � �� �#a5c4006,   5      5      .��5      �� -   5         ��Name$ splMain��5      $��Center=�6"   $��	30 0 30 0q�6=   .+�5   
   �� -   5         ��Name$ 
lblHeading��5      $$��Russian Peasant Multiplication��6$   $��18(�6M   $��Center=�6[   $��0 0 0 10q�6x   �� 5   
   -   5        $ splModes��5       �� Orientation$ 
Horizontal=�6'   $��Center=�6@   $��	0 10 0 30q�6]   .+�5      	� -   5         	�Name$ rdbEfficencyMode��5      	 d� 	IsChecked$
	 TrueY�64   .��6E   efficency mode6U   	� 5       -   5        $ rdbHighNumberMode��5       .��65   high number mode6G   5!      � 5#   
   -   5        
 �Name$
 grdInput��5#      $��	0 10 0 10q�6!    � ColumnDefinitions 5$      �� 5%      $��2* �6#   �� 5&      $��1* �6#   �� 5'      $��2* �6#   .+�5*      �� -   5        $ 	lblSymbol��5*      $��1��6'   $��*��67   $��Center=�6C   �� 5+      -   5         ��Name$ txbMultiplicand��5+      $��0��6/   6c   �� 5,      -	   5        $ txbMultiplier��5,      $��2��6-   6_   5-      �� 5/   
   -
   5        $ 	txbResult��5/       �� 
IsReadOnly$
 True��6%   $��	0 10 0 10q�67   �� 51   
   -   5         ��Name$ btnMultiply��51      $��multiply (and verify)��6&    �� 	IsDefault$
 True��6F   $��Center=�6W   6t   52      53      