﻿#pragma checksum "..\..\GameWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4AA0CE458B28F120DCA22BF89BDB9043"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using KidsMathGame;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace KidsMathGame {
    
    
    /// <summary>
    /// GameWindow
    /// </summary>
    public partial class GameWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image image;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label gameQuestionLabel;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox gameAnswerTextBox;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button gameCheckAnswerButton;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label gameAnswerValidationLabel;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label_ScoreTitleBG;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label_ScoreTitle;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label gameScoreLabel;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label gameInputErrorLabel;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label_ScoreTitleBG_Copy;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label gameTimerLabel;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label_TimerTitle;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/KidsMathGame;component/gamewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\GameWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.image = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.gameQuestionLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.gameAnswerTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 16 "..\..\GameWindow.xaml"
            this.gameAnswerTextBox.KeyDown += new System.Windows.Input.KeyEventHandler(this.gameAnswerTextBox_KeyDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.gameCheckAnswerButton = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\GameWindow.xaml"
            this.gameCheckAnswerButton.Click += new System.Windows.RoutedEventHandler(this.gameCheckAnswerButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.gameAnswerValidationLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.label_ScoreTitleBG = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.label_ScoreTitle = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.gameScoreLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.gameInputErrorLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.label_ScoreTitleBG_Copy = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.gameTimerLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 12:
            this.label_TimerTitle = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

