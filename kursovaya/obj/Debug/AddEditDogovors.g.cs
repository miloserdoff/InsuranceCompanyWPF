﻿#pragma checksum "..\..\AddEditDogovors.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7E01D4B197AF4CFE5AAA5A946DE07D01E2F59E15"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using kursovaya;


namespace kursovaya {
    
    
    /// <summary>
    /// AddEditDogovors
    /// </summary>
    public partial class AddEditDogovors : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\AddEditDogovors.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboClients;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\AddEditDogovors.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboType;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\AddEditDogovors.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboSotrud;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\AddEditDogovors.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboFilials;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\AddEditDogovors.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSave;
        
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
            System.Uri resourceLocater = new System.Uri("/kursovaya;component/addeditdogovors.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddEditDogovors.xaml"
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
            this.ComboClients = ((System.Windows.Controls.ComboBox)(target));
            
            #line 39 "..\..\AddEditDogovors.xaml"
            this.ComboClients.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboClients_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ComboType = ((System.Windows.Controls.ComboBox)(target));
            
            #line 40 "..\..\AddEditDogovors.xaml"
            this.ComboType.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboType_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ComboSotrud = ((System.Windows.Controls.ComboBox)(target));
            
            #line 41 "..\..\AddEditDogovors.xaml"
            this.ComboSotrud.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboSotrud_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ComboFilials = ((System.Windows.Controls.ComboBox)(target));
            
            #line 42 "..\..\AddEditDogovors.xaml"
            this.ComboFilials.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboFilials_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnSave = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\AddEditDogovors.xaml"
            this.btnSave.Click += new System.Windows.RoutedEventHandler(this.btnSave_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

