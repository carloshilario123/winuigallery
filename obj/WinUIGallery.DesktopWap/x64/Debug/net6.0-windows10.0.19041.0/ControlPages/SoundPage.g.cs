﻿#pragma checksum "E:\Trabajo\project\winuigallery\ControlPages\SoundPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C033CE3F386D5F80267B8ABD283B4F2C05270D437B1D71B22E71160F1CB34D0E"
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
    partial class SoundPage : 
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
            case 2: // ControlPages\SoundPage.xaml line 19
                {
                    this.Example1 = global::WinRT.CastExtensions.As<global::AppUIBasics.ControlExample>(target);
                }
                break;
            case 3: // ControlPages\SoundPage.xaml line 28
                {
                    this.Example2 = global::WinRT.CastExtensions.As<global::AppUIBasics.ControlExample>(target);
                }
                break;
            case 4: // ControlPages\SoundPage.xaml line 40
                {
                    this.Example3 = global::WinRT.CastExtensions.As<global::AppUIBasics.ControlExample>(target);
                }
                break;
            case 5: // ControlPages\SoundPage.xaml line 46
                {
                    global::Microsoft.UI.Xaml.Controls.Button element5 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)element5).Click += this.Button_Click;
                }
                break;
            case 6: // ControlPages\SoundPage.xaml line 47
                {
                    this.soundSelection = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ComboBox>(target);
                }
                break;
            case 7: // ControlPages\SoundPage.xaml line 30
                {
                    this.spatialAudioBox = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.CheckBox>(target);
                    ((global::Microsoft.UI.Xaml.Controls.CheckBox)this.spatialAudioBox).Checked += this.spatialAudioBox_Checked;
                    ((global::Microsoft.UI.Xaml.Controls.CheckBox)this.spatialAudioBox).Unchecked += this.spatialAudioBox_Unchecked;
                }
                break;
            case 8: // ControlPages\SoundPage.xaml line 20
                {
                    this.soundToggle = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ToggleSwitch>(target);
                    ((global::Microsoft.UI.Xaml.Controls.ToggleSwitch)this.soundToggle).Toggled += this.soundToggle_Toggled;
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

