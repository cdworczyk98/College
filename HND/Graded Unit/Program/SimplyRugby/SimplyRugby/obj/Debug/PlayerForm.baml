   M S B A M L   `   `   `  ����F  BSimplyRugby, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SimplyRugbySimplyRugby  5   	       SimplyRugby.PlayerForm   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:SimplyRugby     5   	     � Title$  
PlayerForm��5   	   $��315.511��6   $��277.747��6-   .��5	      � .+�5
   
   �� -   5         ��Name$ BTN_Back��5
      $
��Back��6#   $
��Left=�62   $��170,255,0,0q�6M   $	��Top=�6b   $��75��6z   ���	#FF00A40C6�   �� 5   
   -   5        $ BTN_Save��5      $
��Save��6#   $
��Left=�62   $��
90,255,0,0q�6M   $	��Top=�6a   $��75��6y   ���	#FF00A40C6�   �� 5   
   -   5        $ BTN_NewPlayer��5      $��
New Player��6(   $
��Left=�6=   $��
10,255,0,0q�6X   $	��Top=�6l   $��75��6�   ���	#FF00A40C6�   �� 5   
   $
��Name��6   $
��Left=�6   $��	10,81,0,0q�6:   $	��Top=�6M   �� 5   
   $��Date Of Birth��6   $
��Left=�6(   $��
10,185,0,0q�6C   $	��Top=�6W   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ 	DOBPicker��5      $
��Left=�6(   $��
94,185,0,0q�6C   $	��Top=�6W   $��26��6o   $	��151��6{   ���	#FF00A40C6�   �� 5   
   -   5         ��Name$ TXTBOX_Name��5      $
��Left=�6'   $��26��6B   $��	94,81,0,0q�6N    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��151��6�   ���	#FF00A40C���	#FF00A40C �� 	MaxLength$ 20��6�   �� 5   
   $��
SRU Number��6   $
��Left=�6%   $��
10,107,0,0q�6@   $	��Top=�6T   �� 5   
   $��E-Mail��6   $
��Left=�6!   $��
10,133,0,0q�6<   $	��Top=�6P   �� 5   
   -   5        $ 
TXTBOX_SRU��5      $
��Left=�6&   $��26��6A   $��
94,107,0,0q�6M   $
 Wrap=�6a   $	��Top=�6u   $	��151��6�   $ 8��6�   ���	#FF00A40C6�   �� 5   
   -   5        $ TXTBOX_Email��5      $
��Left=�6(   $��26��6C   $��
94,133,0,0q�6O   $
 Wrap=�6c   $	��Top=�6w   $	��151��6�   ���	#FF00A40C6�   �� 5   
   $��SimplyRugby��6   $
��Left=�6&   $��	10,10,0,0q�6A   $	��Top=�6T   $��24(�6l   $
��Bold"�6z   �� 5   
   -   5         ��Name$ 	LBL_Alert��5      $��Adding new player!��6#   $
��Left=�6@   $��	16,50,0,0q�6[   $	��Top=�6n   �� 5   
   $��Parental Consent��6   $
��Left=�6+   $��
10,211,0,0q�6F   $	��Top=�6Z   $	��103��6r   �� 5   
   -	   5         ��Name$ COMBOX_Consent��5      $
��Left=�6+   $��113,211,0,0q�6F   $	��Top=�6[   $	��132��6s   $��26��6   ��5      �� 5       �� EndPoint$	 0,1&�6&   	 �� 
StartPoint$		 0,0&�65   .��5      � 
 � Color$
 	#FFF0F0F0��6#    � Offset$ 0Q�65   � 5      $
 	#FF00A40C��6#   $ 1Q�65   5      .@�5      �� $	��Yes��6   �� 5       $��No��6   �� 5!      $��N/A (Age over 18)��6   5"      �� 5#   
   -
   5        $ BTN_SRUQuestion��5#      $�� ��6*   $
��Left=�65   $��245,110,0,0q�6P   $	��Top=�6e   $��20��6}    ^� InitialShowDelay$	 300��6�    ^� ShowDuration$ 100000��6�    ^� BetweenShowDelay$
 1000��6�    � ToolTip$' !Why can i not edit the SRU field?��6  ��5$      �� 5%       �� ImageSource$ Icon_QuestionMark.png��6   5'      �� 5(   
   $��Emergency Number��6   $
��Left=�6+   $��
10,159,0,0q�6F   $	��Top=�6Z   �� 5)   
   -   5        $ TXTBOX_Phone��5)      $
��Left=�6(   $��26��6C   $��125,159,0,0q�6O   $
 Wrap=�6d   $	��Top=�6x   $	��120��6�   ���	#FF00A40C$ 11��6�   6�   5+      5,      