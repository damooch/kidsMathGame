   M S B A M L   `   `   `  ����G  CKidsMathGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:KidsMathGameKidsMathGame  5   	   #    KidsMathGame.PlayerInfoWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:KidsMathGame     5   	     � Title$  Player Info��5   	   $	��565��6   $	��850��6*    � 
ResizeMode$ NoResize=�66   .��5	      � ��5
   
   �� 5       �� ImageSource$ resources/images/dora.jpg��6    j� Stretch$ UniformToFill=�6A   .+�5   
   �� -   5         ��Name$ label33��5      $��What's your age?��6!   $��Center=�6<   $
��Left=�6`   $��562,234,0,0q�6{   $	��Top=�6�   $��48��6�   $	��242��6�   ���	#FF00DCFF$��	ExtraBold"�6�   $��24(�6�    J� RenderTransformOrigin$ 0.708,0.534&�6�    J� BitmapEffect 5      F� 5       F� Color$ Black��6)    F� 	Direction$	 320Q�67   	 F� ShadowDepth$	 10Q�6G   
 F� Opacity$
 .5Q�6X    F� Softness$ 9Q�6e   5      �� 5   
   -   5         ��Name$ playerNameTextBox��5      $��Center=�6-   $��Center=�6Q   $
��Left=�6s   $��39��6�   $��562,124,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��242��6�   $ 0.496,1.763&�6�   6  �� 5   
   -   5         ��Name$ savePlayerInfoButton��5      $
��SAVE��6/   $
��Left=�6>   $��643,422,0,0q�6Y   $	��Top=�6n   $��98��6�   $ -0.016,0.729&�6�   $��28��6�   ���	#FF51EC17$��14(�6�   $
��Bold"�6�   6�   �� 5   
   -   5        $ 
label_Copy��5      $��What's your name?��6$   $��Center=�6@   $
��Left=�6d   $��
562,76,0,0q�6   $	��Top=�6�   $��48��6�   $	��242��6�   ���	#FF00DCFF$��	ExtraBold"�6�   $��24(�6�   $ 0.708,0.534&�6�    5      F� 5      $ Black��6)   $	 320Q�67   $	 10Q�6G   $
 .5Q�6X   $ 9Q�6e   5      �� 5   
   -   5        $ playerAgeTextBox��5      $��Center=�6,   $��Center=�6P   $
��Left=�6r   $��39��6�   $��562,287,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��242��6�   $ 0.496,1.763&�6�   6
  �� 5   
   -   5        $ playerNameErrorLabel��5      $�� ��6.   $��Center=�69   $
��Left=�6]   $��548,184,0,0q�6x   $	��Top=�6�   ���	#FFFF0505$
��Bold"�6�   $	��286��6�   $��16(�6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$ Black��6#      	Direction$	 215Q�61      ShadowDepth$ 2Q�6A      Opacity$ 1Q�6Q      
BlurRadius$ 2Q�6]   5      �� 5   
   -   5        $ playerAgeErrorLabel��5      $�� ��6-   $��Center=�68   $
��Left=�6\   $��548,344,0,0q�6w   $	��Top=�6�   ���	#FFFF0505$
��Bold"�6�   $	��286��6�   $��16(�6�    5         5!      $ Black��6#   $	 215Q�61   $ 2Q�6A   $ 1Q�6Q   $ 2Q�6]   5#      5$      5%      