   M S B A M L   `   `   `  ����F  BPARTS_ORDER, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:PARTS_ORDER.ViewModelPARTS_ORDER.ViewModel  5   	       PARTS_ORDER.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6custns#clr-namespace:PARTS_ORDER.ViewModel     5   	   _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  5   	     � Title$  PARTS_ORDER��5	   	   $	��450��6   $	��834��6*    � 
ResizeMode$ NoResize=�66    � WindowStartupLocation$ CenterScreen=�6L   *  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5      +  %Microsoft.Xaml.Behaviors.EventTrigger  5   
      	EventName$ Closed��6   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5      4  .Microsoft.Xaml.Behaviors.Core.CallMethodAction     
MethodName$ Close��6!      TargetObject 64   ��  �� RelativeSource �� 	 �� Mode$	 FindAncestor=�
 �� AncestorType

 Window5      .��5      �� .+�5   
   �� $
��Left=�6    �� TextWrapping$
 Wrap=�6-   $	��Top=�6[   $	��145��6s   $��22��6   $
{�True��6�   
������� �� Left$ 37��6�   
 �� Top$	 115��6�   ��6A   �� *
PartName+6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ PartsSellerGrid��5      $	��331��6,   $	 414��69   $ 10��6K   $��Center=�6[   $	��Top=�6x   $	��383��6�      CanUserAddRows$ False��6�      CanUserResizeRows$ False��6�      CanUserDeleteRows$ False��6�      CanUserReorderColumns$ False��6D     CanUserSortColumns$ False��6b     CanUserResizeColumns$ False��6}     
IsReadOnly$
 True��6�  ��6�   �� *PartsSellersTable+ �� SelectedItem 6  �� *SelectedRows+ �� Mode$ TwoWay=�6�  �� 5   
   $��Nazwa części��6   $
��Left=�6'   $	��Top=�6B   $ 37��6Z   $ 89��6k   �� 5   
   $��Wydawca��6   $
��Left=�6"   $��	37,36,0,0q�6=   $	��Top=�6P   �� 5   
   $��Ilość��6   $
��Left=�6    $	��Top=�6;   $ 37��6S   $	 137��6d   �� 5   
   -   5         ��Name$ cmbManufacturer��5      $
��Left=�6,   $��	37,62,0,0q�6G   $	��Top=�6Z   $	��145��6r   $��22��6~    �� Text 6�   �� *	Wydawca+��6�   �� *	Wydawcy+�� 5   
   $��1q�6   $	��187��6%   $ 14��62   $ 36��6C   $	��374��6S   $��Center=�6_   $	��Top=�6|   ��5      �� 5       �� Color$ Black��6"    �� Opacity$	 0.5Q�60   5      �� 5   
   $
 Wrap=�6   $ 37��6&   $	 163��67   $
��Left=�6H   $��Center=�6c   $	��145��6~   $��22��6�   ��6�   �� *Qty+�� 5   
   $��Panel zamówienia��6   $��12(�6+   $
��Left=�69   $	��Top=�6T   $
��Bold"�6l   $	 153��6~   $ 10��6�   �� 5   
   $��1q�6   $��72��6%   $ 14��61   $	 321��6B   $	��390��6S   $��Center=�6_   $	��Top=�6|   ��5       �� 5!      $ Black��6"   $	 0.5Q�60   5#      �� 5$   
   -   5         ��Name$ 	btnLogout��5$      $��Wyloguj��6$   $��33��66   $��69��6B    J� RenderTransformOrigin$ 0.047,0.295&�6M   $
��Left=�6q   $	��Top=�6�   $	 319��6�   $	 345��6�    5%        5&      $ Click��6!   . 5'        $ Close��6)    6<   ��  �� $	 FindAncestor=�

 Window5(      5*      �� 5+   
   $��Panel zarządzania��6   $��12(�6,   $
��Bold"�6:   $
��Left=�6L   $	��Top=�6g   $ 30��6   $	 290��6�   �� 5,   
   -   5         ��Name$ 
tbUserName��5,   8   $ 29��6   $
 Wrap=�6#   $	 358��6h   $	��120��6y   $
��Left=�6�   $	��Top=�6�   
�������$
{�True��6�    �� 
IsReadOnly$
 True��6�   ��6L   �� *
UserLogged+6�   �� 5-   
   $��Użytkownik��6   $ 54��6%   $	 332��66   $
��Left=�6G   $��Center=�6b   $��75��6}   �� 5.   
   $��Rola:��6   $	 216��6    $	 332��62   $
��Left=�6C   $	��Top=�6^   $��38��6v   $ 0.481,0.515&�6�   �� 5/   
   $��Dodaj��6   $	 209��6"   $	 154��64   $��32��6E   $	��145��6Q   $
��Left=�6]   $��Center=�6x   ��6�   �� *AddPartCommand+�� 50   
   $	 209��6   $
 Wrap=�6$   $ 62��6O   $	��145��6_   $
��Left=�6k   $��22��6�   $	��Top=�6�   ��68   �� *Price+6�   �� 51   
   $	 209��6   $
 Wrap=�6$   $	 115��6T   $	��145��6e   $
��Left=�6q   $��Center=�6�   $��22��6�   ��68   �� *
ProductKey+6�   �� 52   
   $
��Cena��6   $	 209��6   $ 36��61   �� 53   
   $��Klucz produktu��6   $	 209��6)   $ 89��6;   �� 54   
   $	 175��6   $
 Wrap=�6$   $	 357��6R   $	��120��6c   $��Center=�6o   $��19��6�   $��Center=�6�   
�������$
 True��6�   ��68   �� *
UserRole+6�   �� 55   
   $��Usuń wybrane��6   $	 417��6(   $	 361��6:   $
��Left=�6K   $��Center=�6f   $	��115��6�   $��32��6�   ��6�   �� *DeleteRowsCommand+�� 56   
   $��Edytuj wiersz��6   $	 548��6)   $	 361��6;   $��32��6L   $	��115��6X   $
��Left=�6d   $��Center=�6   ��6�   �� *EditRowCommand+�� 57   
   $��	Odśwież��6   $	 682��6#   $	 362��65   $��31��6F   $	��115��6R   $��Center=�6^   $��Center=�6{   ��6�   �� *RefreshGridCommand+59      5:      