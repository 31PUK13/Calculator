   M S B A M L   `   `   `  ����E  ACalculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Calculator
Calculator  5   	       Calculator.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Calculator     5   	   -   5          �Name$  TextBlockTxt1��5   	    � Title$ 
MainWindow��5   	   $	��760��6   $	��480��6)    � 
ResizeMode$ NoResize=�6c   ���	#FF18295C��6y   Z� .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      $��2* �6   �� 5      $��2* �6   �� 5      �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      .+�5    
   �� -   5         ��Name$ History��5       $��NoWrap=�6%   $��1��6;   $��5��6K   $��1��6`    �� TextAlignment$ Right=�6m   $��Center=�6�   $��Right=�6�   $��Courier New)�6�   $��28(�6�   $
��Bold"�6�   ���	#FF97A9C36�   �� 5!   
   -   5        $ Input��5!      $��NoWrap=�6#   $��1��69   $��5��6I   $��2��6^   $ Right=�6k   $��Center=�6�   $��Right=�6�   $��Courier New)�6�   $��48(�6�   $
��Bold"�6�   $��0��6�   ���	#FFFBFFFE6�   �� 5#   
   -   5        $��MC��5#      $��1��6   $��4��6.   $��Courier New)�6T   $
��Bold"�6w   $��36(�6�   ���	#FF97AAC1|�.  ��6�   Z� ��6�   Z� 6�   �� 5$   
   -   5        $��MR��5$      $��2��6   $��4��6.   $��Courier New)�6S   $
��Bold"�6v   $��36(�6�   ���	#FF97AAC1|�.  ��6�   Z� ��6�   Z� 6�   �� 5%   
   -   5        $��MS��5%      $��3��6   $��4��6.   $��Courier New)�6S   $
��Bold"�6v   $��36(�6�   ���	#FF97AAC1|�.  ��6�   Z� ��6�   Z� 6�   �� 5&   
   -   5        $��M+��5&      $��4��6   $��4��6.   $��Courier New)�6S   $
��Bold"�6v   $��36(�6�   ���	#FF97AAC1|�.  ��6�   Z� ��6�   Z� 6�   �� 5'   
   -   5        $��M-��5'      $��5��6   $��4��6.   $��Courier New)�6T   $
��Bold"�6w   $��36(�6�   ���	#FF97AAC1|�.  ��6�   Z� ��6�   Z� 6�   �� 5)   
   -	   5        $	��←��5)      $��1��6   $��5��6-   $��Courier New)�6W   $
��Bold"�6z   $��36(�6�   ���	#FF97AAC1|�.  ��6�   Z� ��6�   Z� 6�   �� 5*   
   -
   5        $��CE��5*      $��2��6   $��5��6.   $��Courier New)�6S   $
��Bold"�6v   $��36(�6�   ���	#FF97AAC1|�.  ��6�   Z� ��6�   Z� 6�   �� 5+   
   -   5        $��C��5+      $��3��6   $��5��6-   $��Courier New)�6P   $
��Bold"�6s   $��36(�6�   ���	#FF97AAC1|�.  ��6�   Z� ��6�   Z� 6�   �� 5,   
   -   5        $��±��5,      $��4��6   $��5��6-   $��Courier New)�6R   $
��Bold"�6u   $��36(�6�   ���	#FF97AAC1|�.  ��6�   Z� ��6�   Z� 6�   �� 5-   
   -   5        $	��√��5-      $��5��6   $��5��6-   $��Courier New)�6L   $
��Bold"�6o   $��36(�6�   ���	#FF97AAC1|�.  ��6�   Z� ��6�   Z� 6�   �� 5/   
   -   5        $��7��5/      $��1��6   $��6��6-   $��Courier New)�6N   $��36(�6q   ���	#FF97AAC1|�.  ��6   Z� ��6�   Z� 6�   �� 50   
   -   5        $��8��50      $��2��6   $��6��6-   $��Courier New)�6N   $��36(�6q   ���	#FF97AAC1|�.  ��6   Z� ��6�   Z� 6�   �� 51   
   -   5        $��9��51      $��3��6   $��6��6-   $��Courier New)�6N   $��36(�6q   ���	#FF97AAC1|�.  ��6   Z� ��6�   Z� 6�   �� 52   
   -   5        $��/��52      $��4��6   $��6��6-   $��Courier New)�6W   $
��Bold"�6z   $��36(�6�   ���	#FF97AAC1|�.  ��6�   Z� ��6�   Z� 6�   �� 53   
   -   5        $��%��53      $��5��6   $��6��6-   $��Courier New)�6O   $
��Bold"�6r   $��36(�6�   ���	#FF97AAC1|�.  ��6�   Z� ��6�   Z� 6�   �� 55   
   -   5        $��4��55      $��1��6   $��7��6-   $��Courier New)�6N   $��36(�6q   ���	#FF97AAC1|�.  ��6   Z� ��6�   Z� 6�   �� 56   
   -   5        $��5��56      $��2��6   $��7��6-   $��Courier New)�6N   $��36(�6q   ���	#FF97AAC1|�.  ��6   Z� ��6�   Z� 6�   �� 57   
   -   5        $��6��57      $��3��6   $��7��6-   $��Courier New)�6N   $��36(�6q   ���	#FF97AAC1|�.  ��6   Z� ��6�   Z� 6�   �� 58   
   -   5        $��*��58      $��4��6   $��7��6-   $��Courier New)�6W   $
��Bold"�6z   $��36(�6�   ���	#FF97AAC1|�.  ��6�   Z� ��6�   Z� 6�   �� 59   
   -   5        $	��1/x��59      $��5��6   $��7��6/   $��Courier New)�6R   $
��Bold"�6u   $��36(�6�   ���	#FF97AAC1|�.  ��6�   Z� ��6�   Z� 6�   �� 5;   
   -   5        $��1��5;      $��1��6   $��8��6-   $��Courier New)�6N   $��36(�6q   ���	#FF97AAC1|�.  ��6   Z� ��6�   Z� 6�   �� 5<   
   -   5        $��2��5<      $��2��6   $��8��6-   $��Courier New)�6N   $��36(�6q   ���	#FF97AAC1|�.  ��6   Z� ��6�   Z� 6�   �� 5=   
   -   5        $��3��5=      $��3��6   $��8��6-   $��Courier New)�6N   $��36(�6q   ���	#FF97AAC1|�.  ��6   Z� ��6�   Z� 6�   �� 5>   
   -   5        $��-��5>      $��4��6   $��8��6-   $��Courier New)�6W   $
��Bold"�6z   $��36(�6�   ���	#FF97AAC1|�.  ��6�   Z� ��6�   Z� 6�   �� 5?   
   -   5        $��=��5?      $��5��6   $��8��6-   $��2��6:   $��Courier New)�6_   $
��Bold"�6�   $��36(�6�   ���	#FF97AAC1|�.  ��6�   Z� ��6�   Z� 6�   �� 5A   
   -   5        $��0��5A      $��1��6   $��2��6-   $��9��6A   $��Courier New)�6b   $��36(�6�   ���	#FF97AAC1|�.  ��6�   Z� ��6�   Z� 6�   �� 5B   
   -   5        $��.��5B      $��3��6   $��9��6-   $��Courier New)�6M   $��36(�6p   ���	#FF97AAC1|�.  ��6~   Z� ��6�   Z� 6�   �� 5C   
   -   5         ��Name$ ChoseOperationClick��5C      $��+��6.   $��4��6:   $��9��6J   $��Courier New)�6t   $
��Bold"�6�   $��36(�6�   ���	#FF97AAC1|�.  ��6�   Z� ��6�   Z� 6�   �� 5D   
   -    5        $ Memory��5D      $��1��6$   $
��Left=�64   $��2��6O   $
��Wrap=�6\   $��M��6p   $��Bottom=�6y   $��24(�6�    J� Opacity$ 0Q�6�   $��Courier New)�6�   ���	#FF97A9C3$
��Bold"�6�   �� 5E   
   $��1��6   $��3��6"   $��5��60   ���	#FF14143D6D   5F      5G      