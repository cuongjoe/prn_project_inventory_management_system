   M S B A M L   `   `   `  ����M  IIMS-project-prn221, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:IMS_project_prn221IMS_project_prn221  5   	   $    IMS_project_prn221.OrderWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:IMS_project_prn221     5   	     � Title$  OrderWindow��5   	   $	��450��6   $	��800��6*   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��1* �6   �� 5      $��2* �6   .+�5   
   � $��0��6   $��0,0,10,0q�6    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5      �� $��Chọn Nhà Cung Cấp:��6   �� 5      -   5         ��Name$ supplierComboBox��5      $��1��61   �� 5       $��Nhập Số Lượng:��6   $��2��6-   �� 5!      -   5         ��Name$ quantityTextBox��5!      $��3��6/   �� 5#      $��Chọn Warehouse:��6   $��4��6.   �� 5$      -   5        $ warehouseTextBox��5$      $��5��61   �� 5&      $��Chọn Ngày Nhận:��6   $��6��6.   (  "System.Windows.Controls.DatePicker  5'      -   5          Name$ 
datePicker��5'      $��7��6-   �� 5)      $��Tổng Tiền:��6   $��8��6)   �� 5*      -   5         ��Name$ totalAmountTextBlock��5*      $��9��66   5+      �� 5.   
   -   5         ��Name$ itemListView��5.      $��1��6)    �� View 5/      �� 50      .P�51      �� $��Tên Mặt Hàng��6%   	 �� Width$		 150��6;   �� 52      $��Số Lượng��6%   $	 80��67   �� 53      $��
Đơn Giá��6%   $	 80��66   54      56      57      58      