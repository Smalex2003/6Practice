﻿#pragma checksum "..\..\EditWorker.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4F3C6956BB48ECED098B159B6E0FF8544B447A4342DB963FFA2B1AC7939953D5"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using _6PracticeWpf;


namespace _6PracticeWpf {
    
    
    /// <summary>
    /// EditWorker
    /// </summary>
    public partial class EditWorker : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\EditWorker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameTb;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\EditWorker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SurnameTb;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\EditWorker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MiddlenameTb;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\EditWorker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox GenderTb;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\EditWorker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MaritalstatusTb;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\EditWorker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AcceptBtn;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\EditWorker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CancelBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/6PracticeWpf;component/editworker.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\EditWorker.xaml"
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
            this.NameTb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.SurnameTb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.MiddlenameTb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.GenderTb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.MaritalstatusTb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.AcceptBtn = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\EditWorker.xaml"
            this.AcceptBtn.Click += new System.Windows.RoutedEventHandler(this.AcceptBtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.CancelBtn = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\EditWorker.xaml"
            this.CancelBtn.Click += new System.Windows.RoutedEventHandler(this.CancelBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

