   M S B A M L   `   `   `  ����G  CKidsMathGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:KidsMathGameKidsMathGame  5   	   #    KidsMathGame.FinalScoreWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:KidsMathGame     5   	   -   5          �Name$  HighScoreWindow��5   	    � Title$ High Scores��5   	   $	��565��6   $	��850��6*   .��5	      � ��5
   
   �� 5       �� ImageSource$  resources/images/dora2.jpg��6    j� Stretch$ UniformToFill=�6B   .+�5   
   �� -   5         ��Name$ label��5      $��High Scores��6   $��Center=�65   $
��Left=�6Y   $��	50,30,0,0q�6t   $	��Top=�6�   $��60��6�   $	��792��6�   
���  ��$��	ExtraBold"�6�   $��36(�6�   $��Ravie)�6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$ Black��6#      	Direction$	 215Q�61      ShadowDepth$ 3Q�6A   	   Opacity$	 1Q�6Q   
   
BlurRadius$
 2Q�6]   5      �� 5   
   -   5         ��Name$ topTenScoresListBox��5      $��Center=�6/   $��Center=�6S   $
��Left=�6u   $	��274��6�   $��
10,139,0,0q�6�   $	��Top=�6�   $	��241��6�   $
��Bold"�6�   �� 5   
   -   5        $ 	labelnone��5      $�� ��6#   $
��Left=�6.   $��	10,69,0,0q�6I   $	��Top=�6\   
�������$	��241��6�   $��69��6�   �� 5   
   -   5        $ labelTopScores��5      $��Top 10 Scores��6(   $��Center=�6@   $��Center=�6d   $
��Left=�6�   $��	10,69,0,0q�6�   $	��Top=�6�   
���  ��$��18(�6�   $
��Bold"�6�    J� RenderTransformOrigin$ 0.111,0.284&�6�   $��34��6!  $	��241��6-  $��Snap ITC)�69   5        5      $ Black��6#   $	 215Q�61   $ 3Q�6A   $	 1Q�6Q   $
 2Q�6]   5      �� 5   
   -   5         ��Name$ mainMenuNavButton��5      $��	Main Menu��6,   $��Center=�6@   $��Center=�6d   $
��Left=�6�   $��336,465,0,0q�6�   $	��Top=�6�   $	��241��6�   $��59��6�   ���	#FF09FFFF$��Segoe WP Black)�6  $��24(�69  ���	#FFFF00D16G  �� 5   
   -   5        $ topScoreHeaderLabel��5      $��Center=�6-   $
��Left=�6Q   $��
10,108,0,0q�6l   $	��Top=�6�   $	��241��6�   $��31��6�   �� 5   
   -   5        $ labelnone_Score��5      $�� ��6)   $
��Left=�64   $��
651,69,0,0q�6O   $	��Top=�6c   
�������$	��165��6�   $	��150��6�   $ 0.499,0.084&�6�   �� 5   
   -	   5        $ labelPlayerScore��5      $��Player Score��6*   $��Center=�6A   $��Center=�6e   $
��Left=�6�   $��
651,66,0,0q�6�   $	��Top=�6�   
���  ��$��18(�6�   $
��Bold"�6�   $ 0.111,0.284&�6�   $��34��6#  $	��165��6/  $��Snap ITC)�6;   5        5      $ Black��6#   $	 215Q�61   $ 3Q�6A   $	 1Q�6Q   $
 2Q�6]   5       �� 5!   
   -
   5        $ finalCorrectLabel��5!      $��	Correct: ��6+   $
��Left=�6?   $��651,136,0,0q�6Z   $	��Top=�6o   $	��165��6�   $ 0.528,3.308&�6�   �� 5"   
   -   5        $ finalIncorrectLabel��5"      $��Incorrect: ��6-   $
��Left=�6C   $��651,162,0,0q�6^   $	��Top=�6s   $	��165��6�   $ 0.528,3.308&�6�   �� 5#   
   -   5        $ finalTimeLabel��5#      $��Time: ��6(   $
��Left=�69   $��651,188,0,0q�6T   $	��Top=�6i   $	��165��6�   $ 0.528,3.308&�6�   �� 5$   
   -   5        $ finalNameLabel��5$      $��Name: ��6(   $
��Left=�69   $��651,108,0,0q�6T   $	��Top=�6i   $	��165��6�   $ 0.528,3.308&�6�   5%      5&      