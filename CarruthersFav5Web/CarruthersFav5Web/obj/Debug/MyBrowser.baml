   M S B A M L   `   `   `  ����L  HCarruthersFav5Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:CarruthersFav5WebCarruthersFav5Web  5   	   !    CarruthersFav5Web.MyBrowser   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:CarruthersFav5Web     5   	     � Title$  	MyBrowser��5   	   $	��800��6   $
��1024��6(   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $��80 �6   .+�5   
   (  "System.Windows.Controls.WebBrowser  -   5          Name$ controlWebBrowser��5      $��10,10,9.6,0.4q�60   $��Stretch=�6G   �� 5   
   -   5        $��Go��5      $��Right=�6   $��0,30,0,0q�6:   $��1��6L   $��Center=�6Y   $��75��6t   6   �� 5   
   -   5         ��Name$ comboFavoriteLinks��5      $
��Left=�6/   $��10,27.6,0,0q�6J   $��1��6_   $	��Top=�6l   $	��786��6�   $��37��6�   .@�5      �� $��https://www.google.com��6   $
��Left=�6<   $	��784��6W   �� 5      -   5         ��Name$
 Test��5      $��https://www.reddit.com��6)   $
��Left=�6J   $	��784��6e   5      5      5      