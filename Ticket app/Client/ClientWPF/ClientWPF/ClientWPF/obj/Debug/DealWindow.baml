   M S B A M L   `   `   `  ����  	ClientWPF    ClientWPF.DealWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
DealWindow��5   	   $	��300��6   $	��300��6)   .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      �� 5	      �� 5
      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $	��100 �6   �� 5      �� 5      $��10 �6   �� 5      .+�5   
   ��    
titleStyle#��[  6   $��5q�5      $��0��6   $��0��6,   $��2��6<   Мобильный билет6b   �� 5   
   $��1��6   $��0��6!     smallTitleStyle#��[ 61   $��0,5,0,5q�6Z   № транспорта:6z   �� 5   
   $��1��6   $��1��6!   $��3��61     textStyleTextBox#��[ 6E   ��6o   ��  �� Path$ Transport.number� �� UpdateSourceTrigger$ PropertyChanged=��� 5   
   $��2��6   $��0��6!   #��[ 61   $��0,5,0,5q�6Z   Маршрут:6u   �� 5   
   $��2��6   $��1��6!   #��[ 61   ��6[   �� $ tRoute.City.city1�$ PropertyChanged=��� 5   
   $��2��6   $��2��6"   #��[  65   >6\   �� 5   
   $��2��6   $��3��6!   #��[ 61   ��6[   �� $ tRoute.City1.city1�$ PropertyChanged=�5      5      