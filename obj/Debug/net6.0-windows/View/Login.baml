   M S B A M L   `   `   `  ����F  BPARTS_ORDER, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:PARTS_ORDER.ViewPARTS_ORDER.View  5   	   ?$clr-namespace:PARTS_ORDER.ComponentsPARTS_ORDER.Components  5   	       PARTS_ORDER.View.Login   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:PARTS_ORDER.View     5   	   _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  5   	   5
components$clr-namespace:PARTS_ORDER.Components  5   	     � Title$  Login��5
   	    � 
ResizeMode$ NoResize=�6   $	��250��6-   $	��250��69    � WindowStartupLocation$ CenterScreen=�6F    � 	Resources 5          BooleanToVisibilityConverter��%   &	        �� 5   
   6N   5      y�5      �� 5   
    �� Path$ LoginVisibility�6    �� Mode$ TwoWay=�6)    �� 	Converter# [  67   .��5      �  � ColumnDefinitions 5   
   �� 5      $��9* �6   �� 5      $	��16* �6   .+�5   
   �� $��Nazwa użytkownika��6   $
��Left=�6,   $��	68,24,0,0q�6G   $	��Top=�6Z   $��2��6r   $��26��6�   $	��114��6�   �� 5   
   -   5         ��Name$ tbName��5      $
��Left=�6"   $��	50,50,0,0q�6=   	 �� TextWrapping$
	 Wrap=�6P   $	��Top=�6�   $	��150��6�   $��21��6�   $��2��6�   ��6d   �� *TextBoxUserText+6�   �� 5   
   $��Hasło��6   $
��Left=�6    $��	14,91,0,0q�6;   $	��Top=�6N   $��1��6f   $��26��6v   $��40��6�   �� 5   
   -   5        
 ��Name$
 btnLogin��5      $��ZALOGUJ��6#   $
��Left=�65   $��	0,159,0,0q�6P   $	��Top=�6c   $��25��6{   $��74��6�   $��1��6�   ��6�   �� *btnLoginCommand+6�   0   *PARTS_ORDER.Components.BindablePasswordBox  5   
   $��2��6N   $��
50,117,0,0q�6b   
����������	#FF6D6D6D$��1,1,1,1q�6�   $��21��6�   $	��Top=�6�   $	��150��6�   $
|�True��6�   $
��True��6�   $
��Left=�6     Password 6)   �� *TextBoxPassText+6  5      5      