﻿#pragma checksum "E:\Trabajo\project\winuigallery\Controls\DesignGuidance\ColorTile.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7AD1F4A92A023F0232E68564874B09FADC21BF8265D771CFDE20F9DB6D552655"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinUIGallery.DesktopWap.Controls.DesignGuidance
{
    partial class ColorTile : 
        global::Microsoft.UI.Xaml.Controls.UserControl, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Microsoft_UI_Xaml_Controls_Panel_Background(global::Microsoft.UI.Xaml.Controls.Panel obj, global::Microsoft.UI.Xaml.Media.Brush value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Microsoft.UI.Xaml.Media.Brush) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Microsoft.UI.Xaml.Media.Brush), targetNullValue);
                }
                obj.Background = value;
            }
            public static void Set_Microsoft_UI_Xaml_UIElement_Visibility(global::Microsoft.UI.Xaml.UIElement obj, global::Microsoft.UI.Xaml.Visibility value)
            {
                obj.Visibility = value;
            }
            public static void Set_Microsoft_UI_Xaml_Controls_TextBlock_Foreground(global::Microsoft.UI.Xaml.Controls.TextBlock obj, global::Microsoft.UI.Xaml.Media.Brush value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Microsoft.UI.Xaml.Media.Brush) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Microsoft.UI.Xaml.Media.Brush), targetNullValue);
                }
                obj.Foreground = value;
            }
            public static void Set_Microsoft_UI_Xaml_Controls_Control_Foreground(global::Microsoft.UI.Xaml.Controls.Control obj, global::Microsoft.UI.Xaml.Media.Brush value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Microsoft.UI.Xaml.Media.Brush) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Microsoft.UI.Xaml.Media.Brush), targetNullValue);
                }
                obj.Foreground = value;
            }
            public static void Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(global::Microsoft.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class ColorTile_obj1_Bindings :
            global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent,
            global::Microsoft.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Microsoft.UI.Xaml.Markup.IComponentConnector,
            IColorTile_Bindings
        {
            private global::WinUIGallery.DesktopWap.Controls.DesignGuidance.ColorTile dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Microsoft.UI.Xaml.Controls.Grid obj2;
            private global::Microsoft.UI.Xaml.Controls.Border obj3;
            private global::Microsoft.UI.Xaml.Controls.TextBlock obj4;
            private global::Microsoft.UI.Xaml.Controls.Button obj5;
            private global::Microsoft.UI.Xaml.Controls.TextBlock obj6;
            private global::Microsoft.UI.Xaml.Controls.TextBlock obj7;
            private global::Microsoft.UI.Xaml.Controls.Grid obj8;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj2BackgroundDisabled = false;
            private static bool isobj3VisibilityDisabled = false;
            private static bool isobj4ForegroundDisabled = false;
            private static bool isobj4TextDisabled = false;
            private static bool isobj5ForegroundDisabled = false;
            private static bool isobj6TextDisabled = false;
            private static bool isobj7TextDisabled = false;
            private static bool isobj8VisibilityDisabled = false;

            private ColorTile_obj1_BindingsTracking bindingsTracking;

            public ColorTile_obj1_Bindings()
            {
                this.bindingsTracking = new ColorTile_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 23 && columnNumber == 13)
                {
                    isobj2BackgroundDisabled = true;
                }
                else if (lineNumber == 100 && columnNumber == 13)
                {
                    isobj3VisibilityDisabled = true;
                }
                else if (lineNumber == 38 && columnNumber == 17)
                {
                    isobj4ForegroundDisabled = true;
                }
                else if (lineNumber == 41 && columnNumber == 17)
                {
                    isobj4TextDisabled = true;
                }
                else if (lineNumber == 56 && columnNumber == 17)
                {
                    isobj5ForegroundDisabled = true;
                }
                else if (lineNumber == 67 && columnNumber == 17)
                {
                    isobj6TextDisabled = true;
                }
                else if (lineNumber == 75 && columnNumber == 17)
                {
                    isobj7TextDisabled = true;
                }
                else if (lineNumber == 83 && columnNumber == 17)
                {
                    isobj8VisibilityDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // Controls\DesignGuidance\ColorTile.xaml line 21
                        this.obj2 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Grid>(target);
                        break;
                    case 3: // Controls\DesignGuidance\ColorTile.xaml line 93
                        this.obj3 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Border>(target);
                        break;
                    case 4: // Controls\DesignGuidance\ColorTile.xaml line 37
                        this.obj4 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                        break;
                    case 5: // Controls\DesignGuidance\ColorTile.xaml line 44
                        this.obj5 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                        break;
                    case 6: // Controls\DesignGuidance\ColorTile.xaml line 62
                        this.obj6 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                        break;
                    case 7: // Controls\DesignGuidance\ColorTile.xaml line 70
                        this.obj7 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                        break;
                    case 8: // Controls\DesignGuidance\ColorTile.xaml line 77
                        this.obj8 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Grid>(target);
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

            // IColorTile_Bindings

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
                    this.dataRoot = global::WinRT.CastExtensions.As<global::WinUIGallery.DesktopWap.Controls.DesignGuidance.ColorTile>(newDataRoot);
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
            private void Update_(global::WinUIGallery.DesktopWap.Controls.DesignGuidance.ColorTile obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_Background(obj.Background, phase);
                        this.Update_ShowSeparator(obj.ShowSeparator, phase);
                        this.Update_Foreground(obj.Foreground, phase);
                        this.Update_ColorName(obj.ColorName, phase);
                        this.Update_ColorExplanation(obj.ColorExplanation, phase);
                        this.Update_ColorBrushName(obj.ColorBrushName, phase);
                        this.Update_ShowWarning(obj.ShowWarning, phase);
                    }
                }
            }
            private void Update_Background(global::Microsoft.UI.Xaml.Media.Brush obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\DesignGuidance\ColorTile.xaml line 21
                    if (!isobj2BackgroundDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Panel_Background(this.obj2, obj, null);
                    }
                }
            }
            private void Update_ShowSeparator(global::System.Boolean obj, int phase)
            {
                if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                {
                    this.Update_ShowSeparator_Cast_ShowSeparator_To_Visibility(obj ? global::Microsoft.UI.Xaml.Visibility.Visible : global::Microsoft.UI.Xaml.Visibility.Collapsed, phase);
                }
            }
            private void Update_ShowSeparator_Cast_ShowSeparator_To_Visibility(global::Microsoft.UI.Xaml.Visibility obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\DesignGuidance\ColorTile.xaml line 93
                    if (!isobj3VisibilityDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_UIElement_Visibility(this.obj3, obj);
                    }
                }
            }
            private void Update_Foreground(global::Microsoft.UI.Xaml.Media.Brush obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\DesignGuidance\ColorTile.xaml line 37
                    if (!isobj4ForegroundDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Foreground(this.obj4, obj, null);
                    }
                    // Controls\DesignGuidance\ColorTile.xaml line 44
                    if (!isobj5ForegroundDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Control_Foreground(this.obj5, obj, null);
                    }
                }
            }
            private void Update_ColorName(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\DesignGuidance\ColorTile.xaml line 37
                    if (!isobj4TextDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(this.obj4, obj, null);
                    }
                }
            }
            private void Update_ColorExplanation(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\DesignGuidance\ColorTile.xaml line 62
                    if (!isobj6TextDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(this.obj6, obj, null);
                    }
                }
            }
            private void Update_ColorBrushName(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\DesignGuidance\ColorTile.xaml line 70
                    if (!isobj7TextDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(this.obj7, obj, null);
                    }
                }
            }
            private void Update_ShowWarning(global::System.Boolean obj, int phase)
            {
                if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                {
                    this.Update_ShowWarning_Cast_ShowWarning_To_Visibility(obj ? global::Microsoft.UI.Xaml.Visibility.Visible : global::Microsoft.UI.Xaml.Visibility.Collapsed, phase);
                }
            }
            private void Update_ShowWarning_Cast_ShowWarning_To_Visibility(global::Microsoft.UI.Xaml.Visibility obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\DesignGuidance\ColorTile.xaml line 77
                    if (!isobj8VisibilityDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_UIElement_Visibility(this.obj8, obj);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class ColorTile_obj1_BindingsTracking
            {
                private global::System.WeakReference<ColorTile_obj1_Bindings> weakRefToBindingObj; 

                public ColorTile_obj1_BindingsTracking(ColorTile_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<ColorTile_obj1_Bindings>(obj);
                }

                public ColorTile_obj1_Bindings TryGetBindingObject()
                {
                    ColorTile_obj1_Bindings bindingObject = null;
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

                public void DependencyPropertyChanged_Background(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    ColorTile_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::WinUIGallery.DesktopWap.Controls.DesignGuidance.ColorTile obj = sender as global::WinUIGallery.DesktopWap.Controls.DesignGuidance.ColorTile;
                        if (obj != null)
                        {
                            bindings.Update_Background(obj.Background, DATA_CHANGED);
                        }
                    }
                }
                public void DependencyPropertyChanged_ShowSeparator(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    ColorTile_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::WinUIGallery.DesktopWap.Controls.DesignGuidance.ColorTile obj = sender as global::WinUIGallery.DesktopWap.Controls.DesignGuidance.ColorTile;
                        if (obj != null)
                        {
                            bindings.Update_ShowSeparator(obj.ShowSeparator, DATA_CHANGED);
                        }
                    }
                }
                public void DependencyPropertyChanged_Foreground(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    ColorTile_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::WinUIGallery.DesktopWap.Controls.DesignGuidance.ColorTile obj = sender as global::WinUIGallery.DesktopWap.Controls.DesignGuidance.ColorTile;
                        if (obj != null)
                        {
                            bindings.Update_Foreground(obj.Foreground, DATA_CHANGED);
                        }
                    }
                }
                public void DependencyPropertyChanged_ColorName(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    ColorTile_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::WinUIGallery.DesktopWap.Controls.DesignGuidance.ColorTile obj = sender as global::WinUIGallery.DesktopWap.Controls.DesignGuidance.ColorTile;
                        if (obj != null)
                        {
                            bindings.Update_ColorName(obj.ColorName, DATA_CHANGED);
                        }
                    }
                }
                public void DependencyPropertyChanged_ColorExplanation(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    ColorTile_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::WinUIGallery.DesktopWap.Controls.DesignGuidance.ColorTile obj = sender as global::WinUIGallery.DesktopWap.Controls.DesignGuidance.ColorTile;
                        if (obj != null)
                        {
                            bindings.Update_ColorExplanation(obj.ColorExplanation, DATA_CHANGED);
                        }
                    }
                }
                public void DependencyPropertyChanged_ColorBrushName(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    ColorTile_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::WinUIGallery.DesktopWap.Controls.DesignGuidance.ColorTile obj = sender as global::WinUIGallery.DesktopWap.Controls.DesignGuidance.ColorTile;
                        if (obj != null)
                        {
                            bindings.Update_ColorBrushName(obj.ColorBrushName, DATA_CHANGED);
                        }
                    }
                }
                public void DependencyPropertyChanged_ShowWarning(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    ColorTile_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::WinUIGallery.DesktopWap.Controls.DesignGuidance.ColorTile obj = sender as global::WinUIGallery.DesktopWap.Controls.DesignGuidance.ColorTile;
                        if (obj != null)
                        {
                            bindings.Update_ShowWarning(obj.ShowWarning, DATA_CHANGED);
                        }
                    }
                }
                private long tokenDPC_Background = 0;
                private long tokenDPC_ShowSeparator = 0;
                private long tokenDPC_Foreground = 0;
                private long tokenDPC_ColorName = 0;
                private long tokenDPC_ColorExplanation = 0;
                private long tokenDPC_ColorBrushName = 0;
                private long tokenDPC_ShowWarning = 0;
                public void UpdateChildListeners_(global::WinUIGallery.DesktopWap.Controls.DesignGuidance.ColorTile obj)
                {
                    ColorTile_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        if (bindings.dataRoot != null)
                        {
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Control.BackgroundProperty, tokenDPC_Background);
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::WinUIGallery.DesktopWap.Controls.DesignGuidance.ColorTile.ShowSeparatorProperty, tokenDPC_ShowSeparator);
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Control.ForegroundProperty, tokenDPC_Foreground);
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::WinUIGallery.DesktopWap.Controls.DesignGuidance.ColorTile.ColorNameProperty, tokenDPC_ColorName);
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::WinUIGallery.DesktopWap.Controls.DesignGuidance.ColorTile.ColorExplanationProperty, tokenDPC_ColorExplanation);
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::WinUIGallery.DesktopWap.Controls.DesignGuidance.ColorTile.ColorBrushNameProperty, tokenDPC_ColorBrushName);
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::WinUIGallery.DesktopWap.Controls.DesignGuidance.ColorTile.ShowWarningProperty, tokenDPC_ShowWarning);
                        }
                        if (obj != null)
                        {
                            bindings.dataRoot = obj;
                            tokenDPC_Background = obj.RegisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Control.BackgroundProperty, DependencyPropertyChanged_Background);
                            tokenDPC_ShowSeparator = obj.RegisterPropertyChangedCallback(global::WinUIGallery.DesktopWap.Controls.DesignGuidance.ColorTile.ShowSeparatorProperty, DependencyPropertyChanged_ShowSeparator);
                            tokenDPC_Foreground = obj.RegisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Control.ForegroundProperty, DependencyPropertyChanged_Foreground);
                            tokenDPC_ColorName = obj.RegisterPropertyChangedCallback(global::WinUIGallery.DesktopWap.Controls.DesignGuidance.ColorTile.ColorNameProperty, DependencyPropertyChanged_ColorName);
                            tokenDPC_ColorExplanation = obj.RegisterPropertyChangedCallback(global::WinUIGallery.DesktopWap.Controls.DesignGuidance.ColorTile.ColorExplanationProperty, DependencyPropertyChanged_ColorExplanation);
                            tokenDPC_ColorBrushName = obj.RegisterPropertyChangedCallback(global::WinUIGallery.DesktopWap.Controls.DesignGuidance.ColorTile.ColorBrushNameProperty, DependencyPropertyChanged_ColorBrushName);
                            tokenDPC_ShowWarning = obj.RegisterPropertyChangedCallback(global::WinUIGallery.DesktopWap.Controls.DesignGuidance.ColorTile.ShowWarningProperty, DependencyPropertyChanged_ShowWarning);
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
            case 1: // Controls\DesignGuidance\ColorTile.xaml line 4
                {
                    global::Microsoft.UI.Xaml.Controls.UserControl element1 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.UserControl>(target);
                    ((global::Microsoft.UI.Xaml.Controls.UserControl)element1).PointerEntered += this.UserControl_PointerEntered;
                    ((global::Microsoft.UI.Xaml.Controls.UserControl)element1).PointerExited += this.UserControl_PointerExited;
                }
                break;
            case 5: // Controls\DesignGuidance\ColorTile.xaml line 44
                {
                    this.CopyBrushNameButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)this.CopyBrushNameButton).Click += this.CopyBrushNameButton_Click;
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
            case 1: // Controls\DesignGuidance\ColorTile.xaml line 4
                {                    
                    global::Microsoft.UI.Xaml.Controls.UserControl element1 = (global::Microsoft.UI.Xaml.Controls.UserControl)target;
                    ColorTile_obj1_Bindings bindings = new ColorTile_obj1_Bindings();
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

