﻿#pragma checksum "E:\Trabajo\project\winuigallery\ControlPages\PasswordBoxPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F2F567C5395FA2E216BD52762C7EEA9F9B080C5235AA0B7A47F33A16050B2863"
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
    partial class PasswordBoxPage : 
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
            case 2: // ControlPages\PasswordBoxPage.xaml line 22
                {
                    this.Example1 = global::WinRT.CastExtensions.As<global::AppUIBasics.ControlExample>(target);
                }
                break;
            case 3: // ControlPages\PasswordBoxPage.xaml line 34
                {
                    this.Example2 = global::WinRT.CastExtensions.As<global::AppUIBasics.ControlExample>(target);
                }
                break;
            case 4: // ControlPages\PasswordBoxPage.xaml line 45
                {
                    this.passworBoxWithRevealmode = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.PasswordBox>(target);
                }
                break;
            case 5: // ControlPages\PasswordBoxPage.xaml line 47
                {
                    this.revealModeCheckBox = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.CheckBox>(target);
                    ((global::Microsoft.UI.Xaml.Controls.CheckBox)this.revealModeCheckBox).Checked += this.RevealModeCheckbox_Changed;
                    ((global::Microsoft.UI.Xaml.Controls.CheckBox)this.revealModeCheckBox).Unchecked += this.RevealModeCheckbox_Changed;
                }
                break;
            case 6: // ControlPages\PasswordBoxPage.xaml line 24
                {
                    global::Microsoft.UI.Xaml.Controls.PasswordBox element6 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.PasswordBox>(target);
                    ((global::Microsoft.UI.Xaml.Controls.PasswordBox)element6).PasswordChanged += this.PasswordBox_PasswordChanged;
                }
                break;
            case 7: // ControlPages\PasswordBoxPage.xaml line 25
                {
                    this.Control1Output = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
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
