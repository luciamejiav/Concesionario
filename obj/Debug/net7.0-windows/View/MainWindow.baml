   M S B A M L   `   `   `  ����H  DConcesionario, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ConcesionarioConcesionario  5   	   #    Concesionario.View.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Concesionario     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $	��150 �6   �� 5      .+�5   
   `� $��0��6   $��0��6#   $��2��5      .�5      c� .@�5      �� $��Agregar/Modificar��6   ��65   �� *ComandoNuevoCoche+�� 5      $��Eliminar��6   ��6,   �� *ComandoEliminarCoche+{�6U   �� *ActivarEliminacionYEdicion+�� 5      $��Guardar Todo��6   ��60   �� *ComandoGuardarTodo+5      5      �� 5   
   -   5         ��Name$ listBoxCoches��5      $��1��6)   $��0��66   ��6F   �� *ListaCoches+ �� SelectedItem 5       �� *CocheSeleccionado+ �� Mode$ TwoWay=���5!      �� 5"      .R�5#      ��  �� Orientation$ Vertical=�6!   .+�5$      �� $��20(�6<   ��6$   �� *Modelo+6<   �� 5%      $��20(�6;   ��6$   �� *Marca+6;   �� 5&      $��20(�6-   ��6   �� *	TipoMotor+6-   �� 5'      $��20(�6)   ��6   �� *Stock+6)   �� 5(      $��20(�6<   ��6$   �� *Precio+6<   �� 5)      $��20(�69   ��6$   �� *Año+69   5*      5+      5-      � 50   
   $��0q�6   $��1��6   $��1��6'    � 	Resources 51       �� 
TargetType	 �� Property
 �� Value��%3  '��       '�� �     �� 52      " ��6   .�53      �� 	 � ��$
 0,0,10,0q�6/   �� 54      	 � ��$
 Center=�55      �� 56      	 � ��$
 Right=�57      58      �� 59      " ��6   .�5:      �� 	 � ��$
 0,0,10,0q�6/   �� 5;      	 � ��$
 Center=�5<      5=      5>       5?      �� 5@      $
��Auto �6    �� 5A      $
��Auto �6    �� 5B      $
��Auto �6    �� 5C      $
��Auto �6    �� 5D      $
��Auto �6    �� 5E      $
��Auto �6    �� 5F      $
��Auto �6    �� 5G      $
��Auto �6    �� 5H      $
��Auto �6    �� 5I      $
��Auto �6    �� 5J      $
��Auto �6    �� 5K       5M      �� 5N      $
��Auto �6#   �� 5O      $��* �6#   .+�5R      �� $��Modelo:��6   $��1��6&   �� 5S      $��1��6   $��1��6&   ��63   �� *Modelo+$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5T      $��Marca:��6   $��2��6%   �� 5U      $��1��6   $��2��6&   ��63   �� *Marca+$ TwoWay=�$ PropertyChanged=��� 5V      $��Tipo de Motor:��6   $��3��6-   �� 5W      $��1��6   $��3��6&   ��63   �� *	TipoMotor+$ TwoWay=�$ PropertyChanged=��� 5X      $��Stock:��6   $��4��6%   �� 5Y      $��1��6   $��4��6&   ��63   �� *Stock+$ TwoWay=�$ PropertyChanged=��� 5Z      $��Precio:��6   $��5��6&   �� 5[      $��1��6   $��5��6&   ��63   �� *Precio+$ TwoWay=�$ PropertyChanged=��� 5\      $��Año:��6   $��6��6#   �� 5]      $��1��6   $��6��6&   ��63   �� *Año+$ TwoWay=�$ PropertyChanged=�5_      5a      5b      