   M S B A M L   `   `   `  ����?  ;Shop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ShopShop  5   	   -clr-namespace:Shop.ControlsShop.Controls  6*   +clr-namespace:Shop.CommandShop.Command  5   	   -clr-namespace:Shop.ControlsShop.Controls  5	   	       Shop.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   localclr-namespace:Shop  5   	   *controlsclr-namespace:Shop.Controls  6*   (commandclr-namespace:Shop.Command  5   	   +	controls1clr-namespace:Shop.Controls  5	   	     � Title$  
MainWindow��5   	   $	��500��6   $	��900��6)   $	��450��5   	   $	��800��6    � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � AllowsTransparency .   � 
ResizeMode$ CanResizeWithGrip=�5   	    � 	Resources 5       �� 
TargetType   ButtonsTemplate �� CornerRadius  	CardStyle �� 
TargetType	 �� Triggers
 ]� 
Conditions �� Property �� Value �� Property �� Value  HeaderStyle �� Binding �� ElementName �� Path �� Value 
 Footer :� RoutedEvent �� TargetProperty g� Duration	 W� To g� AutoReverse��%"  &	        &	 �     &	 �    &	 �    �� 5   
   " ��6   .R�5      �� $ 5��6   
��� E��$��2q�6>   
������ #��z��5   .   $��50��6P   ._�5      �� $��5q�6!   $��Center=�6,   $��Center=�6I   #��z��6d   5      5      �� 5   
   " ]�6"   	 5      ]� 5      
 5      �� 5       �@J�IsMouseOver . 6;   �� 5       � {� . 69   /�5!      �� 5"       � �� �#FFD5B967   5$      5&      �� 5'   
   " ��6$   �5(      �� 5)       � ��$ 32(�6-   6:   	 5+      �� 5,       6   �� $ SearchTextBox��$ 	IsFocused� True6\   .a�5-      ��  � �� �#FFD5B963   5.      50      �� 52   
   " ��6   �53      �� 54       � ��$ 60��6+   �� 55       � ��$	 250��6*   �� 56       � ��$
 Left=�68   	 58      :� 59      $ 	MouseDown��6   [�5:      �� 5;      .��5<      �� .��5=   "   W� $ Height�62   $ 0:0:1D�6U   $ 80X�6f    . 6n   5>      5?      5A      5C      5D      .��5E      � -   5        $��MainWindowMainGrid��5E      
�������.+�5F   
   ]� ��. ��6   �� $ MainWindowMainGrid��$ ActualHeight�.+�5G      � -   5        $��
FooterGrid��5G      $��Bottom=�6%   .+�5H      �� 
�������
�������$��0,2,0,0q�6D   ._�5J      �� #��[ 6!    �� Orientation$ 
Horizontal=�6A   $��50��6Z   $��Bottom=�6�   
���������6f   �� $ MainWindowMainGrid��$ ActualWidth�.+�5K      �� -   5         ��Name$ AddProductButton��5K   !   $��10,0,0,0q�6[   #��[  6m   .��5L      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ AddBox=�66   
��� E��6D   5M      �� 5N      -   5        $ 
UndoButton��5N   !   $��50��65   
������ $��10,0,0,0q�6t   .��5O        $ UndoVariant=�66   
��� E��6I   5P      �� 5Q      -   5        $ 
RedoButton��5Q   !   $��50��65   
������ $��10,0,0,0q�6t   .��5R        $ RedoVariant=�66   
��� E��6I   5S         Shop.CustomButton  5T      -   5          Name$ CustomCandyButtom��5T   -      Shop.CustomButton   Click$ CustomCandyButtom_OnClick��6H   .��5U        $ 	Candycane=�66   
����i��6G   5V      5W      5X      5Y      � 5Z      $	��Top=�6   .+�5[      �� $	��Top=�6`     MainBorderStyle#���  6x   ��6   �� $ MainWindowMainGrid��$ ActualWidth�.+�5\      �� -   5        $��MainWindowFrameText��5\        �� TextAlignment$ Center=�6;   $
��Bold"�6R   $��Center=�6d   $��18(�6�   
�������$��Resources/Fonts/Lato)�6�     MainWindowFrameText#���  6�   ��6�   �� $ MainWindowMainGrid��$ ActualWidth�5]      �� 5^      $ Vertical=�6   .+�5_      ]� -   5        $��MainWindowTop��5_   6   ��.  $��25��6K   
������ $	��Top=�6�   ��6W   �� $ MainWindowMainGrid��$ ActualWidth�.+�5`      o� $
��left=�6   ��65   Z� .@�5a      m� -	   5         m�Name$ menuLanguage��5a   '   
�������  menuLanguage#���  6�   $
��Bold"�6�   ��6P   �� $ MainWindowTop��$ ActualHeight�6�   m� 5b      -
   5        $ 
menuThemes��5b   '   
�������$��THEMES��6�   $
��Bold"�6�   ��6N   �� $ MainWindowTop��$ ActualHeight�.@�5c   "   m� -   5        $ menuThemesDefault��5c   +   $��Default��6F   6W   m� 5d   "   -   5        $ menuThemesOptimistic��5d   +   $��
Optimistic��6J   6^   5e      5f      �� 5g      -   5        $��MainWindowClose��5g   !   $��50��69   $
��auto��6E   
������ 
������ $��Right=�6�   .��5h        $ Close=�66   
�������6C   5i      �� 5j      -   5        $��MainWindowResize��5j   !   $��50��69   $
��auto��6E   
������ 
������ $��Right=�6�   .��5k        -   5        $��MainWindowResizeIcon��5k   6   $ Resize=�6S   
�������6a   5l      �� 5m      -   5        $��50��5m   #   $
��auto��6.   
������ 
������ $��Right=�6�   .��5n        $ WindowMinimize=�66   
�������6M   5o      5p      5r      5s      �� 5t      -   5        $��MenuGrid��5t      $	��Top=�6)   $ 
Horizontal=�6>   .+�5u      �� 
�������
�������$��0,0,0,2q�6D   ._�5v      A�  A� Columns$ 4��6"   $��75��6.   $��Bottom=�6}   ��6:   �� $ MainWindowMainGrid��$ ActualWidth�.+�5w      ]� -   5        $��CandyDockPanel��5w   $   #��[ 6:   .+�5x      �� -   5        $��CandyTB��5x   (     CandyTB#���  67   $��Bottom=�6X   $��16(�6p   $ Center=�6~   $��Center=�6�   6�   �� 5y      $ ��Resources\Images\candy.png��6$   $	��Top=�6H   $��2q�6]   5z      ]� 5{      -   5        $��ChocolateDockPanel��5{   $   #��[ 6>   .+�5|      �� -   5        $��ChocolateTB��5|   (     ChocolateTB#���  6;   $��16(�6`   $��Bottom=�6n   $ Center=�6�   $��Center=�6�   6�   �� 5}      $$��Resources\Images\chocolate.png��6$   $	��Top=�6L   $��2q�6a   5~      ]� 5      -   5        $��MarmaladeDockPanel��5   $   #��[ 6>   .+�5�      �� -   5        $��MarmaladeTB��5�   (    	 MarmaladeTB#��� 	 6;   $��16(�6`   $��Bottom=�6n   $ Center=�6�   $��Center=�6�   6�   �� 5�      $%��Resources\Images\gummy-bear.png��6$   $	��Top=�6M   $��2q�6b   5�      ]� 5�      -   5        $��WaffleDockPanel��5�   $   #��[ 6;   .+�5�      �� -   5        $��WaffleTB��5�   (    
 WaffleTB#��� 
 68   $��16(�6Z   $��Bottom=�6h   $ Center=�6�   $��Center=�6�   6�   �� 5�      $#��Resources\Images\pancakes.png��6$   $	��Top=�6K   $��2q�6`   5�      5�      5�      5�      ]� 5�      ��. .+�5�      �� $
��Left=�6   $	��200��6/   $��7q�6;   $ 3��6F   ���	#FFF4F4F4$��1q�6n   ._�5�      � .+�5�      �� -   5        $��SelectCategory��5�   c     CategoryHint)  #MaterialDesignThemes.Wpf.HintAssist    Hint#  �  6#   $��30��6y   $��18(�6�   $	��170��6�   $	��Top=�6�   ! �� 
IsEditable! . $��0,20,0,0q�6�   $��0q�6�   .@�5�      �� #���  6+   �� 5�      #���  6+   �� 5�      #��� 	 6+   �� 5�      #��� 
 6+   �� 5�       	 AllTB#���  6+   5�      �� 5�      -   5        $
��Sort��5�   _     SortHint#  �  6#   $��30��6k   $��18(�6w   $	��170��6�   $	��Top=�6�   ! . $��0,75,0,0q�6�   $��0q�6�   .@�5�      ��   PriceByDesc#���  6+   �� 5�        
PriceByAsc#���  6+   �� 5�        Alphabet#���  6+   �� 5�      $��-��6+   5�      5�      5�      �� 5�      .��5�      ]� .+�5�      �� $ 3��6!   $��1q�62   ���	#FFF4F4F4$��50��6]   $	��Top=�6i   $��10q�6~   ._�5�      ]� ��. .+�5�   "   �� -   5        $��SearchDenyButton��5�   )   $��50��6A   $��Right=�6L   $��5q�6c   .��5�   &     $ ClearBox=�6>   5�   #   �� 5�   "   -   5        $��SearchButton��5�   )   $��50��6=   $��Right=�6H   $��5q�6_   .��5�   &     $ Search=�6>   5�   #   �� 5�   "   -   5        $��SearchTextBox��5�   *   #��[ 6?   $	  ...��6d   6�   5�      5�      $   Shop.Controls.ProductContainer  5�      -   5        "  Name$
" Test��5�   4   $
��Left=�6D   5�      5�      5�      5�      5�      5�      