﻿#pragma checksum "E:\Trabajo\project\winuigallery\TabViewPages\TabViewWindowingSamplePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8CAE4C7B24CC1A0ACF599FD1D9EDF177DA79986918511F7B2512E0919E8AC886"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppUIBasics.TabViewPages
{
    partial class TabViewWindowingSamplePage : 
        global::Microsoft.UI.Xaml.Controls.Page, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {

        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // TabViewPages\TabViewWindowingSamplePage.xaml line 12
                {
                    this.Tabs = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TabView>(target);
                    ((global::Microsoft.UI.Xaml.Controls.TabView)this.Tabs).AddTabButtonClick += this.Tabs_AddTabButtonClick;
                    ((global::Microsoft.UI.Xaml.Controls.TabView)this.Tabs).TabCloseRequested += this.Tabs_TabCloseRequested;
                    ((global::Microsoft.UI.Xaml.Controls.TabView)this.Tabs).TabDroppedOutside += this.Tabs_TabDroppedOutside;
                    ((global::Microsoft.UI.Xaml.Controls.TabView)this.Tabs).TabStripDragOver += this.Tabs_TabStripDragOver;
                    ((global::Microsoft.UI.Xaml.Controls.TabView)this.Tabs).TabStripDrop += this.Tabs_TabStripDrop;
                    ((global::Microsoft.UI.Xaml.Controls.TabView)this.Tabs).TabDragStarting += this.Tabs_TabDragStarting;
                }
                break;
            case 3: // TabViewPages\TabViewWindowingSamplePage.xaml line 24
                {
                    this.ShellTitleBarInset = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Grid>(target);
                }
                break;
            case 4: // TabViewPages\TabViewWindowingSamplePage.xaml line 27
                {
                    this.CustomDragRegion = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Grid>(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Microsoft.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

