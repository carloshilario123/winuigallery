﻿#pragma checksum "E:\Trabajo\project\winuigallery\Controls\InlineColorPicker.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "43CC470CB4FE1AA1E9AE6F2E2A26BF82783188848831D1CCA2D0E3DB9EECB052"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinUIGallery.DesktopWap.Controls
{
    partial class InlineColorPicker : 
        global::Microsoft.UI.Xaml.Controls.UserControl, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Microsoft_UI_Xaml_Shapes_Shape_Fill(global::Microsoft.UI.Xaml.Shapes.Shape obj, global::Microsoft.UI.Xaml.Media.Brush value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Microsoft.UI.Xaml.Media.Brush) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Microsoft.UI.Xaml.Media.Brush), targetNullValue);
                }
                obj.Fill = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class InlineColorPicker_obj1_Bindings :
            global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent,
            global::Microsoft.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Microsoft.UI.Xaml.Markup.IComponentConnector,
            IInlineColorPicker_Bindings
        {
            private global::WinUIGallery.DesktopWap.Controls.InlineColorPicker dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Microsoft.UI.Xaml.Shapes.Rectangle obj3;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj3FillDisabled = false;

            private InlineColorPicker_obj1_BindingsTracking bindingsTracking;

            public InlineColorPicker_obj1_Bindings()
            {
                this.bindingsTracking = new InlineColorPicker_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 15 && columnNumber == 46)
                {
                    isobj3FillDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 3: // Controls\InlineColorPicker.xaml line 15
                        this.obj3 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Shapes.Rectangle>(target);
                        break;
                    default:
                        break;
                }
            }
                        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
                        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
                        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target) 
                        {
                            return null;
                        }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // IInlineColorPicker_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = global::WinRT.CastExtensions.As<global::WinUIGallery.DesktopWap.Controls.InlineColorPicker>(newDataRoot);
                    return true;
                }
                return false;
            }

            public void Activated(object obj, global::Microsoft.UI.Xaml.WindowActivatedEventArgs data)
            {
                this.Initialize();
            }

            public void Loading(global::Microsoft.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::WinUIGallery.DesktopWap.Controls.InlineColorPicker obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ColorBrush(obj.ColorBrush, phase);
                    }
                }
            }
            private void Update_ColorBrush(global::Microsoft.UI.Xaml.Media.SolidColorBrush obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\InlineColorPicker.xaml line 15
                    if (!isobj3FillDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Shapes_Shape_Fill(this.obj3, obj, null);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class InlineColorPicker_obj1_BindingsTracking
            {
                private global::System.WeakReference<InlineColorPicker_obj1_Bindings> weakRefToBindingObj; 

                public InlineColorPicker_obj1_BindingsTracking(InlineColorPicker_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<InlineColorPicker_obj1_Bindings>(obj);
                }

                public InlineColorPicker_obj1_Bindings TryGetBindingObject()
                {
                    InlineColorPicker_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_(null);
                }

                public void DependencyPropertyChanged_ColorBrush(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    InlineColorPicker_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::WinUIGallery.DesktopWap.Controls.InlineColorPicker obj = sender as global::WinUIGallery.DesktopWap.Controls.InlineColorPicker;
                        if (obj != null)
                        {
                            bindings.Update_ColorBrush(obj.ColorBrush, DATA_CHANGED);
                        }
                    }
                }
                private long tokenDPC_ColorBrush = 0;
                public void UpdateChildListeners_(global::WinUIGallery.DesktopWap.Controls.InlineColorPicker obj)
                {
                    InlineColorPicker_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        if (bindings.dataRoot != null)
                        {
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::WinUIGallery.DesktopWap.Controls.InlineColorPicker.ColorBrushProperty, tokenDPC_ColorBrush);
                        }
                        if (obj != null)
                        {
                            bindings.dataRoot = obj;
                            tokenDPC_ColorBrush = obj.RegisterPropertyChangedCallback(global::WinUIGallery.DesktopWap.Controls.InlineColorPicker.ColorBrushProperty, DependencyPropertyChanged_ColorBrush);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Controls\InlineColorPicker.xaml line 26
                {
                    this.ColorHex = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBox>(target);
                    ((global::Microsoft.UI.Xaml.Controls.TextBox)this.ColorHex).TextChanged += this.ColorHex_TextChanged;
                }
                break;
            case 3: // Controls\InlineColorPicker.xaml line 15
                {
                    this.ColorPreview = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Shapes.Rectangle>(target);
                }
                break;
            case 4: // Controls\InlineColorPicker.xaml line 17
                {
                    global::Microsoft.UI.Xaml.Controls.Flyout element4 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Flyout>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Flyout)element4).Opened += this.PickerFlyout_Opened;
                }
                break;
            case 5: // Controls\InlineColorPicker.xaml line 18
                {
                    this.Picker = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ColorPicker>(target);
                    ((global::Microsoft.UI.Xaml.Controls.ColorPicker)this.Picker).ColorChanged += this.Picker_ColorChanged;
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
            switch(connectionId)
            {
            case 1: // Controls\InlineColorPicker.xaml line 1
                {                    
                    global::Microsoft.UI.Xaml.Controls.UserControl element1 = (global::Microsoft.UI.Xaml.Controls.UserControl)target;
                    InlineColorPicker_obj1_Bindings bindings = new InlineColorPicker_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

