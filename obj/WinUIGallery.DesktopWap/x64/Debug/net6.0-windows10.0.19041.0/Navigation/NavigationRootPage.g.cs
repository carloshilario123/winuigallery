﻿#pragma checksum "E:\Trabajo\project\winuigallery\Navigation\NavigationRootPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "926C50D776A70BDF95C58C3CD0204DC611EA9ABBAAFD885E5751D52AF499B952"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppUIBasics
{
    partial class NavigationRootPage : 
        global::Microsoft.UI.Xaml.Controls.Page, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
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
        private class NavigationRootPage_obj1_Bindings :
            global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent,
            global::Microsoft.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Microsoft.UI.Xaml.Markup.IComponentConnector,
            INavigationRootPage_Bindings
        {
            private global::AppUIBasics.NavigationRootPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Microsoft.UI.Xaml.Controls.TextBlock obj37;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj37TextDisabled = false;

            public NavigationRootPage_obj1_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 69 && columnNumber == 21)
                {
                    isobj37TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 37: // Navigation\NavigationRootPage.xaml line 64
                        this.obj37 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
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

            // INavigationRootPage_Bindings

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
                    this.dataRoot = global::WinRT.CastExtensions.As<global::AppUIBasics.NavigationRootPage>(newDataRoot);
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
            private void Update_(global::AppUIBasics.NavigationRootPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_AppTitleText(obj.AppTitleText, phase);
                    }
                }
            }
            private void Update_AppTitleText(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Navigation\NavigationRootPage.xaml line 64
                    if (!isobj37TextDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(this.obj37, obj, null);
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
            case 2: // Navigation\NavigationRootPage.xaml line 30
                {
                    this.TitleBarStates = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.VisualStateGroup>(target);
                }
                break;
            case 3: // Navigation\NavigationRootPage.xaml line 43
                {
                    this.WindowActivationStates = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.VisualStateGroup>(target);
                }
                break;
            case 4: // Navigation\NavigationRootPage.xaml line 44
                {
                    this.Activated = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.VisualState>(target);
                }
                break;
            case 5: // Navigation\NavigationRootPage.xaml line 45
                {
                    this.Deactivated = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.VisualState>(target);
                }
                break;
            case 6: // Navigation\NavigationRootPage.xaml line 31
                {
                    this.Default = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.VisualState>(target);
                }
                break;
            case 7: // Navigation\NavigationRootPage.xaml line 32
                {
                    this.Compact = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.VisualState>(target);
                }
                break;
            case 8: // Navigation\NavigationRootPage.xaml line 37
                {
                    this.Top = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.VisualState>(target);
                }
                break;
            case 9: // Navigation\NavigationRootPage.xaml line 53
                {
                    this.AppTitleBar = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Border>(target);
                }
                break;
            case 10: // Navigation\NavigationRootPage.xaml line 73
                {
                    this.AutomationHelpersPanel = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Grid>(target);
                }
                break;
            case 11: // Navigation\NavigationRootPage.xaml line 153
                {
                    this.NavigationViewControl = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.NavigationView>(target);
                    ((global::Microsoft.UI.Xaml.Controls.NavigationView)this.NavigationViewControl).DisplayModeChanged += this.OnPaneDisplayModeChanged;
                    ((global::Microsoft.UI.Xaml.Controls.NavigationView)this.NavigationViewControl).Loaded += this.OnNavigationViewControlLoaded;
                    ((global::Microsoft.UI.Xaml.Controls.NavigationView)this.NavigationViewControl).SelectionChanged += this.OnNavigationViewSelectionChanged;
                }
                break;
            case 12: // Navigation\NavigationRootPage.xaml line 164
                {
                    this.controlsSearchBox = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AutoSuggestBox>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AutoSuggestBox)this.controlsSearchBox).QuerySubmitted += this.OnControlsSearchBoxQuerySubmitted;
                    ((global::Microsoft.UI.Xaml.Controls.AutoSuggestBox)this.controlsSearchBox).TextChanged += this.OnControlsSearchBoxTextChanged;
                }
                break;
            case 13: // Navigation\NavigationRootPage.xaml line 175
                {
                    global::Microsoft.UI.Xaml.Input.KeyboardAccelerator element13 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Input.KeyboardAccelerator>(target);
                    ((global::Microsoft.UI.Xaml.Input.KeyboardAccelerator)element13).Invoked += this.CtrlF_Invoked;
                }
                break;
            case 14: // Navigation\NavigationRootPage.xaml line 183
                {
                    this.rootFrame = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Frame>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Frame)this.rootFrame).Navigated += this.OnRootFrameNavigated;
                    ((global::Microsoft.UI.Xaml.Controls.Frame)this.rootFrame).Navigating += this.OnRootFrameNavigating;
                }
                break;
            case 15: // Navigation\NavigationRootPage.xaml line 188
                {
                    this.NewControlsItem = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.NavigationViewItem>(target);
                }
                break;
            case 16: // Navigation\NavigationRootPage.xaml line 193
                {
                    this.DesignGuidanceItem = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.NavigationViewItem>(target);
                }
                break;
            case 17: // Navigation\NavigationRootPage.xaml line 238
                {
                    this.AllControlsItem = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.NavigationViewItem>(target);
                }
                break;
            case 18: // Navigation\NavigationRootPage.xaml line 201
                {
                    this.TypographyItem = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.NavigationViewItem>(target);
                }
                break;
            case 19: // Navigation\NavigationRootPage.xaml line 206
                {
                    this.IconsItem = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.NavigationViewItem>(target);
                }
                break;
            case 20: // Navigation\NavigationRootPage.xaml line 211
                {
                    this.ColorsItem = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.NavigationViewItem>(target);
                }
                break;
            case 21: // Navigation\NavigationRootPage.xaml line 216
                {
                    this.AccessibilityItem = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.NavigationViewItem>(target);
                }
                break;
            case 22: // Navigation\NavigationRootPage.xaml line 221
                {
                    this.AccessibilityScreenReaderPage = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.NavigationViewItem>(target);
                }
                break;
            case 23: // Navigation\NavigationRootPage.xaml line 225
                {
                    this.AccessibilityKeyboardPage = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.NavigationViewItem>(target);
                }
                break;
            case 24: // Navigation\NavigationRootPage.xaml line 229
                {
                    this.AccessibilityContrastPage = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.NavigationViewItem>(target);
                }
                break;
            case 25: // Navigation\NavigationRootPage.xaml line 84
                {
                    this.CurrentPageTextBlock = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                }
                break;
            case 26: // Navigation\NavigationRootPage.xaml line 95
                {
                    this.GoBackInvokerButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)this.GoBackInvokerButton).Click += this.GoBackInvokerButton_Click;
                }
                break;
            case 27: // Navigation\NavigationRootPage.xaml line 100
                {
                    this.CloseAppInvokerButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)this.CloseAppInvokerButton).Click += this.CloseAppInvokerButton_Click;
                }
                break;
            case 28: // Navigation\NavigationRootPage.xaml line 105
                {
                    this.WaitForIdleInvokerButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)this.WaitForIdleInvokerButton).Click += this.WaitForIdleInvokerButton_Click;
                }
                break;
            case 29: // Navigation\NavigationRootPage.xaml line 110
                {
                    this._idleStateEnteredCheckBox = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.CheckBox>(target);
                }
                break;
            case 30: // Navigation\NavigationRootPage.xaml line 114
                {
                    this._errorReportingTextBox = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBox>(target);
                }
                break;
            case 31: // Navigation\NavigationRootPage.xaml line 118
                {
                    this._logReportingTextBox = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBox>(target);
                }
                break;
            case 32: // Navigation\NavigationRootPage.xaml line 122
                {
                    this.ViewScalingCheckBox = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.CheckBox>(target);
                }
                break;
            case 33: // Navigation\NavigationRootPage.xaml line 126
                {
                    this.WaitForDebuggerInvokerButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)this.WaitForDebuggerInvokerButton).Click += this.WaitForDebuggerInvokerButton_Click;
                }
                break;
            case 34: // Navigation\NavigationRootPage.xaml line 131
                {
                    this.DebuggerAttachedCheckBox = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.CheckBox>(target);
                }
                break;
            case 35: // Navigation\NavigationRootPage.xaml line 135
                {
                    this.UnhandledExceptionReportingTextBox = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBox>(target);
                }
                break;
            case 36: // Navigation\NavigationRootPage.xaml line 140
                {
                    this.TestContentLoadedCheckBox = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.CheckBox>(target);
                }
                break;
            case 37: // Navigation\NavigationRootPage.xaml line 64
                {
                    this.AppTitle = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
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
            case 1: // Navigation\NavigationRootPage.xaml line 12
                {                    
                    global::Microsoft.UI.Xaml.Controls.Page element1 = (global::Microsoft.UI.Xaml.Controls.Page)target;
                    NavigationRootPage_obj1_Bindings bindings = new NavigationRootPage_obj1_Bindings();
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
