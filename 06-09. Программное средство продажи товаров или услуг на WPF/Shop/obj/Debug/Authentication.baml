   M S B A M L   `   `   `  ����?  ;Shop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ShopShop  5   	   +clr-namespace:Shop.CommandShop.Command  5   	       Shop.Authorization   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   localclr-namespace:Shop  5   	   )commandsclr-namespace:Shop.Command  5   	     � Title$  Authorization��5
   	   $	��450��6   $	��380��6,    � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � AllowsTransparency . 
������  � 
ResizeMode$ NoResize=�5   	    � 	Resources 5       �� 
TargetType   AuthButtons �� Property �� Value��%�   &	        �� 5   
   " ��6   .�5      ��  � ��
 �����6+   �� 5       � ��$	 100��6&   �� 5       � ��$ 40��6'   5      5      	 J� CommandBindings	 5      )  #System.Windows.Input.CommandBinding  5   
   -   5        
   Command$!
 commands:CustomCommand.Exit��5      6c   .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      �� 5      .+�5"      ��  �� CornerRadius$ 10��6   $��2��6'   ��5#      �� 5$      .��5%      �  � Color$ #FF9900��6'    � Offset$	 0.0Q�67   � 5&      $ #FF559A��6'   $ 1Q�67   5'      ._�5*      �� $��40��6   $
��Auto��6$   $��170,10,170,420q�62   $!��commands:CustomCommand.Exit��6J    � ToolTip$ 	Exit: Esc��6p   .��5+      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	CloseBold=�6.   $��10��6?   $��Center=�6J   $��Center=�6e   5,      5-      �� 5/      $��Center=�6   .+�50      �� -   5        $��SignInTB��50        SignInTB#���  51      $��Light"�52      $��	helvetica)�53      $��38(�54      
�������$��Center=�56      57      �� 59      $��1��6   .+�5:      ��  �� Orientation$ 
Horizontal=�6   .+�5;      �� -   5        $��LoginTextBox��5;      $��	Helvetica)�5<      $��Light"�5=      $��20(�5>      $��Center=�5?      
�������
������ $��0q�5B      $	��235��5C      $
��Left=�5D       J� Opacity$	 0.5Q�5E      $��25��5F      $��63,0,0,0q�5G        5H      $ Account=�6.   $��Center=�5I   .   $��Center=�5J   .   
�������5K   .   5L      �� 5M      $	��250��6   $��2��6&   
�������$	 0.5Q�6D   �� 5O      $ 
Horizontal=�6   $��0,20,0,0q�66   .+�5P      G� -   5        $��PasswordBox��5P   "   $��	Helvetica)�5Q   "   $��Light"�5R   "   $��20(�5S   "   $��Center=�5T   "   
�������
������ $��0q�5W   "   $	��235��5X   "   $
��Left=�5Y   "   $	 0.5Q�5Z   "   $��25��5[   "   $��63,0,0,0q�5\   "     5]      $ Password=�6.   $��Center=�5^   .   $��Center=�5_   .   
�������5`   .   5a      �� 5b      $	��250��6   $��2��5c      
�������$	 0.5Q�5e      �� 5h      $ 
Horizontal=�6   $��0,50,0,0q�66   .+�5j      �� -   5        $��LoginButton��5j      #��[  60     LoginButton#���  6U   $��	60,0,60,0q�6~   6�   �� 5k      -   5        $��RegisterButton��5k      #��[  63     RegisterButton#���  6X   6�   5l      5n      5p      5q      5r      