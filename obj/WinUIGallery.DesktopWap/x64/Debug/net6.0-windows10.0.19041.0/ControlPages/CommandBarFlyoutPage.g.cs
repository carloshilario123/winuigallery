﻿#pragma checksum "E:\Trabajo\project\winuigallery\ControlPages\CommandBarFlyoutPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "077A4A715C25E4E1ACB75C1DCC5F6E063904D615520447F1D60FC957E10BA943"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppUIBasics.ControlPages
{
    partial class CommandBarFlyoutPage : 
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
            case 2: // ControlPages\CommandBarFlyoutPage.xaml line 10
                {
                    this.CommandBarFlyout1 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.CommandBarFlyout>(target);
                }
                break;
            case 3: // ControlPages\CommandBarFlyoutPage.xaml line 11
                {
                    global::Microsoft.UI.Xaml.Controls.AppBarButton element3 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)element3).Click += this.OnElementClicked;
                }
                break;
            case 4: // ControlPages\CommandBarFlyoutPage.xaml line 12
                {
                    global::Microsoft.UI.Xaml.Controls.AppBarButton element4 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)element4).Click += this.OnElementClicked;
                }
                break;
            case 5: // ControlPages\CommandBarFlyoutPage.xaml line 13
                {
                    global::Microsoft.UI.Xaml.Controls.AppBarButton element5 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)element5).Click += this.OnElementClicked;
                }
                break;
            case 6: // ControlPages\CommandBarFlyoutPage.xaml line 15
                {
                    global::Microsoft.UI.Xaml.Controls.AppBarButton element6 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)element6).Click += this.OnElementClicked;
                }
                break;
            case 7: // ControlPages\CommandBarFlyoutPage.xaml line 16
                {
                    global::Microsoft.UI.Xaml.Controls.AppBarButton element7 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)element7).Click += this.OnElementClicked;
                }
                break;
            case 8: // ControlPages\CommandBarFlyoutPage.xaml line 26
                {
                    this.myImageButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)this.myImageButton).Click += this.MyImageButton_Click;
                    ((global::Microsoft.UI.Xaml.Controls.Button)this.myImageButton).ContextRequested += this.MyImageButton_ContextRequested;
                }
                break;
            case 9: // ControlPages\CommandBarFlyoutPage.xaml line 30
                {
                    this.SelectedOptionText = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                }
                break;
            case 10: // ControlPages\CommandBarFlyoutPage.xaml line 28
                {
                    this.Image1 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Image>(target);
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
