   M S B A M L   `   `   `  ����G  CKidsMathGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:KidsMathGameKidsMathGame  5   	       KidsMathGame.GameWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:KidsMathGame     5   	     � Title$  Game Window��5   	   $	��565��6   $	��850��6*   .��5	      � ��5
   
   �� 5       �� ImageSource$  resources/images/dora3.jpg��6    j� Stretch$ UniformToFill=�6B   .+�5   
   �� -   5         ��Name$ image��5      $
��Left=�6   $	��348��6:   $��
317,25,0,0q�6G   $	��Top=�6[   $	��436��6s   $'��!resources/images/speechbubble.png��6   5      �� 5   
   -   5         ��Name$ gameQuestionLabel��5      $�� ��6+   $
��Left=�66   $��
396,85,0,0q�6Q   $	��Top=�6e   $��Center=�6~   $��Center=�6�   $	��247��6�   $��45��6�   $��16(�6�    J� RenderTransformOrigin$ 0.292,0.458&�6�   �� 5   
   -   5         ��Name$ gameAnswerTextBox��5      $
��Left=�6-   $��40��6H   $��420,317,0,0q�6T    �� TextWrapping$
 Wrap=�6i   $	��Top=�6}   $��Center=�6�   $��Center=�6�   $	��197��6�   ���	#FF00DCFF$��24(�6�   6  �� 5   
   -   5         ��Name$ gameCheckAnswerButton��5      $��Check Answer��60   $
��Left=�6G   $��458,393,0,0q�6b   $	��Top=�6w   $	��115��6�   $��39��6�   ���	#FF00F3FF$��Segoe WP Black)�6�   $��14(�6�   6�   �� 5   
   -   5        $ gameAnswerValidationLabel��5      $
��Left=�63   $��Center=�6N   $��Center=�6r   $��435,185,0,0q�6�   $	��Top=�6�   $	��159��6�   $��18(�6�   $
��Bold"�6�   $�� ��6�   �� 5   
   -   5        $ label_ScoreTitleBG��5      $�� ��6,   $
��Left=�67   $��
23,121,0,0q�6R   $	��Top=�6f   $	��131��6~   $	��159��6�   
���  ��$��	ExtraBold"�6�   $��36(�6�   $��Ravie)�6�   ���	#FF00FFF36�   �� 5   
   -   5        $ label_ScoreTitle��5      $��Score��6*   $
��Left=�6:   $��
23,120,0,0q�6U   $��Center=�6i   $��Center=�6�   $	��Top=�6�   $��60��6�   $	��159��6�   
���  ��$��	ExtraBold"�6�   $��36(�6  $��Ravie)�6  	 J� Effect	 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      
   Color$
 Black��6#      	Direction$	 215Q�61      ShadowDepth$ 3Q�6A      Opacity$ 1Q�6Q      
BlurRadius$ 2Q�6]   5      �� 5   
   -   5        $ gameScoreLabel��5      $��0��6(   $
��Left=�64   $��
23,180,0,0q�6O   $��Center=�6c   $��Center=�6�   $	��Top=�6�   $��60��6�   $	��159��6�   
���  ��$��	ExtraBold"�6�   $��36(�6  $��Ravie)�6  $ 0.011,0.541&�6"  	 5        5      $
 Black��6#   $	 215Q�61   $ 3Q�6A   $ 1Q�6Q   $ 2Q�6]   5      �� 5   
   -	   5        $ gameInputErrorLabel��5      $�� ��6-   $��Center=�68   $��Center=�6\   $
��Left=�6~   $��396,146,0,0q�6�   $	��Top=�6�   $	��247��6�   $ 0.493,-0.203&�6�   
���  ��$��18(�6  $
��Bold"�6  	 5        5       $
 Black��6#   $	 215Q�61   $ 2Q�6A   $ 1Q�6Q   $ 2Q�6]   5"      �� 5#   
   -
   5        $ label_ScoreTitleBG_Copy��5#      $�� ��61   $
��Left=�6<   $��701,406,0,0q�6W   $	��Top=�6l   $	��128��6�   $	��141��6�   
���  ��$��	ExtraBold"�6�   $��36(�6�   $��Ravie)�6�   ���	#FF00FFF3$ 4.263,-0.234&�6�   �� 5$   
   -   5        $ gameTimerLabel��5$      $��20��6(   $
��Left=�65   $��701,464,0,0q�6P   $��Center=�6e   $��Center=�6�   $	��Top=�6�   $��60��6�   $	��141��6�   
���  ��$��	ExtraBold"�6�   $��24(�6  $��Ravie)�6  $ 0.011,0.541&�6$  	 5%        5&      $
 Black��6#   $	 215Q�61   $ 3Q�6A   $ 1Q�6Q   $ 2Q�6]   5(      �� 5)   
   -   5        $ label_TimerTitle��5)      $��Timer��6*   $
��Left=�6:   $��701,406,0,0q�6U   $��Center=�6j   $��Center=�6�   $	��Top=�6�   $��60��6�   $	��141��6�   
���  ��$��	ExtraBold"�6�   $��24(�6  $��Ravie)�6  	 5*        5+      $
 Black��6#   $	 215Q�61   $ 3Q�6A   $ 1Q�6Q   $ 2Q�6]   5-      5.      5/      