   M S B A M L   `   `   `  ����F  BSimplyRugby, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SimplyRugbySimplyRugby  5   	       SimplyRugby.Roster   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:SimplyRugby     5   	     � Title$  Roster��5   	   $��311.04��6   $	��410��6(    � 	Resources 5	         
MemberData � Source��%l   &	        � 5
   
   $N HG:\HND\Graded Unit\Program\SimplyRugby\SimplyRugby\bin\Debug\members.xml?�6-   5      .��5      �  � DataContext 6   ��  �� Source# [  .+�5   
   �� -   5         ��Name$ 
BTN_Logout��5      $��Logout��6%   $��0,0,8,10q�66   $��Right=�6a   $��75��6}   $��20��6�   $��Bottom=�6�   ���	#FF00A40C6�   �� 5   
   -   5        $ BTN_PlayerProfile��5      $��Player Profile��6,   $��	0,0,88,35q�6E   $��Right=�6x   $��75��6�   $��20��6�   $��Bottom=�6�   ���	#FF00A40C6�   �� 5   
   -   5        $ BTN_PlayerForm��5      $��Player Form��6)   $��	0,0,88,60q�6?   $��20��6o   $��Bottom=�6{   $��Right=�6�   $��75��6�   ���	#FF00A40C6�   �� 5   
   -   5        $ 
BTN_Remove��5      $��Remove��6>   $��	0,0,88,10q�6O   $��Right=�6b   $��75��6~   $��20��6�   $��Bottom=�6�   ���	#FF00A40C6�   �� 5   
   -   5         ��Name$ COMBOBOX_Age��5      $��10,89,259,0q�6)   ���	#FF00A40C$��27��6�   $	��Top=�6�   .@�5      �� $	��15s��6   �� 5      $	��16s��6   �� 5      $	��18s��6   �� 5      $	��20s��6   �� 5      $��Senior��6   5      �� 5   
   $��	Age Group��6   $��
0,63,279,0q�6$   $��26��68   $	��Top=�6D   $��Right=�6\   $	��112��6x   �� 5   
   $��SimplyRugby��6   $��	10,10,0,0q�6&   $��24(�69   $
��Bold"�6G   $
��Left=�6Y   $	��161��6t   $��48��6�   $	��Top=�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ RosterDataGrid��5      $��10,121,168,10q�6+   ���	#FF00A40C6u   �� 5   
   -   5        $ BTN_RightArrow��5      $�� ��6)   $��Right=�64   $��
0,89,200,0q�6P   $	��Top=�6d   $��27��6|   $��27��6�   ���	#FF00A40C��5      �� 5       �� ImageSource$ Icon_RightArrow.png��6   5       �� 5!   
   -   5        $ BTN_LeftArrow��5!      $�� ��6(   $��
0,89,228,0q�63   $	��Top=�6G   $��27��6_   	 J� RenderTransformOrigin$	 0.5,0.5&�6k   ���	#FF00A40C$��Right=�6�   $��27��6�   z�5"      V� 5#      .~�5$      �� 
 �� ScaleY$
 1Q�6%    �� ScaleX$ -1Q�60   �� 5%       �� AngleY$ 0Q�6$    �� AngleX$ 0Q�6/   �� 5&       �� Angle$ 0Q�6&   T� 5'      5(      ��5*      �� 5+      $ Icon_RightArrow.png��6   5-      �� 5.   
   $��
User Type:��6   $
��Left=�6%   $��	11,45,0,0q�6@   $	��Top=�6S   �� 5/   
   -	   5         ��Name$ LBL_UserType��5/      $�� ��6&   $
��Left=�61   $��	75,45,0,0q�6L   $	��Top=�6_   �� 50   
   -
   5        $ BTN_Refresh��50      $�� ��6&   $��
0,89,168,0q�61   $	��Top=�6E   $��27��6]   $��Right=�6i   $��27��6�   ��51      �� 52      $ Refresh_Icon.png��6   54      55      56      