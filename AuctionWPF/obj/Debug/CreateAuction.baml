   M S B A M L   `   `   `  ����E  AAuctionWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:AuctionWPF
AuctionWPF  5   	       AuctionWPF.CreateAuction   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:AuctionWPF     5   	     � Title$  CreateAuction��5   	   $	��370��6   $	��800��6,   .��5	      � .+�5
   
   �� $
��Bold"�6   $��25(�6"   $��List an item to sell��60   $
��Left=�6O   $��	25,14,0,0q�6j   $	��Top=�6}   �� 5   
   $��
Item Name:��6   $
��Left=�6%   $��	30,69,0,0q�6@   $	��Top=�6S   �� 5   
   -   5        $��	itemNamez��5      $
��Left=�6#   $��23��6>   $��
35,100,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $	��Top=�6s   $	��214��6�   �� 5   
   $��Start Price:��6   $
��Left=�6'   $��
31,137,0,0q�6B   $	��Top=�6V   �� 5   
   -   5        $��
startPrice��5      $
��Left=�6$   $��23��6?   $��
35,168,0,0q�6K   $
 Wrap=�6_   $	��Top=�6t   $	��120��6�   �� 5   
   $��Description:��6   $
��Left=�6'   $��
31,211,0,0q�6B   $	��Top=�6V   �� 5   
   -   5        $��itemDESC��5      $
��Left=�6"   $��66��6=   $��
35,242,0,0q�6I   $
 Wrap=�6]   $	��Top=�6q   $	��214��6�   �� 5   
   -   5        $��Upload Picture��5      $
��Left=�6*   $��292,242,0,0q�6E   $	��Top=�6Z   $	��141��6r   $��66��6~   6�   �� 5   
   -   5        $��imgPhoto��5      $
��Left=�6    $	��158��6;   $��
292,69,0,0q�6H   $	��Top=�6\   $	��141��6t   (  "System.Windows.Controls.DatePicker  5   
   -   5        $��
datePicked��5      $
��Left=�6'   $��481,100,0,0q�6B   $	��Top=�6W   $	��120��6o   $��23��6{      FirstDayOfWeek$ Monday=�6�      SelectedDateFormat$ Short=�6�   �� 5   
   -   5        $��
timePicked��5      $
��Left=�6$   $��23��6?   $��481,166,0,0q�6K   $
 Wrap=�6`   $��12:12:12��6t   $	��Top=�6�   $	��120��6�   �� 5   
   $%��Type a time in format(hh:mm:ss)��6   $
��Left=�6:   $��475,137,0,0q�6U   $	��Top=�6j   �� 5   
   $��Deadline Date and time:��6   $
��Left=�62   $��
475,69,0,0q�6M   $	��Top=�6a   �� 5   
   -   5        $��listItem��5      $��	List Item��6!   $
��Left=�65   $��481,242,0,0q�6P   $	��Top=�6e   $	��271��6}   $��66��6�   6�   5      5      