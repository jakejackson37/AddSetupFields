   M S B A M L   `   `   `  ����O  KAddSetupFields.esapi, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:AddSetupFieldsAddSetupFields  5   	       AddSetupFields.DRRWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:AddSetupFields     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Select DRR Parameters��5	   	   $	��400��6'   $	��800��64    � 	Resources 5       �� 
TargetType �� Property �� Value �� 
TargetType ��Name �� Triggers	 P� Property
 P� Value �� 
TargetName ]� 
Conditions �� Property �� Value��%�  '��       '	� x    �� 5   
   ButtonStyle��" ��6%   .�5      ��  � ��$
 Bold"�6+   �� 5       � ��$ 20(�6)   �� 5       � ��$ ./#Segoe UI)�6+   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $ ButtonBorder��6!   #��z��67   ._�5      �� $��Center=�6/   $��Center=�6L   5       5      P� 5      	 � {�
 .  . �5   "   ��  � �� �#F8F9F96?   �� 5   "    � �� �#CACFD26?   �� 5   "   $ ButtonBorder��6)    � �� �#CACFD26Z   �� 5   "   $ ButtonBorder��6)    � ��$ 1q�6^   5      P� 5      	 � {�
 . . �5   "   ��  � �� �#E5E7E96?   �� 5   "    � ��
 �   �6?   �� 5    "   $ ButtonBorder��6)    � �� �#E5E7E96Z   �� 5!   "   $ ButtonBorder��6)    � ��$ 1q�6^   5"      ]� 5#      	MouseOver�� 5$   "   �� 5%   &    � {� . 6E   �� 5&   &    �@J�IsMouseOver . 6G   /�5(   "   �� 5)   &   $ ButtonBorder��6-    � �� �#5DADE26^   �� 5*   &   $ ButtonBorder��6-    � ��$ 2q�6b   5,      ]� 5-      ButtonPressed�� 5.   "   �� 5/   &    � {� . 6E   �� 50   &    � �� . 6E   /�52   "   �� 53   &   $ ButtonBorder��6-    � �� �#5DADE26^   �� 54   &   $ ButtonBorder��6-    � ��$ 3q�6b   56      58      5:      5;      �� 5<   
   RadioButtonStyle��" 	�6*   .�5=      ��  � �� �#F2F3F46+   5>      5?      .��5A      �� ���#922247
�������$��10q�65   ._�5B   
   �  � ColumnDefinitions 5C      �� 5D      $��* �6#   �� 5E      $��* �6#    � RowDefinitions 5G      �� 5H      $
��0.6* �6    �� 5I      $��* �6    �� 5J      $��* �6    �� 5K      $��2* �6    .+�5N      �� -   5        $��Select��5N   1   $��0��6   $��0��6!   $��Select  DRR��6?   $��Right=�6U   $��Center=�6q   
���   �$
��Bold"�6�   $��20(�6�   �� 5O      -   5        $��
Parameters��5O   1   $��0��6   $��1��6!   $��
Parameters��6C   $
��Left=�6X   $��Center=�6s   
���   �$
��Bold"�6�   $��20(�6�   �� 5P      -   5        $
��Bone��5P   1   $��1��6   $��0��6!   $
��Bone��6=   $��Center=�6L   $��Center=�6i   
���   �$
��Bold"�6�   $��20(�6�   $��0,0,0,30q�6�   �� 5Q      -   5        $��Chest��5Q   1   $��1��6   $��1��6!   $��Chest��6>   $��Center=�6N   $��Center=�6k   
���   �$
��Bold"�6�   $��20(�6�   $��0,0,0,30q�6�   �� 5R      -   5        $��ProneBreast��5R   1   $��2��6   $��1��6!   $'��!Include prone breast setup fields��6D   $��Center=�6p   $��Center=�6�   
���   �$��Medium"�6�   $��Italic$�5S      $��18(�6'   $��0,0,0,15q�65   	� 5U      -   5        $��
BoneButton��5U   G   $��1��6   $��0��6'    	� 	GroupName$	 DRR��67   $��Center=�6Y   $��Center=�6v   $��0,30,0,0q�6�   6�   	� 5V      -   5        $��ChestButton��5V   G   $��1��6   $��1��6'   $	 DRR��67   $��Center=�6Z   $��Center=�6w   $��0,30,0,0q�6�   6�   �� 5X      -   5        $��ProneCheckBox��5X   F   $��2��6   $��1��6$    d� 	IsChecked$ FalseY�64   $��Center=�6[   $��Center=�6v   $��0,30,0,0q�6�   �� 5Z      -	   5        $��AddSetupFields��5Z   2   $��3��6   $��1��6"   $��Add Setup Fields��6H   $��80��6c   $	��180��6o   {�.  6�   �� 5\      -
   5        $��loyola_medicine��5\   e   $��0��6   $��3��6$   $	��125��61   $	��250��6>   $��Center=�6J   $N��Hpack://application:,,,/AddSetupFields.esapi;component/LoyolaMedicine.png��6|   6�   5]      5^      5_      