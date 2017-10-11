﻿#pragma checksum "C:\Users\xkrk\Documents\GitHub\Bartab\Bartab\Bartab\Views\UserContent.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C3E53E10C1EEC3F40C9EC0479BF9AA56"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bartab
{
    partial class UserContent : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Windows_UI_Xaml_FrameworkElement_Name(global::Windows.UI.Xaml.FrameworkElement obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Name = value ?? global::System.String.Empty;
            }
            public static void Set_Windows_UI_Xaml_Controls_ContentControl_Content(global::Windows.UI.Xaml.Controls.ContentControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.Content = value;
            }
        };

        private class UserContent_obj13_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IUserContent_Bindings
        {
            private global::Data.Vare dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Button obj14;

            public UserContent_obj13_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 14:
                        this.obj14 = (global::Windows.UI.Xaml.Controls.Button)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 global::Data.Vare data = args.NewValue as global::Data.Vare;
                 if (args.NewValue != null && data == null)
                 {
                    throw new global::System.ArgumentException("Incorrect type passed into template. Based on the x:DataType global::Data.Vare was expected.");
                 }
                 this.SetDataRoot(data);
                 this.Update();
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                switch(args.Phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(args.Item as global::Data.Vare);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            ((global::Windows.UI.Xaml.Controls.Grid)args.ItemContainer.ContentTemplateRoot).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::Data.Vare) args.Item, 1 << (int)args.Phase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
            }

            // IUserContent_Bindings

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

            // UserContent_obj13_Bindings

            public void SetDataRoot(global::Data.Vare newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Data.Vare obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Id(obj.Id, phase);
                        this.Update_Navn(obj.Navn, phase);
                    }
                }
            }
            private void Update_Id(global::System.Int32 obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_FrameworkElement_Name(this.obj14, obj.ToString(), null);
                }
            }
            private void Update_Navn(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ContentControl_Content(this.obj14, obj, null);
                }
            }
        }

        private class UserContent_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IUserContent_Bindings
        {
            private global::Bartab.UserContent dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.GridView obj7;
            private global::Windows.UI.Xaml.Controls.ListView obj9;
            private global::Windows.UI.Xaml.Controls.ComboBox obj15;

            public UserContent_obj1_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 7:
                        this.obj7 = (global::Windows.UI.Xaml.Controls.GridView)target;
                        break;
                    case 9:
                        this.obj9 = (global::Windows.UI.Xaml.Controls.ListView)target;
                        break;
                    case 15:
                        this.obj15 = (global::Windows.UI.Xaml.Controls.ComboBox)target;
                        break;
                    default:
                        break;
                }
            }

            // IUserContent_Bindings

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

            // UserContent_obj1_Bindings

            public void SetDataRoot(global::Bartab.UserContent newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Bartab.UserContent obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_UCVM(obj.UCVM, phase);
                    }
                }
            }
            private void Update_UCVM(global::ViewModel.UserContentViewModel obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_UCVM_vare(obj.vare, phase);
                        this.Update_UCVM_IndkobListe(obj.IndkobListe, phase);
                        this.Update_UCVM_brugereCombo(obj.brugereCombo, phase);
                    }
                }
            }
            private void Update_UCVM_vare(global::System.Collections.ObjectModel.ObservableCollection<global::Data.Vare> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj7, obj, null);
                }
            }
            private void Update_UCVM_IndkobListe(global::System.Collections.ObjectModel.ObservableCollection<global::Data.OrderItem> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj9, obj, null);
                }
            }
            private void Update_UCVM_brugereCombo(global::System.Collections.ObjectModel.ObservableCollection<global::System.String> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj15, obj, null);
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2:
                {
                    this.Root = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3:
                {
                    this.screenStates = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                }
                break;
            case 4:
                {
                    this.Narrow = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 5:
                {
                    this.Wide = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 6:
                {
                    this.MainGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 7:
                {
                    this.Products = (global::Windows.UI.Xaml.Controls.GridView)(target);
                }
                break;
            case 8:
                {
                    this.Order = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 10:
                {
                    this.Køb = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 79 "..\..\..\Views\UserContent.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Køb).Click += this.Buy;
                    #line default
                }
                break;
            case 11:
                {
                    this.Cancel = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 80 "..\..\..\Views\UserContent.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Cancel).Click += this.Clear;
                    #line default
                }
                break;
            case 12:
                {
                    global::Windows.UI.Xaml.Controls.Button element12 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 73 "..\..\..\Views\UserContent.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element12).Click += this.DeleteItem;
                    #line default
                }
                break;
            case 14:
                {
                    global::Windows.UI.Xaml.Controls.Button element14 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 63 "..\..\..\Views\UserContent.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element14).Click += this.AddItem;
                    #line default
                }
                break;
            case 15:
                {
                    this.Find_bruger = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    #line 52 "..\..\..\Views\UserContent.xaml"
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.Find_bruger).SelectionChanged += this.Find_bruger_SelectionChanged;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    UserContent_obj1_Bindings bindings = new UserContent_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            case 13:
                {
                    global::Windows.UI.Xaml.Controls.Grid element13 = (global::Windows.UI.Xaml.Controls.Grid)target;
                    UserContent_obj13_Bindings bindings = new UserContent_obj13_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot((global::Data.Vare) element13.DataContext);
                    element13.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element13, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

