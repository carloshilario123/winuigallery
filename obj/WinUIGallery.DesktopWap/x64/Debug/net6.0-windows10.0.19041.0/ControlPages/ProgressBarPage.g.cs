﻿#pragma checksum "E:\Trabajo\project\winuigallery\ControlPages\ProgressBarPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BC181C4B870DA208CD0AEAD080B9404B8140BEAC68AED51CF8C62FBBA3A216E1"
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
    partial class ProgressBarPage : 
        global::Microsoft.UI.Xaml.Controls.Page, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_AppUIBasics_ControlExampleSubstitution_Value(global::AppUIBasics.ControlExampleSubstitution obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.Value = value;
            }
            public static void Set_Microsoft_UI_Xaml_Controls_ProgressBar_ShowPaused(global::Microsoft.UI.Xaml.Controls.ProgressBar obj, global::System.Boolean value)
            {
                obj.ShowPaused = value;
            }
            public static void Set_Microsoft_UI_Xaml_Controls_ProgressBar_ShowError(global::Microsoft.UI.Xaml.Controls.ProgressBar obj, global::System.Boolean value)
            {
                obj.ShowError = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class ProgressBarPage_obj1_Bindings :
            global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent,
            global::Microsoft.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Microsoft.UI.Xaml.Markup.IComponentConnector,
            IProgressBarPage_Bindings
        {
            private global::AppUIBasics.ControlPages.ProgressBarPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::AppUIBasics.ControlExampleSubstitution obj8;
            private global::Microsoft.UI.Xaml.Controls.ProgressBar obj9;
            private global::AppUIBasics.ControlExampleSubstitution obj13;
            private global::AppUIBasics.ControlExampleSubstitution obj14;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj8ValueDisabled = false;
            private static bool isobj9ShowPausedDisabled = false;
            private static bool isobj9ShowErrorDisabled = false;
            private static bool isobj13ValueDisabled = false;
            private static bool isobj14ValueDisabled = false;

            private ProgressBarPage_obj1_BindingsTracking bindingsTracking;

            public ProgressBarPage_obj1_Bindings()
            {
                this.bindingsTracking = new ProgressBarPage_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 65 && columnNumber == 82)
                {
                    isobj8ValueDisabled = true;
                }
                else if (lineNumber == 23 && columnNumber == 17)
                {
                    isobj9ShowPausedDisabled = true;
                }
                else if (lineNumber == 24 && columnNumber == 17)
                {
                    isobj9ShowErrorDisabled = true;
                }
                else if (lineNumber == 39 && columnNumber == 68)
                {
                    isobj13ValueDisabled = true;
                }
                else if (lineNumber == 40 && columnNumber == 67)
                {
                    isobj14ValueDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 8: // ControlPages\ProgressBarPage.xaml line 65
                        this.obj8 = global::WinRT.CastExtensions.As<global::AppUIBasics.ControlExampleSubstitution>(target);
                        break;
                    case 9: // ControlPages\ProgressBarPage.xaml line 22
                        this.obj9 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ProgressBar>(target);
                        break;
                    case 13: // ControlPages\ProgressBarPage.xaml line 39
                        this.obj13 = global::WinRT.CastExtensions.As<global::AppUIBasics.ControlExampleSubstitution>(target);
                        break;
                    case 14: // ControlPages\ProgressBarPage.xaml line 40
                        this.obj14 = global::WinRT.CastExtensions.As<global::AppUIBasics.ControlExampleSubstitution>(target);
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

            // IProgressBarPage_Bindings

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
                    this.dataRoot = global::WinRT.CastExtensions.As<global::AppUIBasics.ControlPages.ProgressBarPage>(newDataRoot);
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
            private void Update_(global::AppUIBasics.ControlPages.ProgressBarPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ProgressBar2(obj.ProgressBar2, phase);
                        this.Update_PausedRB(obj.PausedRB, phase);
                        this.Update_ErrorRB(obj.ErrorRB, phase);
                    }
                }
            }
            private void Update_ProgressBar2(global::Microsoft.UI.Xaml.Controls.ProgressBar obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ProgressBar2(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ProgressBar2_Value(obj.Value, phase);
                    }
                }
            }
            private void Update_ProgressBar2_Value(global::System.Double obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // ControlPages\ProgressBarPage.xaml line 65
                    if (!isobj8ValueDisabled)
                    {
                        XamlBindingSetters.Set_AppUIBasics_ControlExampleSubstitution_Value(this.obj8, obj, null);
                    }
                }
            }
            private void Update_PausedRB(global::Microsoft.UI.Xaml.Controls.RadioButton obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_PausedRB(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_PausedRB_IsChecked(obj.IsChecked, phase);
                    }
                }
            }
            private void Update_PausedRB_IsChecked(global::System.Nullable<global::System.Boolean> obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_PausedRB_IsChecked_Value(obj.Value, phase);
                    }
                }
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // ControlPages\ProgressBarPage.xaml line 39
                    if (!isobj13ValueDisabled)
                    {
                        XamlBindingSetters.Set_AppUIBasics_ControlExampleSubstitution_Value(this.obj13, obj, null);
                    }
                }
            }
            private void Update_PausedRB_IsChecked_Value(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // ControlPages\ProgressBarPage.xaml line 22
                    if (!isobj9ShowPausedDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ProgressBar_ShowPaused(this.obj9, obj);
                    }
                }
            }
            private void Update_ErrorRB(global::Microsoft.UI.Xaml.Controls.RadioButton obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ErrorRB(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ErrorRB_IsChecked(obj.IsChecked, phase);
                    }
                }
            }
            private void Update_ErrorRB_IsChecked(global::System.Nullable<global::System.Boolean> obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ErrorRB_IsChecked_Value(obj.Value, phase);
                    }
                }
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // ControlPages\ProgressBarPage.xaml line 40
                    if (!isobj14ValueDisabled)
                    {
                        XamlBindingSetters.Set_AppUIBasics_ControlExampleSubstitution_Value(this.obj14, obj, null);
                    }
                }
            }
            private void Update_ErrorRB_IsChecked_Value(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // ControlPages\ProgressBarPage.xaml line 22
                    if (!isobj9ShowErrorDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ProgressBar_ShowError(this.obj9, obj);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class ProgressBarPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<ProgressBarPage_obj1_Bindings> weakRefToBindingObj; 

                public ProgressBarPage_obj1_BindingsTracking(ProgressBarPage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<ProgressBarPage_obj1_Bindings>(obj);
                }

                public ProgressBarPage_obj1_Bindings TryGetBindingObject()
                {
                    ProgressBarPage_obj1_Bindings bindingObject = null;
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
                    UpdateChildListeners_ProgressBar2(null);
                    UpdateChildListeners_PausedRB(null);
                    UpdateChildListeners_ErrorRB(null);
                }

                public void DependencyPropertyChanged_ProgressBar2_Value(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    ProgressBarPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Microsoft.UI.Xaml.Controls.ProgressBar obj = sender as global::Microsoft.UI.Xaml.Controls.ProgressBar;
                        if (obj != null)
                        {
                            bindings.Update_ProgressBar2_Value(obj.Value, DATA_CHANGED);
                        }
                    }
                }
                private global::Microsoft.UI.Xaml.Controls.ProgressBar cache_ProgressBar2 = null;
                private long tokenDPC_ProgressBar2_Value = 0;
                public void UpdateChildListeners_ProgressBar2(global::Microsoft.UI.Xaml.Controls.ProgressBar obj)
                {
                    if (obj != cache_ProgressBar2)
                    {
                        if (cache_ProgressBar2 != null)
                        {
                            cache_ProgressBar2.UnregisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Primitives.RangeBase.ValueProperty, tokenDPC_ProgressBar2_Value);
                            cache_ProgressBar2 = null;
                        }
                        if (obj != null)
                        {
                            cache_ProgressBar2 = obj;
                            tokenDPC_ProgressBar2_Value = obj.RegisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Primitives.RangeBase.ValueProperty, DependencyPropertyChanged_ProgressBar2_Value);
                        }
                    }
                }
                public void DependencyPropertyChanged_PausedRB_IsChecked(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    ProgressBarPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Microsoft.UI.Xaml.Controls.RadioButton obj = sender as global::Microsoft.UI.Xaml.Controls.RadioButton;
                        if (obj != null)
                        {
                            bindings.Update_PausedRB_IsChecked(obj.IsChecked, DATA_CHANGED);
                        }
                    }
                }
                private global::Microsoft.UI.Xaml.Controls.RadioButton cache_PausedRB = null;
                private long tokenDPC_PausedRB_IsChecked = 0;
                public void UpdateChildListeners_PausedRB(global::Microsoft.UI.Xaml.Controls.RadioButton obj)
                {
                    if (obj != cache_PausedRB)
                    {
                        if (cache_PausedRB != null)
                        {
                            cache_PausedRB.UnregisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton.IsCheckedProperty, tokenDPC_PausedRB_IsChecked);
                            cache_PausedRB = null;
                        }
                        if (obj != null)
                        {
                            cache_PausedRB = obj;
                            tokenDPC_PausedRB_IsChecked = obj.RegisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton.IsCheckedProperty, DependencyPropertyChanged_PausedRB_IsChecked);
                        }
                    }
                }
                public void DependencyPropertyChanged_ErrorRB_IsChecked(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    ProgressBarPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Microsoft.UI.Xaml.Controls.RadioButton obj = sender as global::Microsoft.UI.Xaml.Controls.RadioButton;
                        if (obj != null)
                        {
                            bindings.Update_ErrorRB_IsChecked(obj.IsChecked, DATA_CHANGED);
                        }
                    }
                }
                private global::Microsoft.UI.Xaml.Controls.RadioButton cache_ErrorRB = null;
                private long tokenDPC_ErrorRB_IsChecked = 0;
                public void UpdateChildListeners_ErrorRB(global::Microsoft.UI.Xaml.Controls.RadioButton obj)
                {
                    if (obj != cache_ErrorRB)
                    {
                        if (cache_ErrorRB != null)
                        {
                            cache_ErrorRB.UnregisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton.IsCheckedProperty, tokenDPC_ErrorRB_IsChecked);
                            cache_ErrorRB = null;
                        }
                        if (obj != null)
                        {
                            cache_ErrorRB = obj;
                            tokenDPC_ErrorRB_IsChecked = obj.RegisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton.IsCheckedProperty, DependencyPropertyChanged_ErrorRB_IsChecked);
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
            case 2: // ControlPages\ProgressBarPage.xaml line 20
                {
                    this.Example1 = global::WinRT.CastExtensions.As<global::AppUIBasics.ControlExample>(target);
                }
                break;
            case 3: // ControlPages\ProgressBarPage.xaml line 45
                {
                    this.Control2 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.StackPanel>(target);
                }
                break;
            case 4: // ControlPages\ProgressBarPage.xaml line 46
                {
                    this.ProgressBar2 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ProgressBar>(target);
                }
                break;
            case 5: // ControlPages\ProgressBarPage.xaml line 47
                {
                    this.Control2Output = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                }
                break;
            case 6: // ControlPages\ProgressBarPage.xaml line 48
                {
                    this.ProgressLabel = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                }
                break;
            case 7: // ControlPages\ProgressBarPage.xaml line 49
                {
                    this.ProgressValue = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.NumberBox>(target);
                    ((global::Microsoft.UI.Xaml.Controls.NumberBox)this.ProgressValue).ValueChanged += this.ProgressValue_ValueChanged;
                }
                break;
            case 10: // ControlPages\ProgressBarPage.xaml line 28
                {
                    this.RunningRB = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.RadioButton>(target);
                }
                break;
            case 11: // ControlPages\ProgressBarPage.xaml line 29
                {
                    this.PausedRB = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.RadioButton>(target);
                }
                break;
            case 12: // ControlPages\ProgressBarPage.xaml line 30
                {
                    this.ErrorRB = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.RadioButton>(target);
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
            case 1: // ControlPages\ProgressBarPage.xaml line 12
                {                    
                    global::Microsoft.UI.Xaml.Controls.Page element1 = (global::Microsoft.UI.Xaml.Controls.Page)target;
                    ProgressBarPage_obj1_Bindings bindings = new ProgressBarPage_obj1_Bindings();
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
