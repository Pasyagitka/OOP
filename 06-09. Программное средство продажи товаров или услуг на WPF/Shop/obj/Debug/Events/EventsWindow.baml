   M S B A M L   `   `   `  ����?  ;Shop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Shop.ControlsShop.Controls  5   	       Shop.Events.EventsWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   0controlsclr-namespace:Shop.Controls     5   	     � Title$=  7Окно для демонстрации событий��5   	   $	��170��6/   $	��500��6<    � 	Resources 5	         Shop.Controls.TapButton �� 
TargetType �� Property �� Value$   Shop.Controls.PreviewTapButton#   Shop.Controls.DirectTapButton��%I  '        '  �     '  r    �� 5
   
   "  6   .�5      ��  � ��$ 20��6'   �� 5       � ��$	 100��6&   �� 5       � ��$
 Left=�64   �� 5       � ��
 � ���6+   5      �� 5   
   "  6   .�5      ��  � ��$ 20��6'   �� 5       � ��$	 100��6&   �� 5       � ��$
 Left=�64   �� 5       � ��
 � ���6+   5      �� 5   
   "  6   .�5      ��  � ��$ 20��6'   �� 5       � ��$	 100��6&   �� 5       � ��$
 Left=�64   �� 5       � ��
 � ���6+   5      5      .��5      ]� ��.  .+�5   
   �� $��5q�6   .+�5           Shop.Controls.TapButton
   Tap$ OuterBubble_Click��6!   $��60��6;   $	��150��6I   
����i��.��5         $ InnerBubble_Click��65   $	��Tap��6%   65   5!      �� 5"      -   5        $
��txt1��5"      $	��100��6&   $	��150��62   $��Bottom=�6?   5#      �� 5%   
   $��5q�6   .+�5&        $   Shop.Controls.PreviewTapButton   
PreviewTap$ OuterTunnel_Click��6(   $��60��6G   $	��150��6U   
����i��.��5'        $ InnerTunnel_Click��6Q   $��10q�6,   $��
PreviewTap��6:   6Q   5(      �� 5)      -   5        $��txt21��5)      $	��100��6(   $	��150��64   $��Bottom=�6A   5*      �� 5,   
   $��5q�6   .+�5-        #   Shop.Controls.DirectTapButton   	DirectTap$ OuterDirect_Click��6'   $��60��6F   $	��150��6T   
����i��.��5.        $ InnerDirect_Click��6O   $��10q�6+   $��	DirectTap��69   6O   5/      �� 50      -   5        $��txt31��50      $	��100��6'   $	��150��63   $��Bottom=�6@   51      52      53      