﻿#pragma checksum "C:\Users\liuyh73\Desktop\期中项目\labcode\Competition\Competition\Views\Video.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "49462845609639A376872FA1937DCB58"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Competition.Views
{
    partial class Video : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_Primitives_RangeBase_Value(global::Windows.UI.Xaml.Controls.Primitives.RangeBase obj, global::System.Double value)
            {
                obj.Value = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class Video_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IVideo_Bindings
        {
            private global::Competition.Views.Video dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private global::Windows.UI.Xaml.ResourceDictionary localResources;
            private global::System.WeakReference<global::Windows.UI.Xaml.FrameworkElement> converterLookupRoot;

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Slider obj10;

            private Video_obj1_BindingsTracking bindingsTracking;

            public Video_obj1_Bindings()
            {
                this.bindingsTracking = new Video_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 10: // Views\Video.xaml line 29
                        this.obj10 = (global::Windows.UI.Xaml.Controls.Slider)target;
                        (this.obj10).RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Primitives.RangeBase.ValueProperty,
                            (global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop) =>
                            {
                            if (this.initialized)
                            {
                                // Update Two Way binding
                                this.dataRoot.mediaTimelineController.Position = (global::System.TimeSpan)this.LookupConverter("converter").ConvertBack(this.obj10.Value, typeof(global::System.TimeSpan), null, null);
                            }
                        });
                        break;
                    default:
                        break;
                }
            }

            // IVideo_Bindings

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
                    this.dataRoot = (global::Competition.Views.Video)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }
            public void SetConverterLookupRoot(global::Windows.UI.Xaml.FrameworkElement rootElement)
            {
                this.converterLookupRoot = new global::System.WeakReference<global::Windows.UI.Xaml.FrameworkElement>(rootElement);
            }

            public global::Windows.UI.Xaml.Data.IValueConverter LookupConverter(string key)
            {
                if (this.localResources == null)
                {
                    global::Windows.UI.Xaml.FrameworkElement rootElement;
                    this.converterLookupRoot.TryGetTarget(out rootElement);
                    this.localResources = rootElement.Resources;
                    this.converterLookupRoot = null;
                }
                return (global::Windows.UI.Xaml.Data.IValueConverter) (this.localResources.ContainsKey(key) ? this.localResources[key] : global::Windows.UI.Xaml.Application.Current.Resources[key]);
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Competition.Views.Video obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_mediaTimelineController(obj.mediaTimelineController, phase);
                    }
                }
            }
            private void Update_mediaTimelineController(global::Windows.Media.MediaTimelineController obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_mediaTimelineController_Position(obj.Position, phase);
                    }
                }
            }
            private void Update_mediaTimelineController_Position(global::System.TimeSpan obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\Video.xaml line 29
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_RangeBase_Value(this.obj10, (global::System.Double)this.LookupConverter("converter").Convert(obj, typeof(global::System.Double), null, null));
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class Video_obj1_BindingsTracking
            {
                private global::System.WeakReference<Video_obj1_Bindings> weakRefToBindingObj; 

                public Video_obj1_BindingsTracking(Video_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<Video_obj1_Bindings>(obj);
                }

                public Video_obj1_Bindings TryGetBindingObject()
                {
                    Video_obj1_Bindings bindingObject = null;
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
                }

            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Views\Video.xaml line 14
                {
                    this.grid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3: // Views\Video.xaml line 23
                {
                    this.mediaPlayerElement = (global::Windows.UI.Xaml.Controls.MediaPlayerElement)(target);
                }
                break;
            case 4: // Views\Video.xaml line 34
                {
                    this.FullButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.FullButton).Click += this.FullButton_Click;
                }
                break;
            case 5: // Views\Video.xaml line 35
                {
                    this.VolumnButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 6: // Views\Video.xaml line 42
                {
                    this.StopButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.StopButton).Click += this.StopButton_Click;
                }
                break;
            case 7: // Views\Video.xaml line 43
                {
                    this.PauseButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.PauseButton).Click += this.PauseButton_Click;
                }
                break;
            case 8: // Views\Video.xaml line 44
                {
                    this.PlayButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.PlayButton).Click += this.PlayButton_Click;
                }
                break;
            case 9: // Views\Video.xaml line 38
                {
                    this.Volumn = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    ((global::Windows.UI.Xaml.Controls.Slider)this.Volumn).ValueChanged += this.Volumn_ValueChanged;
                }
                break;
            case 10: // Views\Video.xaml line 29
                {
                    this.timeSlider = (global::Windows.UI.Xaml.Controls.Slider)(target);
                }
                break;
            case 11: // Views\Video.xaml line 30
                {
                    this.time = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // Views\Video.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    Video_obj1_Bindings bindings = new Video_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    bindings.SetConverterLookupRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}
