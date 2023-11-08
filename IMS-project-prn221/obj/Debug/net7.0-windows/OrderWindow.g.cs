﻿#pragma checksum "..\..\..\OrderWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8F0D2FB7C7813171AA1D9BD909AC4D12497E102C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using IMS_project_prn221;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace IMS_project_prn221 {
    
    
    /// <summary>
    /// OrderWindow
    /// </summary>
    public partial class OrderWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox supplierComboBox;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox quantityTextBox;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox warehouseTextBox;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker datePicker;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock totalAmountTextBlock;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock totalVTextBlock;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock totalVExistTextBlock;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ProductNameTextBlock;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ProviderTextBlock;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock WarehouseTextBlock;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OrderButton;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView itemListView;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/IMS-project-prn221;component/orderwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\OrderWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.supplierComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 33 "..\..\..\OrderWindow.xaml"
            this.supplierComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.supplierComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.quantityTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 36 "..\..\..\OrderWindow.xaml"
            this.quantityTextBox.SelectionChanged += new System.Windows.RoutedEventHandler(this.quantityTextBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.warehouseTextBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 39 "..\..\..\OrderWindow.xaml"
            this.warehouseTextBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.warehouseTextBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.datePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.totalAmountTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.totalVTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.totalVExistTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.ProductNameTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.ProviderTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.WarehouseTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.OrderButton = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\..\OrderWindow.xaml"
            this.OrderButton.Click += new System.Windows.RoutedEventHandler(this.OrderButton_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.itemListView = ((System.Windows.Controls.ListView)(target));
            
            #line 76 "..\..\..\OrderWindow.xaml"
            this.itemListView.PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.itemListView_PreviewMouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

