   M S B A M L   `   `   `  ����E  AAuctionWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:AuctionWPF
AuctionWPF  5   	       AuctionWPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:AuctionWPF     5   	     � Title$  
MainWindow��5   	   $	��420��6   $
��1000��6)   
�������.��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5        $��dataGrid��5
      $
��Left=�6#   $	��254��6>   $��
59,101,0,0q�6K   $	��Top=�6_   $	��287��6w      CanUserAddRows .     AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 name��6C      Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6Q      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *	item_name+6]     5      $ End date��6%   $ * 6Y    .  67   �� *date_deadline+5      5      �� 5   
   -   5        $��	searchTxt��5      $
��Left=�6#   $��23��6>   $��	59,66,0,0q�6J    �� TextWrapping$
 Wrap=�6]   $	��Top=�6q   $	��153��6�   �� 5   
   -   5        $��itmName��5      $	��...��6   $��20(�6-   $
��Left=�6;   $	��Top=�6V   $��
628,65,0,0q�6n   �� 5   
   -   5        $��bidTxt��5      $
��Left=�6    $��24��6;   $��628,269,0,0q�6G   $
 Wrap=�6\   $	��Top=�6p   $	��138��6�   �� 5   
   -   5        $��price��5      $	��...��6   $
��Left=�6+   $��
711,95,0,0q�6F   $	��Top=�6Z   �� 5   
   -   5        $��highBid��5   "   $
��Bold"�6   $	��...��61   $��20(�6?   $
��Left=�6M   $��
858,89,0,0q�6h   $	��Top=�6|   �� 5   
   $��
Place Bid:��6   $
��Left=�6%   $��623,241,0,0q�6@   $	��Top=�6U   �� 5   
   -   5        $
��Bold"�5      $	��Bid��6#   $
��Left=�61   $��771,269,0,0q�6L   $	��Top=�6a   $��75��6y   $��24��6�   6�   �� 5   
   $��Highest bid:��6   $
��Left=�6'   $��
858,69,0,0q�6B   $	��Top=�6V   �� 5   
   -   5        $��ImageViewer1��5      $
��Fill=�6%   $
��Left=�64   $	��290��6O   $��
390,65,0,0q�6\   $	��Top=�6p   $	��197��6�   �� 5   
   -	   5        $��description��5      $
��Left=�6%   $��86��6@   $��628,139,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��218��6�   �� 5   
   -
   5        $
��Bold"�5      $��Search��6#   $
��Left=�64   $��
217,66,0,0q�6O   $	��Top=�6c   $	��129��6{   $��23��6�   6�   �� 5   
   $��Starting price:��6   $
��Left=�6*   $��
628,95,0,0q�6E   $	��Top=�6Y   �� 5   
   $��Highest Bidder:��6   $
��Left=�6*   $��858,139,0,0q�6E   $	��Top=�6Z   �� 5   
   -   5        $��highBidderName��5   0   $
��Bold"�6   $��20(�6"   $	��...��6F   $
��Left=�6T   $��858,165,0,0q�6o   $	��Top=�6�   �� 5   
   -   5        $��TitleTxt��5   0   $��23(�6   $
��Bold"�6   $��Label��6A   $
��Left=�6Q   $��	59,15,0,0q�6l   $	��Top=�6   $��42��6�   �� 5    
   -   5        $��	Sell item��5       $
��Left=�6%   $��876,341,0,0q�6@   $	��Top=�6U   $��93��6m   $��28��6x   6�   5!      5"      