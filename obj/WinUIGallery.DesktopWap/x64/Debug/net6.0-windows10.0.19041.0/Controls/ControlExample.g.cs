﻿#pragma checksum "E:\Trabajo\project\winuigallery\Controls\ControlExample.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AA9E72E0E84F9BAA2CD3913270CD02A053264898C9CE1AC5F1AC353B3126E4C0"
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
    partial class ControlExample : 
        global::Microsoft.UI.Xaml.Controls.UserControl, 
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
            public static void Set_Microsoft_UI_Xaml_Automation_AutomationProperties_LabeledBy(global::Microsoft.UI.Xaml.DependencyObject obj, global::Microsoft.UI.Xaml.UIElement value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Microsoft.UI.Xaml.UIElement) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Microsoft.UI.Xaml.UIElement), targetNullValue);
                }
                global::Microsoft.UI.Xaml.Automation.AutomationProperties.SetLabeledBy(obj, value);
            }
            public static void Set_AppUIBasics_Controls_SampleCodePresenter_Code(global::AppUIBasics.Controls.SampleCodePresenter obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Code = value ?? global::System.String.Empty;
            }
            public static void Set_AppUIBasics_Controls_SampleCodePresenter_CodeSourceFile(global::AppUIBasics.Controls.SampleCodePresenter obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.CodeSourceFile = value ?? global::System.String.Empty;
            }
            public static void Set_AppUIBasics_Controls_SampleCodePresenter_Substitutions(global::AppUIBasics.Controls.SampleCodePresenter obj, global::System.Collections.Generic.IList<global::AppUIBasics.ControlExampleSubstitution> value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Collections.Generic.IList<global::AppUIBasics.ControlExampleSubstitution>) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Collections.Generic.IList<global::AppUIBasics.ControlExampleSubstitution>), targetNullValue);
                }
                obj.Substitutions = value;
            }
            public static void Set_Microsoft_UI_Xaml_Controls_ContentPresenter_HorizontalContentAlignment(global::Microsoft.UI.Xaml.Controls.ContentPresenter obj, global::Microsoft.UI.Xaml.HorizontalAlignment value)
            {
                obj.HorizontalContentAlignment = value;
            }
            public static void Set_Microsoft_UI_Xaml_Controls_ContentPresenter_Content(global::Microsoft.UI.Xaml.Controls.ContentPresenter obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.Content = value;
            }
            public static void Set_Microsoft_UI_Xaml_UIElement_Visibility(global::Microsoft.UI.Xaml.UIElement obj, global::Microsoft.UI.Xaml.Visibility value)
            {
                obj.Visibility = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class ControlExample_obj1_Bindings :
            global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent,
            global::Microsoft.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Microsoft.UI.Xaml.Markup.IComponentConnector,
            IControlExample_Bindings
        {
            private global::AppUIBasics.ControlExample dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private global::Microsoft.UI.Xaml.ResourceDictionary localResources;
            private global::System.WeakReference<global::Microsoft.UI.Xaml.FrameworkElement> converterLookupRoot;

            // Fields for each control that has bindings.
            private global::Microsoft.UI.Xaml.Controls.TextBlock obj10;
            private global::Microsoft.UI.Xaml.Controls.TextBox obj17;
            private global::AppUIBasics.Controls.SampleCodePresenter obj18;
            private global::AppUIBasics.Controls.SampleCodePresenter obj20;
            private global::Microsoft.UI.Xaml.Controls.ContentPresenter obj22;
            private global::Microsoft.UI.Xaml.Controls.StackPanel obj23;
            private global::Microsoft.UI.Xaml.Controls.ContentPresenter obj24;
            private global::Microsoft.UI.Xaml.Controls.ContentPresenter obj25;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj10TextDisabled = false;
            private static bool isobj17LabeledByDisabled = false;
            private static bool isobj18CodeDisabled = false;
            private static bool isobj18CodeSourceFileDisabled = false;
            private static bool isobj18SubstitutionsDisabled = false;
            private static bool isobj20CodeDisabled = false;
            private static bool isobj20CodeSourceFileDisabled = false;
            private static bool isobj20SubstitutionsDisabled = false;
            private static bool isobj22HorizontalContentAlignmentDisabled = false;
            private static bool isobj22ContentDisabled = false;
            private static bool isobj23VisibilityDisabled = false;
            private static bool isobj24ContentDisabled = false;
            private static bool isobj24VisibilityDisabled = false;
            private static bool isobj25ContentDisabled = false;

            private ControlExample_obj1_BindingsTracking bindingsTracking;

            public ControlExample_obj1_Bindings()
            {
                this.bindingsTracking = new ControlExample_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 73 && columnNumber == 13)
                {
                    isobj10TextDisabled = true;
                }
                else if (lineNumber == 220 && columnNumber == 21)
                {
                    isobj17LabeledByDisabled = true;
                }
                else if (lineNumber == 170 && columnNumber == 25)
                {
                    isobj18CodeDisabled = true;
                }
                else if (lineNumber == 171 && columnNumber == 25)
                {
                    isobj18CodeSourceFileDisabled = true;
                }
                else if (lineNumber == 172 && columnNumber == 25)
                {
                    isobj18SubstitutionsDisabled = true;
                }
                else if (lineNumber == 181 && columnNumber == 25)
                {
                    isobj20CodeDisabled = true;
                }
                else if (lineNumber == 182 && columnNumber == 25)
                {
                    isobj20CodeSourceFileDisabled = true;
                }
                else if (lineNumber == 184 && columnNumber == 25)
                {
                    isobj20SubstitutionsDisabled = true;
                }
                else if (lineNumber == 118 && columnNumber == 29)
                {
                    isobj22HorizontalContentAlignmentDisabled = true;
                }
                else if (lineNumber == 122 && columnNumber == 29)
                {
                    isobj22ContentDisabled = true;
                }
                else if (lineNumber == 135 && columnNumber == 25)
                {
                    isobj23VisibilityDisabled = true;
                }
                else if (lineNumber == 150 && columnNumber == 25)
                {
                    isobj24ContentDisabled = true;
                }
                else if (lineNumber == 151 && columnNumber == 25)
                {
                    isobj24VisibilityDisabled = true;
                }
                else if (lineNumber == 137 && columnNumber == 68)
                {
                    isobj25ContentDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 10: // Controls\ControlExample.xaml line 68
                        this.obj10 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                        break;
                    case 17: // Controls\ControlExample.xaml line 217
                        this.obj17 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBox>(target);
                        break;
                    case 18: // Controls\ControlExample.xaml line 168
                        this.obj18 = global::WinRT.CastExtensions.As<global::AppUIBasics.Controls.SampleCodePresenter>(target);
                        break;
                    case 20: // Controls\ControlExample.xaml line 179
                        this.obj20 = global::WinRT.CastExtensions.As<global::AppUIBasics.Controls.SampleCodePresenter>(target);
                        break;
                    case 22: // Controls\ControlExample.xaml line 113
                        this.obj22 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ContentPresenter>(target);
                        break;
                    case 23: // Controls\ControlExample.xaml line 126
                        this.obj23 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.StackPanel>(target);
                        break;
                    case 24: // Controls\ControlExample.xaml line 141
                        this.obj24 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ContentPresenter>(target);
                        break;
                    case 25: // Controls\ControlExample.xaml line 137
                        this.obj25 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ContentPresenter>(target);
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

            // IControlExample_Bindings

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
                    this.dataRoot = global::WinRT.CastExtensions.As<global::AppUIBasics.ControlExample>(newDataRoot);
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
            public void SetConverterLookupRoot(global::Microsoft.UI.Xaml.FrameworkElement rootElement)
            {
                this.converterLookupRoot = new global::System.WeakReference<global::Microsoft.UI.Xaml.FrameworkElement>(rootElement);
            }

            public global::Microsoft.UI.Xaml.Data.IValueConverter LookupConverter(string key)
            {
                if (this.localResources == null)
                {
                    global::Microsoft.UI.Xaml.FrameworkElement rootElement;
                    this.converterLookupRoot.TryGetTarget(out rootElement);
                    this.localResources = rootElement.Resources;
                    this.converterLookupRoot = null;
                }
                return (global::Microsoft.UI.Xaml.Data.IValueConverter) (this.localResources.ContainsKey(key) ? this.localResources[key] : global::Microsoft.UI.Xaml.Application.Current.Resources[key]);
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::AppUIBasics.ControlExample obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_HeaderText(obj.HeaderText, phase);
                        this.Update_PaddingLabel(obj.PaddingLabel, phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_Xaml(obj.Xaml, phase);
                        this.Update_XamlSource(obj.XamlSource, phase);
                        this.Update_Substitutions(obj.Substitutions, phase);
                        this.Update_CSharp(obj.CSharp, phase);
                        this.Update_CSharpSource(obj.CSharpSource, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_HorizontalContentAlignment(obj.HorizontalContentAlignment, phase);
                        this.Update_Example(obj.Example, phase);
                        this.Update_Output(obj.Output, phase);
                        this.Update_Options(obj.Options, phase);
                    }
                }
            }
            private void Update_HeaderText(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Controls\ControlExample.xaml line 68
                    if (!isobj10TextDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(this.obj10, obj, null);
                    }
                }
            }
            private void Update_PaddingLabel(global::Microsoft.UI.Xaml.Controls.TextBlock obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Controls\ControlExample.xaml line 217
                    if (!isobj17LabeledByDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Automation_AutomationProperties_LabeledBy(this.obj17, obj, null);
                    }
                }
            }
            private void Update_Xaml(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\ControlExample.xaml line 168
                    if (!isobj18CodeDisabled)
                    {
                        XamlBindingSetters.Set_AppUIBasics_Controls_SampleCodePresenter_Code(this.obj18, obj, null);
                    }
                }
            }
            private void Update_XamlSource(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\ControlExample.xaml line 168
                    if (!isobj18CodeSourceFileDisabled)
                    {
                        XamlBindingSetters.Set_AppUIBasics_Controls_SampleCodePresenter_CodeSourceFile(this.obj18, obj, null);
                    }
                }
            }
            private void Update_Substitutions(global::System.Collections.Generic.IList<global::AppUIBasics.ControlExampleSubstitution> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\ControlExample.xaml line 168
                    if (!isobj18SubstitutionsDisabled)
                    {
                        XamlBindingSetters.Set_AppUIBasics_Controls_SampleCodePresenter_Substitutions(this.obj18, obj, null);
                    }
                    // Controls\ControlExample.xaml line 179
                    if (!isobj20SubstitutionsDisabled)
                    {
                        XamlBindingSetters.Set_AppUIBasics_Controls_SampleCodePresenter_Substitutions(this.obj20, obj, null);
                    }
                }
            }
            private void Update_CSharp(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\ControlExample.xaml line 179
                    if (!isobj20CodeDisabled)
                    {
                        XamlBindingSetters.Set_AppUIBasics_Controls_SampleCodePresenter_Code(this.obj20, obj, null);
                    }
                }
            }
            private void Update_CSharpSource(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\ControlExample.xaml line 179
                    if (!isobj20CodeSourceFileDisabled)
                    {
                        XamlBindingSetters.Set_AppUIBasics_Controls_SampleCodePresenter_CodeSourceFile(this.obj20, obj, null);
                    }
                }
            }
            private void Update_HorizontalContentAlignment(global::Microsoft.UI.Xaml.HorizontalAlignment obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Controls\ControlExample.xaml line 113
                    if (!isobj22HorizontalContentAlignmentDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ContentPresenter_HorizontalContentAlignment(this.obj22, obj);
                    }
                }
            }
            private void Update_Example(global::System.Object obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Controls\ControlExample.xaml line 113
                    if (!isobj22ContentDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ContentPresenter_Content(this.obj22, obj, null);
                    }
                }
            }
            private void Update_Output(global::System.Object obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Controls\ControlExample.xaml line 126
                    if (!isobj23VisibilityDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_UIElement_Visibility(this.obj23, (global::Microsoft.UI.Xaml.Visibility)this.LookupConverter("nullToVisibilityConverter").Convert(obj, typeof(global::Microsoft.UI.Xaml.Visibility), null, null));
                    }
                    // Controls\ControlExample.xaml line 137
                    if (!isobj25ContentDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ContentPresenter_Content(this.obj25, obj, null);
                    }
                }
            }
            private void Update_Options(global::System.Object obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Controls\ControlExample.xaml line 141
                    if (!isobj24ContentDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ContentPresenter_Content(this.obj24, obj, null);
                    }
                    // Controls\ControlExample.xaml line 141
                    if (!isobj24VisibilityDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_UIElement_Visibility(this.obj24, (global::Microsoft.UI.Xaml.Visibility)this.LookupConverter("nullToVisibilityConverter").Convert(obj, typeof(global::Microsoft.UI.Xaml.Visibility), null, null));
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class ControlExample_obj1_BindingsTracking
            {
                private global::System.WeakReference<ControlExample_obj1_Bindings> weakRefToBindingObj; 

                public ControlExample_obj1_BindingsTracking(ControlExample_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<ControlExample_obj1_Bindings>(obj);
                }

                public ControlExample_obj1_Bindings TryGetBindingObject()
                {
                    ControlExample_obj1_Bindings bindingObject = null;
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

                public void DependencyPropertyChanged_Xaml(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    ControlExample_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::AppUIBasics.ControlExample obj = sender as global::AppUIBasics.ControlExample;
                        if (obj != null)
                        {
                            bindings.Update_Xaml(obj.Xaml, DATA_CHANGED);
                        }
                    }
                }
                public void DependencyPropertyChanged_XamlSource(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    ControlExample_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::AppUIBasics.ControlExample obj = sender as global::AppUIBasics.ControlExample;
                        if (obj != null)
                        {
                            bindings.Update_XamlSource(obj.XamlSource, DATA_CHANGED);
                        }
                    }
                }
                public void DependencyPropertyChanged_Substitutions(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    ControlExample_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::AppUIBasics.ControlExample obj = sender as global::AppUIBasics.ControlExample;
                        if (obj != null)
                        {
                            bindings.Update_Substitutions(obj.Substitutions, DATA_CHANGED);
                        }
                    }
                }
                public void DependencyPropertyChanged_CSharp(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    ControlExample_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::AppUIBasics.ControlExample obj = sender as global::AppUIBasics.ControlExample;
                        if (obj != null)
                        {
                            bindings.Update_CSharp(obj.CSharp, DATA_CHANGED);
                        }
                    }
                }
                public void DependencyPropertyChanged_CSharpSource(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    ControlExample_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::AppUIBasics.ControlExample obj = sender as global::AppUIBasics.ControlExample;
                        if (obj != null)
                        {
                            bindings.Update_CSharpSource(obj.CSharpSource, DATA_CHANGED);
                        }
                    }
                }
                private long tokenDPC_Xaml = 0;
                private long tokenDPC_XamlSource = 0;
                private long tokenDPC_Substitutions = 0;
                private long tokenDPC_CSharp = 0;
                private long tokenDPC_CSharpSource = 0;
                public void UpdateChildListeners_(global::AppUIBasics.ControlExample obj)
                {
                    ControlExample_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        if (bindings.dataRoot != null)
                        {
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::AppUIBasics.ControlExample.XamlProperty, tokenDPC_Xaml);
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::AppUIBasics.ControlExample.XamlSourceProperty, tokenDPC_XamlSource);
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::AppUIBasics.ControlExample.SubstitutionsProperty, tokenDPC_Substitutions);
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::AppUIBasics.ControlExample.CSharpProperty, tokenDPC_CSharp);
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::AppUIBasics.ControlExample.CSharpSourceProperty, tokenDPC_CSharpSource);
                        }
                        if (obj != null)
                        {
                            bindings.dataRoot = obj;
                            tokenDPC_Xaml = obj.RegisterPropertyChangedCallback(global::AppUIBasics.ControlExample.XamlProperty, DependencyPropertyChanged_Xaml);
                            tokenDPC_XamlSource = obj.RegisterPropertyChangedCallback(global::AppUIBasics.ControlExample.XamlSourceProperty, DependencyPropertyChanged_XamlSource);
                            tokenDPC_Substitutions = obj.RegisterPropertyChangedCallback(global::AppUIBasics.ControlExample.SubstitutionsProperty, DependencyPropertyChanged_Substitutions);
                            tokenDPC_CSharp = obj.RegisterPropertyChangedCallback(global::AppUIBasics.ControlExample.CSharpProperty, DependencyPropertyChanged_CSharp);
                            tokenDPC_CSharpSource = obj.RegisterPropertyChangedCallback(global::AppUIBasics.ControlExample.CSharpSourceProperty, DependencyPropertyChanged_CSharpSource);
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
            case 1: // Controls\ControlExample.xaml line 1
                {
                    this.RootPanel = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.UserControl>(target);
                }
                break;
            case 2: // Controls\ControlExample.xaml line 16
                {
                    this.rootGrid = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Grid>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Grid)this.rootGrid).Loaded += this.rootGrid_Loaded;
                }
                break;
            case 3: // Controls\ControlExample.xaml line 58
                {
                    this.SampleCodeSeparatorStates = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.VisualStateGroup>(target);
                }
                break;
            case 4: // Controls\ControlExample.xaml line 59
                {
                    this.SeparatorCollapsed = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.VisualState>(target);
                }
                break;
            case 5: // Controls\ControlExample.xaml line 60
                {
                    this.SeparatorVisible = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.VisualState>(target);
                }
                break;
            case 6: // Controls\ControlExample.xaml line 46
                {
                    this.NormalMode = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.VisualState>(target);
                }
                break;
            case 7: // Controls\ControlExample.xaml line 47
                {
                    this.ScreenshotMode = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.VisualState>(target);
                }
                break;
            case 8: // Controls\ControlExample.xaml line 25
                {
                    this.IntermediateLayout = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.VisualState>(target);
                }
                break;
            case 9: // Controls\ControlExample.xaml line 30
                {
                    this.PhoneLayout = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.VisualState>(target);
                }
                break;
            case 10: // Controls\ControlExample.xaml line 68
                {
                    this.HeaderTextPresenter = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                }
                break;
            case 11: // Controls\ControlExample.xaml line 75
                {
                    this.ErrorTextBlock = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.RichTextBlock>(target);
                }
                break;
            case 12: // Controls\ControlExample.xaml line 188
                {
                    this.ScreenshotControls = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.StackPanel>(target);
                }
                break;
            case 13: // Controls\ControlExample.xaml line 195
                {
                    this.ScreenshotButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)this.ScreenshotButton).Click += this.ScreenshotButton_Click;
                }
                break;
            case 14: // Controls\ControlExample.xaml line 201
                {
                    this.ScreenshotDelayButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)this.ScreenshotDelayButton).Click += this.ScreenshotDelayButton_Click;
                }
                break;
            case 15: // Controls\ControlExample.xaml line 207
                {
                    this.ScreenshotStatusTextBlock = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                }
                break;
            case 16: // Controls\ControlExample.xaml line 212
                {
                    this.PaddingLabel = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                }
                break;
            case 17: // Controls\ControlExample.xaml line 217
                {
                    this.ControlPaddingBox = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBox>(target);
                    ((global::Microsoft.UI.Xaml.Controls.TextBox)this.ControlPaddingBox).KeyUp += this.ControlPaddingBox_KeyUp;
                    ((global::Microsoft.UI.Xaml.Controls.TextBox)this.ControlPaddingBox).LostFocus += this.ControlPaddingBox_LostFocus;
                }
                break;
            case 18: // Controls\ControlExample.xaml line 168
                {
                    this.XamlPresenter = global::WinRT.CastExtensions.As<global::AppUIBasics.Controls.SampleCodePresenter>(target);
                }
                break;
            case 19: // Controls\ControlExample.xaml line 173
                {
                    this.SampleCodeSeparator = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Border>(target);
                }
                break;
            case 20: // Controls\ControlExample.xaml line 179
                {
                    this.CSharpPresenter = global::WinRT.CastExtensions.As<global::AppUIBasics.Controls.SampleCodePresenter>(target);
                }
                break;
            case 21: // Controls\ControlExample.xaml line 95
                {
                    this.ExampleContainer = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Grid>(target);
                }
                break;
            case 22: // Controls\ControlExample.xaml line 113
                {
                    this.ControlPresenter = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ContentPresenter>(target);
                }
                break;
            case 24: // Controls\ControlExample.xaml line 141
                {
                    this.OptionsPresenter = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ContentPresenter>(target);
                }
                break;
            case 25: // Controls\ControlExample.xaml line 137
                {
                    this.OutputPresenter = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ContentPresenter>(target);
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
            case 1: // Controls\ControlExample.xaml line 1
                {                    
                    global::Microsoft.UI.Xaml.Controls.UserControl element1 = (global::Microsoft.UI.Xaml.Controls.UserControl)target;
                    ControlExample_obj1_Bindings bindings = new ControlExample_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    bindings.SetConverterLookupRoot(this);
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
