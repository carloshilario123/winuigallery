﻿#pragma checksum "E:\Trabajo\project\winuigallery\ControlPages\TeachingTipPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B8FBAC5D1AA6E687F59B31963BB5280400F2B969F69ECF8A26FFA42733586F66"
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
    partial class TeachingTipPage : 
        global::Microsoft.UI.Xaml.Controls.Page, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Microsoft_UI_Xaml_Controls_TeachingTip_Target(global::Microsoft.UI.Xaml.Controls.TeachingTip obj, global::Microsoft.UI.Xaml.FrameworkElement value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Microsoft.UI.Xaml.FrameworkElement) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Microsoft.UI.Xaml.FrameworkElement), targetNullValue);
                }
                obj.Target = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class TeachingTipPage_obj1_Bindings :
            global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent,
            global::Microsoft.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Microsoft.UI.Xaml.Markup.IComponentConnector,
            ITeachingTipPage_Bindings
        {
            private global::AppUIBasics.ControlPages.TeachingTipPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Microsoft.UI.Xaml.Controls.TeachingTip obj3;
            private global::Microsoft.UI.Xaml.Controls.TeachingTip obj7;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj3TargetDisabled = false;
            private static bool isobj7TargetDisabled = false;

            public TeachingTipPage_obj1_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 79 && columnNumber == 25)
                {
                    isobj3TargetDisabled = true;
                }
                else if (lineNumber == 35 && columnNumber == 25)
                {
                    isobj7TargetDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 3: // ControlPages\TeachingTipPage.xaml line 74
                        this.obj3 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TeachingTip>(target);
                        break;
                    case 7: // ControlPages\TeachingTipPage.xaml line 31
                        this.obj7 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TeachingTip>(target);
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

            // ITeachingTipPage_Bindings

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
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = global::WinRT.CastExtensions.As<global::AppUIBasics.ControlPages.TeachingTipPage>(newDataRoot);
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
            private void Update_(global::AppUIBasics.ControlPages.TeachingTipPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_HeroButton(obj.HeroButton, phase);
                        this.Update_ThemeButton(obj.ThemeButton, phase);
                    }
                }
            }
            private void Update_HeroButton(global::Microsoft.UI.Xaml.Controls.Button obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // ControlPages\TeachingTipPage.xaml line 74
                    if (!isobj3TargetDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TeachingTip_Target(this.obj3, obj, null);
                    }
                }
            }
            private void Update_ThemeButton(global::Microsoft.UI.Xaml.Controls.Button obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // ControlPages\TeachingTipPage.xaml line 31
                    if (!isobj7TargetDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TeachingTip_Target(this.obj7, obj, null);
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
            case 2: // ControlPages\TeachingTipPage.xaml line 70
                {
                    this.HeroButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)this.HeroButton).Click += this.TestButtonClick3;
                }
                break;
            case 3: // ControlPages\TeachingTipPage.xaml line 74
                {
                    this.ToggleThemeTeachingTip3 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TeachingTip>(target);
                }
                break;
            case 4: // ControlPages\TeachingTipPage.xaml line 50
                {
                    global::Microsoft.UI.Xaml.Controls.Button element4 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)element4).Click += this.TestButtonClick2;
                }
                break;
            case 5: // ControlPages\TeachingTipPage.xaml line 51
                {
                    this.ToggleThemeTeachingTip2 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TeachingTip>(target);
                }
                break;
            case 6: // ControlPages\TeachingTipPage.xaml line 27
                {
                    this.ThemeButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)this.ThemeButton).Click += this.TestButtonClick1;
                }
                break;
            case 7: // ControlPages\TeachingTipPage.xaml line 31
                {
                    this.ToggleThemeTeachingTip1 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TeachingTip>(target);
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
            case 1: // ControlPages\TeachingTipPage.xaml line 12
                {                    
                    global::Microsoft.UI.Xaml.Controls.Page element1 = (global::Microsoft.UI.Xaml.Controls.Page)target;
                    TeachingTipPage_obj1_Bindings bindings = new TeachingTipPage_obj1_Bindings();
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

