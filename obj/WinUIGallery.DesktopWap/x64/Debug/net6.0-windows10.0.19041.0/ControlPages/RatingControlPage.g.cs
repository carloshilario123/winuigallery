﻿#pragma checksum "E:\Trabajo\project\winuigallery\ControlPages\RatingControlPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B793B5BB39872287CED3BAD589EE2EA2E17ED03EBC7ADB80FD41AEE23880D01B"
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
    partial class RatingControlPage : 
        global::Microsoft.UI.Xaml.Controls.Page, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Microsoft_UI_Xaml_Controls_RatingControl_PlaceholderValue(global::Microsoft.UI.Xaml.Controls.RatingControl obj, global::System.Double value)
            {
                obj.PlaceholderValue = value;
            }
            public static void Set_AppUIBasics_ControlExampleSubstitution_Value(global::AppUIBasics.ControlExampleSubstitution obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.Value = value;
            }
            public static void Set_Microsoft_UI_Xaml_Controls_RatingControl_IsClearEnabled(global::Microsoft.UI.Xaml.Controls.RatingControl obj, global::System.Boolean value)
            {
                obj.IsClearEnabled = value;
            }
            public static void Set_Microsoft_UI_Xaml_Controls_RatingControl_IsReadOnly(global::Microsoft.UI.Xaml.Controls.RatingControl obj, global::System.Boolean value)
            {
                obj.IsReadOnly = value;
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
        private class RatingControlPage_obj1_Bindings :
            global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent,
            global::Microsoft.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Microsoft.UI.Xaml.Markup.IComponentConnector,
            IRatingControlPage_Bindings
        {
            private global::AppUIBasics.ControlPages.RatingControlPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Microsoft.UI.Xaml.Controls.RatingControl obj4;
            private global::AppUIBasics.ControlExampleSubstitution obj6;
            private global::Microsoft.UI.Xaml.Controls.RatingControl obj7;
            private global::Microsoft.UI.Xaml.Controls.TextBlock obj8;
            private global::AppUIBasics.ControlExampleSubstitution obj11;
            private global::AppUIBasics.ControlExampleSubstitution obj12;
            private global::AppUIBasics.ControlExampleSubstitution obj13;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj4PlaceholderValueDisabled = false;
            private static bool isobj6ValueDisabled = false;
            private static bool isobj7IsClearEnabledDisabled = false;
            private static bool isobj7IsReadOnlyDisabled = false;
            private static bool isobj8TextDisabled = false;
            private static bool isobj11ValueDisabled = false;
            private static bool isobj12ValueDisabled = false;
            private static bool isobj13ValueDisabled = false;

            private RatingControlPage_obj1_BindingsTracking bindingsTracking;

            public RatingControlPage_obj1_Bindings()
            {
                this.bindingsTracking = new RatingControlPage_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 45 && columnNumber == 17)
                {
                    isobj4PlaceholderValueDisabled = true;
                }
                else if (lineNumber == 60 && columnNumber == 64)
                {
                    isobj6ValueDisabled = true;
                }
                else if (lineNumber == 11 && columnNumber == 21)
                {
                    isobj7IsClearEnabledDisabled = true;
                }
                else if (lineNumber == 14 && columnNumber == 21)
                {
                    isobj7IsReadOnlyDisabled = true;
                }
                else if (lineNumber == 18 && columnNumber == 46)
                {
                    isobj8TextDisabled = true;
                }
                else if (lineNumber == 36 && columnNumber == 72)
                {
                    isobj11ValueDisabled = true;
                }
                else if (lineNumber == 37 && columnNumber == 68)
                {
                    isobj12ValueDisabled = true;
                }
                else if (lineNumber == 38 && columnNumber == 92)
                {
                    isobj13ValueDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 4: // ControlPages\RatingControlPage.xaml line 44
                        this.obj4 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.RatingControl>(target);
                        this.bindingsTracking.RegisterTwoWayListener_4(this.obj4);
                        break;
                    case 6: // ControlPages\RatingControlPage.xaml line 60
                        this.obj6 = global::WinRT.CastExtensions.As<global::AppUIBasics.ControlExampleSubstitution>(target);
                        break;
                    case 7: // ControlPages\RatingControlPage.xaml line 10
                        this.obj7 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.RatingControl>(target);
                        break;
                    case 8: // ControlPages\RatingControlPage.xaml line 18
                        this.obj8 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                        break;
                    case 11: // ControlPages\RatingControlPage.xaml line 36
                        this.obj11 = global::WinRT.CastExtensions.As<global::AppUIBasics.ControlExampleSubstitution>(target);
                        break;
                    case 12: // ControlPages\RatingControlPage.xaml line 37
                        this.obj12 = global::WinRT.CastExtensions.As<global::AppUIBasics.ControlExampleSubstitution>(target);
                        break;
                    case 13: // ControlPages\RatingControlPage.xaml line 38
                        this.obj13 = global::WinRT.CastExtensions.As<global::AppUIBasics.ControlExampleSubstitution>(target);
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

            // IRatingControlPage_Bindings

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
                    this.dataRoot = global::WinRT.CastExtensions.As<global::AppUIBasics.ControlPages.RatingControlPage>(newDataRoot);
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
            private void Update_(global::AppUIBasics.ControlPages.RatingControlPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_slider(obj.slider, phase);
                        this.Update_clearEnabledCheck(obj.clearEnabledCheck, phase);
                        this.Update_readOnlyCheck(obj.readOnlyCheck, phase);
                        this.Update_RatingControl1(obj.RatingControl1, phase);
                    }
                }
            }
            private void Update_slider(global::Microsoft.UI.Xaml.Controls.Slider obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_slider(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_slider_Value(obj.Value, phase);
                    }
                }
            }
            private void Update_slider_Value(global::System.Double obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // ControlPages\RatingControlPage.xaml line 44
                    if (!isobj4PlaceholderValueDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_RatingControl_PlaceholderValue(this.obj4, obj);
                    }
                    // ControlPages\RatingControlPage.xaml line 60
                    if (!isobj6ValueDisabled)
                    {
                        XamlBindingSetters.Set_AppUIBasics_ControlExampleSubstitution_Value(this.obj6, obj, null);
                    }
                }
            }
            private void Update_clearEnabledCheck(global::Microsoft.UI.Xaml.Controls.CheckBox obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_clearEnabledCheck(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_clearEnabledCheck_IsChecked(obj.IsChecked, phase);
                    }
                }
            }
            private void Update_clearEnabledCheck_IsChecked(global::System.Nullable<global::System.Boolean> obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_clearEnabledCheck_IsChecked_Value(obj.Value, phase);
                    }
                }
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // ControlPages\RatingControlPage.xaml line 36
                    if (!isobj11ValueDisabled)
                    {
                        XamlBindingSetters.Set_AppUIBasics_ControlExampleSubstitution_Value(this.obj11, obj, null);
                    }
                }
            }
            private void Update_clearEnabledCheck_IsChecked_Value(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // ControlPages\RatingControlPage.xaml line 10
                    if (!isobj7IsClearEnabledDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_RatingControl_IsClearEnabled(this.obj7, obj);
                    }
                }
            }
            private void Update_readOnlyCheck(global::Microsoft.UI.Xaml.Controls.CheckBox obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_readOnlyCheck(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_readOnlyCheck_IsChecked(obj.IsChecked, phase);
                    }
                }
            }
            private void Update_readOnlyCheck_IsChecked(global::System.Nullable<global::System.Boolean> obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_readOnlyCheck_IsChecked_Value(obj.Value, phase);
                    }
                }
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // ControlPages\RatingControlPage.xaml line 37
                    if (!isobj12ValueDisabled)
                    {
                        XamlBindingSetters.Set_AppUIBasics_ControlExampleSubstitution_Value(this.obj12, obj, null);
                    }
                }
            }
            private void Update_readOnlyCheck_IsChecked_Value(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // ControlPages\RatingControlPage.xaml line 10
                    if (!isobj7IsReadOnlyDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_RatingControl_IsReadOnly(this.obj7, obj);
                    }
                }
            }
            private void Update_RatingControl1(global::Microsoft.UI.Xaml.Controls.RatingControl obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_RatingControl1(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_RatingControl1_Value(obj.Value, phase);
                        this.Update_RatingControl1_Caption(obj.Caption, phase);
                    }
                }
            }
            private void Update_RatingControl1_Value(global::System.Double obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // ControlPages\RatingControlPage.xaml line 18
                    if (!isobj8TextDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(this.obj8, obj.ToString(), null);
                    }
                }
            }
            private void Update_RatingControl1_Caption(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // ControlPages\RatingControlPage.xaml line 38
                    if (!isobj13ValueDisabled)
                    {
                        XamlBindingSetters.Set_AppUIBasics_ControlExampleSubstitution_Value(this.obj13, obj, null);
                    }
                }
            }
            private void UpdateTwoWay_4_PlaceholderValue()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        if (this.dataRoot.slider != null)
                        {
                            this.dataRoot.slider.Value = this.obj4.PlaceholderValue;
                        }
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class RatingControlPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<RatingControlPage_obj1_Bindings> weakRefToBindingObj; 

                public RatingControlPage_obj1_BindingsTracking(RatingControlPage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<RatingControlPage_obj1_Bindings>(obj);
                }

                public RatingControlPage_obj1_Bindings TryGetBindingObject()
                {
                    RatingControlPage_obj1_Bindings bindingObject = null;
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
                    UpdateChildListeners_slider(null);
                    UpdateChildListeners_clearEnabledCheck(null);
                    UpdateChildListeners_readOnlyCheck(null);
                    UpdateChildListeners_RatingControl1(null);
                }

                public void DependencyPropertyChanged_slider_Value(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    RatingControlPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Microsoft.UI.Xaml.Controls.Slider obj = sender as global::Microsoft.UI.Xaml.Controls.Slider;
                        if (obj != null)
                        {
                            bindings.Update_slider_Value(obj.Value, DATA_CHANGED);
                        }
                    }
                }
                private global::Microsoft.UI.Xaml.Controls.Slider cache_slider = null;
                private long tokenDPC_slider_Value = 0;
                public void UpdateChildListeners_slider(global::Microsoft.UI.Xaml.Controls.Slider obj)
                {
                    if (obj != cache_slider)
                    {
                        if (cache_slider != null)
                        {
                            cache_slider.UnregisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Primitives.RangeBase.ValueProperty, tokenDPC_slider_Value);
                            cache_slider = null;
                        }
                        if (obj != null)
                        {
                            cache_slider = obj;
                            tokenDPC_slider_Value = obj.RegisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Primitives.RangeBase.ValueProperty, DependencyPropertyChanged_slider_Value);
                        }
                    }
                }
                public void DependencyPropertyChanged_clearEnabledCheck_IsChecked(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    RatingControlPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Microsoft.UI.Xaml.Controls.CheckBox obj = sender as global::Microsoft.UI.Xaml.Controls.CheckBox;
                        if (obj != null)
                        {
                            bindings.Update_clearEnabledCheck_IsChecked(obj.IsChecked, DATA_CHANGED);
                        }
                    }
                }
                private global::Microsoft.UI.Xaml.Controls.CheckBox cache_clearEnabledCheck = null;
                private long tokenDPC_clearEnabledCheck_IsChecked = 0;
                public void UpdateChildListeners_clearEnabledCheck(global::Microsoft.UI.Xaml.Controls.CheckBox obj)
                {
                    if (obj != cache_clearEnabledCheck)
                    {
                        if (cache_clearEnabledCheck != null)
                        {
                            cache_clearEnabledCheck.UnregisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton.IsCheckedProperty, tokenDPC_clearEnabledCheck_IsChecked);
                            cache_clearEnabledCheck = null;
                        }
                        if (obj != null)
                        {
                            cache_clearEnabledCheck = obj;
                            tokenDPC_clearEnabledCheck_IsChecked = obj.RegisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton.IsCheckedProperty, DependencyPropertyChanged_clearEnabledCheck_IsChecked);
                        }
                    }
                }
                public void DependencyPropertyChanged_readOnlyCheck_IsChecked(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    RatingControlPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Microsoft.UI.Xaml.Controls.CheckBox obj = sender as global::Microsoft.UI.Xaml.Controls.CheckBox;
                        if (obj != null)
                        {
                            bindings.Update_readOnlyCheck_IsChecked(obj.IsChecked, DATA_CHANGED);
                        }
                    }
                }
                private global::Microsoft.UI.Xaml.Controls.CheckBox cache_readOnlyCheck = null;
                private long tokenDPC_readOnlyCheck_IsChecked = 0;
                public void UpdateChildListeners_readOnlyCheck(global::Microsoft.UI.Xaml.Controls.CheckBox obj)
                {
                    if (obj != cache_readOnlyCheck)
                    {
                        if (cache_readOnlyCheck != null)
                        {
                            cache_readOnlyCheck.UnregisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton.IsCheckedProperty, tokenDPC_readOnlyCheck_IsChecked);
                            cache_readOnlyCheck = null;
                        }
                        if (obj != null)
                        {
                            cache_readOnlyCheck = obj;
                            tokenDPC_readOnlyCheck_IsChecked = obj.RegisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton.IsCheckedProperty, DependencyPropertyChanged_readOnlyCheck_IsChecked);
                        }
                    }
                }
                public void DependencyPropertyChanged_RatingControl1_Value(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    RatingControlPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Microsoft.UI.Xaml.Controls.RatingControl obj = sender as global::Microsoft.UI.Xaml.Controls.RatingControl;
                        if (obj != null)
                        {
                            bindings.Update_RatingControl1_Value(obj.Value, DATA_CHANGED);
                        }
                    }
                }
                public void DependencyPropertyChanged_RatingControl1_Caption(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    RatingControlPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Microsoft.UI.Xaml.Controls.RatingControl obj = sender as global::Microsoft.UI.Xaml.Controls.RatingControl;
                        if (obj != null)
                        {
                            bindings.Update_RatingControl1_Caption(obj.Caption, DATA_CHANGED);
                        }
                    }
                }
                private global::Microsoft.UI.Xaml.Controls.RatingControl cache_RatingControl1 = null;
                private long tokenDPC_RatingControl1_Value = 0;
                private long tokenDPC_RatingControl1_Caption = 0;
                public void UpdateChildListeners_RatingControl1(global::Microsoft.UI.Xaml.Controls.RatingControl obj)
                {
                    if (obj != cache_RatingControl1)
                    {
                        if (cache_RatingControl1 != null)
                        {
                            cache_RatingControl1.UnregisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.RatingControl.ValueProperty, tokenDPC_RatingControl1_Value);
                            cache_RatingControl1.UnregisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.RatingControl.CaptionProperty, tokenDPC_RatingControl1_Caption);
                            cache_RatingControl1 = null;
                        }
                        if (obj != null)
                        {
                            cache_RatingControl1 = obj;
                            tokenDPC_RatingControl1_Value = obj.RegisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.RatingControl.ValueProperty, DependencyPropertyChanged_RatingControl1_Value);
                            tokenDPC_RatingControl1_Caption = obj.RegisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.RatingControl.CaptionProperty, DependencyPropertyChanged_RatingControl1_Caption);
                        }
                    }
                }
                public void RegisterTwoWayListener_4(global::Microsoft.UI.Xaml.Controls.RatingControl sourceObject)
                {
                    sourceObject.RegisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.RatingControl.PlaceholderValueProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_4_PlaceholderValue();
                        }
                    });
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
            case 2: // ControlPages\RatingControlPage.xaml line 7
                {
                    this.Example1 = global::WinRT.CastExtensions.As<global::AppUIBasics.ControlExample>(target);
                }
                break;
            case 3: // ControlPages\RatingControlPage.xaml line 42
                {
                    this.Example2 = global::WinRT.CastExtensions.As<global::AppUIBasics.ControlExample>(target);
                }
                break;
            case 4: // ControlPages\RatingControlPage.xaml line 44
                {
                    this.RatingControl2 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.RatingControl>(target);
                }
                break;
            case 5: // ControlPages\RatingControlPage.xaml line 49
                {
                    this.slider = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Slider>(target);
                }
                break;
            case 7: // ControlPages\RatingControlPage.xaml line 10
                {
                    this.RatingControl1 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.RatingControl>(target);
                    ((global::Microsoft.UI.Xaml.Controls.RatingControl)this.RatingControl1).ValueChanged += this.RatingControl1_ValueChanged;
                }
                break;
            case 9: // ControlPages\RatingControlPage.xaml line 23
                {
                    this.clearEnabledCheck = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.CheckBox>(target);
                }
                break;
            case 10: // ControlPages\RatingControlPage.xaml line 25
                {
                    this.readOnlyCheck = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.CheckBox>(target);
                }
                break;
            case 13: // ControlPages\RatingControlPage.xaml line 38
                {
                    this.SampleCodeCaption = global::WinRT.CastExtensions.As<global::AppUIBasics.ControlExampleSubstitution>(target);
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
            case 1: // ControlPages\RatingControlPage.xaml line 1
                {                    
                    global::Microsoft.UI.Xaml.Controls.Page element1 = (global::Microsoft.UI.Xaml.Controls.Page)target;
                    RatingControlPage_obj1_Bindings bindings = new RatingControlPage_obj1_Bindings();
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

