﻿#pragma checksum "..\..\..\..\components\cyclinggradient.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "513F7D12FEDF7F18CF141EF02E24A0E07AEAB59FC669563197E54A77FEC53D3D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Logi;
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


namespace Logi {
    
    
    /// <summary>
    /// CyclingGradient
    /// </summary>
    public partial class CyclingGradient : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 5 "..\..\..\..\components\cyclinggradient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle GradientBG;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\..\components\cyclinggradient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.GradientStop GradientStop1;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\components\cyclinggradient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.GradientStop GradientStop2;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\components\cyclinggradient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.GradientStop GradientStop3;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\components\cyclinggradient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.GradientStop GradientStop4;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\components\cyclinggradient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Animation.Storyboard storyBoardControl;
        
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
            System.Uri resourceLocater = new System.Uri("/lghub_installer;component/components/cyclinggradient.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\components\cyclinggradient.xaml"
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
            this.GradientBG = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 2:
            this.GradientStop1 = ((System.Windows.Media.GradientStop)(target));
            return;
            case 3:
            this.GradientStop2 = ((System.Windows.Media.GradientStop)(target));
            return;
            case 4:
            this.GradientStop3 = ((System.Windows.Media.GradientStop)(target));
            return;
            case 5:
            this.GradientStop4 = ((System.Windows.Media.GradientStop)(target));
            return;
            case 6:
            this.storyBoardControl = ((System.Windows.Media.Animation.Storyboard)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

