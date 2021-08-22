﻿#pragma checksum "..\..\GamePage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E45D96C5158218C0FC766ACCB1C9FC702126B6C2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GameSokoban;
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


namespace GameSokoban {
    
    
    /// <summary>
    /// GamePage
    /// </summary>
    public partial class GamePage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        /// <summary>
        /// Canvas_GameScene Name Field
        /// </summary>
        
        #line 9 "..\..\GamePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public System.Windows.Controls.Canvas Canvas_GameScene;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\GamePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_LoadLevel;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\GamePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Exit;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\GamePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Label_StepsTaken;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\GamePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Lable_Steps;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\GamePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Restart;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\GamePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Start;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\GamePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Label_Level;
        
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
            System.Uri resourceLocater = new System.Uri("/GameSokoban;component/gamepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\GamePage.xaml"
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
            this.Canvas_GameScene = ((System.Windows.Controls.Canvas)(target));
            
            #line 9 "..\..\GamePage.xaml"
            this.Canvas_GameScene.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.Canvas_GameScene_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Button_LoadLevel = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\GamePage.xaml"
            this.Button_LoadLevel.Click += new System.Windows.RoutedEventHandler(this.Button_LoadLevel_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Button_Exit = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\GamePage.xaml"
            this.Button_Exit.Click += new System.Windows.RoutedEventHandler(this.Button_Back_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Label_StepsTaken = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.Lable_Steps = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.Button_Restart = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\GamePage.xaml"
            this.Button_Restart.Click += new System.Windows.RoutedEventHandler(this.Button_Restart_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Button_Start = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\GamePage.xaml"
            this.Button_Start.Click += new System.Windows.RoutedEventHandler(this.Button_Start_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Label_Level = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

