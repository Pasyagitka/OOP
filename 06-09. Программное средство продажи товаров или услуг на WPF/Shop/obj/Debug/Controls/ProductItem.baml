   M S B A M L   `   `   `  ����?  ;Shop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Shop.ConverterShop.Converter  5      -clr-namespace:Shop.ControlsShop.Controls  5          Shop.Controls.ProductItem   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      ,	Convertorclr-namespace:Shop.Converter  5      'localclr-namespace:Shop.Controls  5      -   5        $
��Item��5      $	��100��5
      $	��500��6   $	��100��5      $��Stretch=�5      $��7q�5      .��5      � -   5        $��MainGrid��5      
�������  � ColumnDefinitions  5   
   �� 5      $	��160 �6   �� 5      .+�5   
   �� -   5        $��RightPartStackPanel��5      $��1��60   $��0, 10, 10, 10q�6@   .+�5      ]� -   5        $��InfoDockPanel��5      ��. .+�5      �� -   5        $��PriceTextBlock��5      $��	Open Sans)�62   $��17(�6I   $
��Bold"�6W   $��Right=�6j    �� TextAlignment$ Right=�6�   $��NoWrap=�6�   $��55��6�   ��6�   ��  �� Path$ Price� �� StringFormat$ {0:C}��6�   �� 5      -   5        $��TitleTextBlock��5      $��	Open Sans)�62   $��17(�6I   $
��Bold"�6W   $
��Left=�6i   ��6   �� $
 Name�5      ]� 5      -   5        $��DescriptionDockPanel��5      ��. .+�5      �� $��Right=�6[   ��6   ��  �� ElementName$ PriceTextBlock��$ ActualWidth�6[   �� 5      -   5        $��ShortDescriptionTextBlock��5      $��CharacterEllipsis=�6=   $��0q�5       $��	Open Sans)�6+   $
 Left=�6B   $	��Top=�6W   $��WrapWithOverflow=�6o   $��15��5   C   ��6    �� $ Description�6C   5       ]� 5!      ��.  .+�5"      �� -	   5        $��DeleteProductButton��5"      $��45��64   $��Right=�6@   
������ 
��� E��$��27��6�   .��5#      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Delete=�6.   $��13��6<   $��13��6H   5$      �� 5%      -
   5        $��EditProductButton��5%      $��45��62   $��Right=�6=   
������ 
��� E��$��27��6�   .��5&        $
 Edit=�6.   $��13��6:   $��13��6F   5'      5(      5)      �� 5*   
   -   5        $��MainItemImage��5*      $��0��6%   $��10q�65   ��6A   �� $ Image�   ImageSourceConverter �� 	Converter# [  5,      5-      