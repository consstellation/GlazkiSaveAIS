﻿#pragma checksum "..\..\..\Pages\ViewingAgents.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C2A1318FD4A4DE0059E1A81D231C546D7A906727CBDB5CD127CAD68068002BC5"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using GlazkiSave.Pages;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace GlazkiSave.Pages {
    
    
    /// <summary>
    /// ViewingAgents
    /// </summary>
    public partial class ViewingAgents : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\Pages\ViewingAgents.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxSearch;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Pages\ViewingAgents.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox filterBox;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Pages\ViewingAgents.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox sortyBox;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\Pages\ViewingAgents.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button changePriorityButton;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\Pages\ViewingAgents.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listViewAgents;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\..\Pages\ViewingAgents.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addButton;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\..\Pages\ViewingAgents.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button editButton;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\..\Pages\ViewingAgents.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deleteButton;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\..\Pages\ViewingAgents.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock countTextBlock;
        
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
            System.Uri resourceLocater = new System.Uri("/GlazkiSave;component/pages/viewingagents.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\ViewingAgents.xaml"
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
            
            #line 11 "..\..\..\Pages\ViewingAgents.xaml"
            ((GlazkiSave.Pages.ViewingAgents)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.textBoxSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 23 "..\..\..\Pages\ViewingAgents.xaml"
            this.textBoxSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.textBoxSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.filterBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 48 "..\..\..\Pages\ViewingAgents.xaml"
            this.filterBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.filterBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.sortyBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 49 "..\..\..\Pages\ViewingAgents.xaml"
            this.sortyBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.sortyFilter_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.changePriorityButton = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\..\Pages\ViewingAgents.xaml"
            this.changePriorityButton.Click += new System.Windows.RoutedEventHandler(this.changePriorityButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.listViewAgents = ((System.Windows.Controls.ListView)(target));
            
            #line 62 "..\..\..\Pages\ViewingAgents.xaml"
            this.listViewAgents.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listViewAgents_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.addButton = ((System.Windows.Controls.Button)(target));
            
            #line 113 "..\..\..\Pages\ViewingAgents.xaml"
            this.addButton.Click += new System.Windows.RoutedEventHandler(this.addButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.editButton = ((System.Windows.Controls.Button)(target));
            
            #line 114 "..\..\..\Pages\ViewingAgents.xaml"
            this.editButton.Click += new System.Windows.RoutedEventHandler(this.editButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.deleteButton = ((System.Windows.Controls.Button)(target));
            
            #line 125 "..\..\..\Pages\ViewingAgents.xaml"
            this.deleteButton.Click += new System.Windows.RoutedEventHandler(this.deleteButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.countTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

