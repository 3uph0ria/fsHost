﻿#pragma checksum "..\..\..\Pages\Account.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B905FF9CEACAF69E8FF53D0F36044D343C5A380DED79318040374C2EDA692429"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using fsHost.Pages;


namespace fsHost.Pages {
    
    
    /// <summary>
    /// Account
    /// </summary>
    public partial class Account : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 44 "..\..\..\Pages\Account.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnServices;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Pages\Account.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnClients;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\Pages\Account.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnClientService;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\Pages\Account.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCategorys;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\Pages\Account.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btnback;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\Pages\Account.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame AccountFrame;
        
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
            System.Uri resourceLocater = new System.Uri("/fsHost;component/pages/account.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\Account.xaml"
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
            this.BtnServices = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\Pages\Account.xaml"
            this.BtnServices.Click += new System.Windows.RoutedEventHandler(this.BtnServices_Click_1);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BtnClients = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\Pages\Account.xaml"
            this.BtnClients.Click += new System.Windows.RoutedEventHandler(this.BtnClients_Click_1);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnClientService = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\..\Pages\Account.xaml"
            this.BtnClientService.Click += new System.Windows.RoutedEventHandler(this.BtnClientService_Click_1);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnCategorys = ((System.Windows.Controls.Button)(target));
            
            #line 71 "..\..\..\Pages\Account.xaml"
            this.BtnCategorys.Click += new System.Windows.RoutedEventHandler(this.BtnCategorys_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Btnback = ((System.Windows.Controls.Button)(target));
            
            #line 79 "..\..\..\Pages\Account.xaml"
            this.Btnback.Click += new System.Windows.RoutedEventHandler(this.Btnback_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.AccountFrame = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

