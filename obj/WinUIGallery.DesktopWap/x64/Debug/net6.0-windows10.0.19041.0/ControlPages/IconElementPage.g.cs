﻿#pragma checksum "E:\Trabajo\project\winuigallery\ControlPages\IconElementPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3D72793F4B7BD2791ACA4627C96175EB18C5536C2EF2D61E5FF84A9041D4D489"
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
    partial class IconElementPage : 
        global::Microsoft.UI.Xaml.Controls.Page, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Microsoft_UI_Xaml_Controls_Primitives_ToggleButton_IsChecked(global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton obj, global::System.Nullable<global::System.Boolean> value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Boolean) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Boolean), targetNullValue);
                }
                obj.IsChecked = value;
            }
            public static void Set_AppUIBasics_ControlExampleSubstitution_Value(global::AppUIBasics.ControlExampleSubstitution obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.Value = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class IconElementPage_obj1_Bindings :
            global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent,
            global::Microsoft.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Microsoft.UI.Xaml.Markup.IComponentConnector,
            IIconElementPage_Bindings
        {
            private global::AppUIBasics.ControlPages.IconElementPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Microsoft.UI.Xaml.Controls.CheckBox obj8;
            private global::AppUIBasics.ControlExampleSubstitution obj9;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj8IsCheckedDisabled = false;
            private static bool isobj9ValueDisabled = false;

            private IconElementPage_obj1_BindingsTracking bindingsTracking;

            public IconElementPage_obj1_Bindings()
            {
                this.bindingsTracking = new IconElementPage_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 19 && columnNumber == 74)
                {
                    isobj8IsCheckedDisabled = true;
                }
                else if (lineNumber == 27 && columnNumber == 74)
                {
                    isobj9ValueDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 8: // ControlPages\IconElementPage.xaml line 19
                        this.obj8 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.CheckBox>(target);
                        this.bindingsTracking.RegisterTwoWayListener_8(this.obj8);
                        break;
                    case 9: // ControlPages\IconElementPage.xaml line 27
                        this.obj9 = global::WinRT.CastExtensions.As<global::AppUIBasics.ControlExampleSubstitution>(target);
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

            // IIconElementPage_Bindings

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
                    this.dataRoot = global::WinRT.CastExtensions.As<global::AppUIBasics.ControlPages.IconElementPage>(newDataRoot);
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
            private void Update_(global::AppUIBasics.ControlPages.IconElementPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_SlicesIcon(obj.SlicesIcon, phase);
                        this.Update_MonochromeButton(obj.MonochromeButton, phase);
                    }
                }
            }
            private void Update_SlicesIcon(global::Microsoft.UI.Xaml.Controls.BitmapIcon obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_SlicesIcon(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_SlicesIcon_ShowAsMonochrome(obj.ShowAsMonochrome, phase);
                    }
                }
            }
            private void Update_SlicesIcon_ShowAsMonochrome(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // ControlPages\IconElementPage.xaml line 19
                    if (!isobj8IsCheckedDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Primitives_ToggleButton_IsChecked(this.obj8, obj, null);
                    }
                }
            }
            private void Update_MonochromeButton(global::Microsoft.UI.Xaml.Controls.CheckBox obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_MonochromeButton(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_MonochromeButton_IsChecked(obj.IsChecked, phase);
                    }
                }
            }
            private void Update_MonochromeButton_IsChecked(global::System.Nullable<global::System.Boolean> obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_MonochromeButton_IsChecked_Value(obj.Value, phase);
                    }
                }
            }
            private void Update_MonochromeButton_IsChecked_Value(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // ControlPages\IconElementPage.xaml line 27
                    if (!isobj9ValueDisabled)
                    {
                        XamlBindingSetters.Set_AppUIBasics_ControlExampleSubstitution_Value(this.obj9, obj, null);
                    }
                }
            }
            private void UpdateTwoWay_8_IsChecked()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        if (this.dataRoot.SlicesIcon != null)
                        {
                            this.dataRoot.SlicesIcon.ShowAsMonochrome = (global::System.Boolean)this.obj8.IsChecked;
                        }
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class IconElementPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<IconElementPage_obj1_Bindings> weakRefToBindingObj; 

                public IconElementPage_obj1_BindingsTracking(IconElementPage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<IconElementPage_obj1_Bindings>(obj);
                }

                public IconElementPage_obj1_Bindings TryGetBindingObject()
                {
                    IconElementPage_obj1_Bindings bindingObject = null;
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
                    UpdateChildListeners_SlicesIcon(null);
                    UpdateChildListeners_MonochromeButton(null);
                }

                public void DependencyPropertyChanged_SlicesIcon_ShowAsMonochrome(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    IconElementPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Microsoft.UI.Xaml.Controls.BitmapIcon obj = sender as global::Microsoft.UI.Xaml.Controls.BitmapIcon;
                        if (obj != null)
                        {
                            bindings.Update_SlicesIcon_ShowAsMonochrome(obj.ShowAsMonochrome, DATA_CHANGED);
                        }
                    }
                }
                private global::Microsoft.UI.Xaml.Controls.BitmapIcon cache_SlicesIcon = null;
                private long tokenDPC_SlicesIcon_ShowAsMonochrome = 0;
                public void UpdateChildListeners_SlicesIcon(global::Microsoft.UI.Xaml.Controls.BitmapIcon obj)
                {
                    if (obj != cache_SlicesIcon)
                    {
                        if (cache_SlicesIcon != null)
                        {
                            cache_SlicesIcon.UnregisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.BitmapIcon.ShowAsMonochromeProperty, tokenDPC_SlicesIcon_ShowAsMonochrome);
                            cache_SlicesIcon = null;
                        }
                        if (obj != null)
                        {
                            cache_SlicesIcon = obj;
                            tokenDPC_SlicesIcon_ShowAsMonochrome = obj.RegisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.BitmapIcon.ShowAsMonochromeProperty, DependencyPropertyChanged_SlicesIcon_ShowAsMonochrome);
                        }
                    }
                }
                public void DependencyPropertyChanged_MonochromeButton_IsChecked(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    IconElementPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Microsoft.UI.Xaml.Controls.CheckBox obj = sender as global::Microsoft.UI.Xaml.Controls.CheckBox;
                        if (obj != null)
                        {
                            bindings.Update_MonochromeButton_IsChecked(obj.IsChecked, DATA_CHANGED);
                        }
                    }
                }
                private global::Microsoft.UI.Xaml.Controls.CheckBox cache_MonochromeButton = null;
                private long tokenDPC_MonochromeButton_IsChecked = 0;
                public void UpdateChildListeners_MonochromeButton(global::Microsoft.UI.Xaml.Controls.CheckBox obj)
                {
                    if (obj != cache_MonochromeButton)
                    {
                        if (cache_MonochromeButton != null)
                        {
                            cache_MonochromeButton.UnregisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton.IsCheckedProperty, tokenDPC_MonochromeButton_IsChecked);
                            cache_MonochromeButton = null;
                        }
                        if (obj != null)
                        {
                            cache_MonochromeButton = obj;
                            tokenDPC_MonochromeButton_IsChecked = obj.RegisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton.IsCheckedProperty, DependencyPropertyChanged_MonochromeButton_IsChecked);
                        }
                    }
                }
                public void RegisterTwoWayListener_8(global::Microsoft.UI.Xaml.Controls.CheckBox sourceObject)
                {
                    sourceObject.RegisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton.IsCheckedProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_8_IsChecked();
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
            case 2: // ControlPages\IconElementPage.xaml line 71
                {
                    this.AcceptButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                }
                break;
            case 3: // ControlPages\IconElementPage.xaml line 61
                {
                    this.Example1Button = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                }
                break;
            case 4: // ControlPages\IconElementPage.xaml line 52
                {
                    this.ImageExample2 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                }
                break;
            case 5: // ControlPages\IconElementPage.xaml line 44
                {
                    this.ImageExample1 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                }
                break;
            case 6: // ControlPages\IconElementPage.xaml line 34
                {
                    this.ExampleButton1 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                }
                break;
            case 7: // ControlPages\IconElementPage.xaml line 15
                {
                    this.SlicesIcon = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.BitmapIcon>(target);
                }
                break;
            case 8: // ControlPages\IconElementPage.xaml line 19
                {
                    this.MonochromeButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.CheckBox>(target);
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
            case 1: // ControlPages\IconElementPage.xaml line 1
                {                    
                    global::Microsoft.UI.Xaml.Controls.Page element1 = (global::Microsoft.UI.Xaml.Controls.Page)target;
                    IconElementPage_obj1_Bindings bindings = new IconElementPage_obj1_Bindings();
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
