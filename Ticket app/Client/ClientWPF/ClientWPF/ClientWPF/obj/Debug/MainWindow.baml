   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=MscorlibSystem  5   
    	ClientWPF   ClientWPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   9System&clr-namespace:System;assembly=Mscorlib     5   
     � Title$  
MainWindow��5   	   $	��550��6   $	��535��6)    � 
ResizeMode$ NoResize=�65    � 	Resources 5       �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value   
RoutesView	 �� Source
 �� Current �� Source �� Path��%�   '��       &	  �     �� 5   
   " ��6    5      P� 5	       �@��
IsSelected . . �5
      ��  � ��
 �����63   5      5      �� 5   
   	 5      �� # Z
 $ TransportItems�5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   6*   �� 5      $��70 �6   6*   �� 5      $��3* �6   6*   .+�5   
   ]� ��.  $��0��6*   $��Center=�67   $��Center=�6R   .+�5      �� $
��Left=�6   $��0,0,50,0q�6/   .+�5      �� .��6   Откуда:6!   �� 5      -   5         ��Name$ cb_From��5      $
�� 200��6,   6;   5      �� 5       $��Right=�6   $��50,0,0,0q�61   .+�5!      �� .��6   	Куда:6   �� 5"      -   5        $ cb_To��5"      $	��200��6*   68   5#      5$      ]� 5&   
   ��.  $��1��6*   $��Center=�67   $��Center=�6R   .+�5'      �� $��Center=�6   $��	0,0,50,20q�65   .+�5(      �� .��6   1/Укажите дату отправления:63   (  "System.Windows.Controls.DatePicker  5)      -   5          Name$ dp_Date��5)      60   5*      �� 5+      $��Right=�6   $��Center=�60   .+�5,      �� -   5         ��Name$ bt_Find��5,      $��2��6@   $	��140��6M   $��30��6Y   $��
Поиск��6e   $��50,0,0,0q�6u   5-      5.      �� 50   
   -   5         ��Name$ currentTransport��54      $��3��50      $��8q�6   $��Hidden=�6*   $ �� IsSynchronizedWithCurrentItem$
 TrueY�51      ��52      �� # [  55   <   56      57      