#pragma checksum "..\..\Roster.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B7ED380E57858D6B83B6EEC952991E423BFFEF76"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SimplyRugby;
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


namespace SimplyRugby {
    
    
    /// <summary>
    /// Roster
    /// </summary>
    public partial class Roster : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\Roster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Logout;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Roster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_PlayerProfile;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Roster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_PlayerForm;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Roster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Remove;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Roster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox COMBOBOX_Age;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Roster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid RosterDataGrid;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Roster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_RightArrow;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\Roster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_LeftArrow;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\Roster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LBL_UserType;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\Roster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Refresh;
        
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
            System.Uri resourceLocater = new System.Uri("/SimplyRugby;component/roster.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Roster.xaml"
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
            this.BTN_Logout = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\Roster.xaml"
            this.BTN_Logout.Click += new System.Windows.RoutedEventHandler(this.BTN_Logout_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BTN_PlayerProfile = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\Roster.xaml"
            this.BTN_PlayerProfile.Click += new System.Windows.RoutedEventHandler(this.BTN_PlayerProfile_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BTN_PlayerForm = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\Roster.xaml"
            this.BTN_PlayerForm.Click += new System.Windows.RoutedEventHandler(this.BTN_PlayerForm_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BTN_Remove = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\Roster.xaml"
            this.BTN_Remove.Click += new System.Windows.RoutedEventHandler(this.BTN_Remove_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.COMBOBOX_Age = ((System.Windows.Controls.ComboBox)(target));
            
            #line 18 "..\..\Roster.xaml"
            this.COMBOBOX_Age.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.RosterDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 27 "..\..\Roster.xaml"
            this.RosterDataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.RosterDataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BTN_RightArrow = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\Roster.xaml"
            this.BTN_RightArrow.Click += new System.Windows.RoutedEventHandler(this.BTN_RightArrow_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BTN_LeftArrow = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\Roster.xaml"
            this.BTN_LeftArrow.Click += new System.Windows.RoutedEventHandler(this.BTN_LeftArrow_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.LBL_UserType = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.BTN_Refresh = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\Roster.xaml"
            this.BTN_Refresh.Click += new System.Windows.RoutedEventHandler(this.BTN_Refresh_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

