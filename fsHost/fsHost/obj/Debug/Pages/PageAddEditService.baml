   M S B A M L   `   `   `  ����A  =fsHost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:fsHost.PagesfsHost.Pages  5      %    fsHost.Pages.PageAddEditService   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:fsHost.Pages     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     N� Title$  PageAddEditService��5
      .��5      � $��15q�6    � RowDefinitions 5      �� 5   
   $��* �6   �� 5   
   $��* �6   �� 5   
   $��* �6   �� 5   
   $��* �6   �� 5   
   $��* �6   �� 5   
   $��* �6   �� 5   
   $��* �6   �� 5   
   $��* �6   �� 5   
   $��* �6   �� 5   
   $��* �6   .+�5      �� $��Center=�6   $��0��6,   $D��>Добавление/редактирование товара��5   	    $   MaterialDesignHeadline5TextBlock#��[  5      �� 5   
   -   5        $
��Name��5      $��1��5      $	��600��5         MaterialDesignFilledTextBox#��[ 5!      $��Center=�5"       �� AcceptsReturn .  �� TextWrapping$
 Wrap=�5$      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Наименование��5%      $��0 0 20 0q�5&      ��5      �� *Name+{�5'      ��  �� Path$ 	IsChecked� �� ElementName$0 *MaterialDesignFilledTextBoxEnabledComboBox���� 5*   
   -   5        $
��Cost��5,      $��2��5+      $	��600��5.      #��[ 5/      $��Center=�50       . $
 Wrap=�52      $ Стоимость��53      $��0 0 20 0q�54      ��5-      �� *Cost+{�55      �� $ 	IsChecked�$0 *MaterialDesignFilledTextBoxEnabledComboBox���� 57   
   -   5         ��Name$ CBoxServices��5>      $ Категория��58      $	��600��59      $��0 0 20 0q�5:      $��Center=�5;      $��3��5<       �� DisplayMemberPath$
 Name��5?      	 �� SelectedItem	 5=      �� *Categoris.Id+5?      �� 5B   
   -   5        $��MemoryGB��5D      $��5��5C      $	��600��5F      #��[ 5G      $��Center=�5H       . $
 Wrap=�5J      $ SSD ГБ��5K      $��0 0 20 0q�5L      ��5E      �� *
MemoryGB+{�5M      �� $ 	IsChecked�$0 *MaterialDesignFilledTextBoxEnabledComboBox���� 5P   
   -   5        $��Description��5R      $��6��5Q      $	��600��5T      #��[ 5U      $��Center=�5V       . $
 Wrap=�5X      $ Описание��5Y      $��0 0 20 0q�5Z      ��5S      �� *Description+{�5[      �� $ 	IsChecked�$0 *MaterialDesignFilledTextBoxEnabledComboBox���� 5]   
   -   5        $	��Img��5_      $��7��5^      $	��600��5a      #��[ 5b      $��Center=�5c       . $
 Wrap=�5e      $ Картинка��5f      $��0 0 20 0q�5g      ��5`      �� *Img+{�5h      �� $ 	IsChecked�$0 *MaterialDesignFilledTextBoxEnabledComboBox���� 5j   
   -   5        $��
CountSites��5l      $��8��5k      $	��600��5n      #��[ 5o      $��Center=�5p       . $
 Wrap=�5r      $ Кол-во Сайтов��5s      $��0 0 20 0q�5t      ��5m      �� *
CountSites+{�5u      �� $ 	IsChecked�$0 *MaterialDesignFilledTextBoxEnabledComboBox���� 5w   
   $��Center=�6   $��9��60   $��Center=�6>   
 �� Orientation$
 
Horizontal=�6[   .+�5x   
   �� -   5        $��BtnAddservice��5x      $��Добавить��6B   6X   5y      5z      5{      