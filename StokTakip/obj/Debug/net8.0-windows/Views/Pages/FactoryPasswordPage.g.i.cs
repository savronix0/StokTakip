﻿#pragma checksum "..\..\..\..\..\Views\Pages\FactoryPasswordPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33E6EB3EE3363ED4D24959BDBA937A9F9E9F8407"
//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

using StokTakip.Views.Pages;
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
using Wpf.Ui;
using Wpf.Ui.Controls;
using Wpf.Ui.Converters;
using Wpf.Ui.Markup;


namespace StokTakip.Views.Pages {
    
    
    /// <summary>
    /// FactoryPasswordPage
    /// </summary>
    public partial class FactoryPasswordPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\..\..\Views\Pages\FactoryPasswordPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel codeStackPanel;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\..\Views\Pages\FactoryPasswordPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Wpf.Ui.Controls.TextBox txtCode;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\..\Views\Pages\FactoryPasswordPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Wpf.Ui.Controls.Button btnContiune;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\..\Views\Pages\FactoryPasswordPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel passwordStackPanel;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\..\Views\Pages\FactoryPasswordPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Wpf.Ui.Controls.PasswordBox txtPassword;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\..\Views\Pages\FactoryPasswordPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Wpf.Ui.Controls.Button btnSet;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\..\Views\Pages\FactoryPasswordPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Wpf.Ui.Controls.Image imgPerson;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\..\Views\Pages\FactoryPasswordPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Wpf.Ui.Controls.TextBlock txtblckNameSurname;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.6.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/StokTakip;component/views/pages/factorypasswordpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\Pages\FactoryPasswordPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.codeStackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.txtCode = ((Wpf.Ui.Controls.TextBox)(target));
            
            #line 32 "..\..\..\..\..\Views\Pages\FactoryPasswordPage.xaml"
            this.txtCode.KeyDown += new System.Windows.Input.KeyEventHandler(this.txtCode_KeyDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnContiune = ((Wpf.Ui.Controls.Button)(target));
            
            #line 33 "..\..\..\..\..\Views\Pages\FactoryPasswordPage.xaml"
            this.btnContiune.Click += new System.Windows.RoutedEventHandler(this.btnContiune_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.passwordStackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 5:
            this.txtPassword = ((Wpf.Ui.Controls.PasswordBox)(target));
            
            #line 37 "..\..\..\..\..\Views\Pages\FactoryPasswordPage.xaml"
            this.txtPassword.KeyDown += new System.Windows.Input.KeyEventHandler(this.txtCode_KeyDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnSet = ((Wpf.Ui.Controls.Button)(target));
            
            #line 38 "..\..\..\..\..\Views\Pages\FactoryPasswordPage.xaml"
            this.btnSet.Click += new System.Windows.RoutedEventHandler(this.btnSet_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.imgPerson = ((Wpf.Ui.Controls.Image)(target));
            return;
            case 8:
            this.txtblckNameSurname = ((Wpf.Ui.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
