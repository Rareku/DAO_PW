   M S B A M L   `   `   `  ����=  9UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:UIUI  5   	       UI.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:UI     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)    � 	Resources 5	       �� 
TargetType �� Property �� Value �� ElementName �� Path �� Triggers P� Property	 P� Value��%Z  '��       �� 5
      " ��6
   .�5      ��  �@=�ErrorTemplate 5      �� 5      .R�5      ]� ��. .+�5   	   �� $��	lstErrors��6)   -   5        $��Bottom=�5      ��5   &   �� $ 
ErrTextBox��$( "AdornedElement.(Validation.Errors)���5   
   �� 5      .R�5      �� 
���  ����6   �� *ErrorContent+64   5      5   
   � 5   	   $
��Left=�6   .+�5   
   A� $��20��6   $��20��6   
���  ��
���  ��6:   �� 5   
   
���������6   �� $ 
ErrTextBox��$. (AdornedElement.(Validation.Errors).Count�5   (   5   
   �� 5   	   
���  ��._�5   
   �� $��
ErrTextBox��6$   5   
   5    	   5!      5#      �� 5$       � ��$	 100��6(    5%      P� 5&       �@=�HasError	 . . �5'      ��  � ��$ 	20 2 2 70q�6(   5(      5*      5+      
 � DataContext
 5,         UI.AnimeListViewModel  5-      .��5/      ]� ��. .+�50      �� -   5        $��lstBox��50   "   $
��Left=�6   ��60   �� *Animes+ �� SelectedValue 6O   �� *EditedAnime+��51      �� 52      .R�53      ��  �� Orientation$ 
Horizontal=�6   .+�54      �� $��30��6&   ��6   �� *Day+6&   �� 55      $��70��6'   ��6   �� *Name+6'   �� 56      $��40��6)   ��6   �� *Length+6)   57      58      5:      �� 5;      $��Bottom=�6   $ 
Horizontal=�6'   .+�5<      �� $��
Create Car��66   ��6   �� *CreateNewAnimeCommand+66   �� 5=      ��6   �� *DeleteAnimeCommand+.��63   Delete6;   5>      � 5?       � RowDefinitions 5@      �� 5A      $
��Auto �6   �� 5B      $��* �6   .+�5E      � $��0��6
   
 6   �� *EditedAnime+ � ColumnDefinitions 5F      �� 5G      $
��Auto �6   �� 5H      $��* �6    5J      �� 5K      �� 5L      �� 5M      �� 5N      .+�5Q      �� $��1��6   .��6   Name6   �� 5R      $��1��6   $��1��6   $	��100��6d   ��6+   �� *Name+" �� ValidatesOnNotifyDataErrors . 6u   �� 5S      $��2��6   .��6   Day6   �� 5T      $��2��6   $��1��6   $	��100��6c   ��6+   �� *Day+ . 6t   �� 5U      $��3��6   .��6   Number of episodes6-   �� 5V      $��3��6   $��1��6   $	��100��6f   ��6+   �� *Length+ . 6w   5W      5X      5Y      5Z      