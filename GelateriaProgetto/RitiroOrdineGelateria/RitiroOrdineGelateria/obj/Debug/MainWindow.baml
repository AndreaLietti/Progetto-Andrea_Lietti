   M S B A M L   `   `   `  ����P  LRitiroOrdineGelateria, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:RitiroOrdineGelateriaRitiroOrdineGelateria  5   	   C ?QrWebCam, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5(clr-namespace:QrWebCam;assembly=QrWebCamQrWebCam 5   	   &     RitiroOrdineGelateria.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:RitiroOrdineGelateria     5   	   =QrWebCam(clr-namespace:QrWebCam;assembly=QrWebCam     5   	   -   5          � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)   .��5
      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ White��6    � Offset$
 0.39Q�6-   � 5      $ 	#FF76B287��6   $ 1Q�61   5       � RowDefinitions 5   
   �� 5      $
��274* �6   �� 5      $
��145* �6   .+�5   
   �� -   5         ��Name$ 	camSelect��5      $��Center=�6&   $��Center=�6A   $��0��6^   $��236,69,513,171q�6k   $��34��6�   $��43��6�   .@�5      �� $	��100��6   $	��100��6!   5        QrWebCam.QrWebCamControl  5   
   -   5          Name$ webCam��5   #   $��331,10,10,10q�6Y   �� 5   
   -   5         ��Name$ dtext��5   J   $��Center=�6   $��Center=�6-   $��389,120,395,-1q�6Y   $��26��6q   $��8��6}   $��1��6�   �� 5   
   -   5        	 ��Name$	 
lblPersone��5      $��0��6$   $
��Left=�60   $��	39,88,0,0q�6K   $	��Top=�6^   $��61��6v   $��1��6�   �� 5   
   $
��Left=�6   $	��177��6+   $	��Top=�68   $	��218��6P   $ ��gelateria-nonna-papera.jpg��6\   5      5       