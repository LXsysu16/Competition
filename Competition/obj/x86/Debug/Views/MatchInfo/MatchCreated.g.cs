﻿#pragma checksum "D:\coursewave\ModernOSAppDevlop\VS_Projects\Competition\Competition\Views\MatchInfo\MatchCreated.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "97E547AE01D47FE3FBF1FD910444EE31"
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
    partial class MatchCreated : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1: // Views\MatchInfo\MatchCreated.xaml line 67
                {
                    this.DeleteMatch = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.DeleteMatch).Click += this.DeleteMatch_Click;
                }
                break;
            case 2: // Views\MatchInfo\MatchCreated.xaml line 16
                {
                    this.Title = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3: // Views\MatchInfo\MatchCreated.xaml line 27
                {
                    this.TennisAddition = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 4: // Views\MatchInfo\MatchCreated.xaml line 44
                {
                    this.CreateBattles = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.CreateBattles).Click += this.CreateBattles_Click;
                }
                break;
            case 5: // Views\MatchInfo\MatchCreated.xaml line 54
                {
                    this.ExportExcel = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.ExportExcel).Click += this.ClearTextBox_Click;
                }
                break;
            case 6: // Views\MatchInfo\MatchCreated.xaml line 40
                {
                    this.SeedNumber = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7: // Views\MatchInfo\MatchCreated.xaml line 29
                {
                    this.Addition1 = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8: // Views\MatchInfo\MatchCreated.xaml line 31
                {
                    this.Addition2 = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 9: // Views\MatchInfo\MatchCreated.xaml line 33
                {
                    this.Addition3 = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 10: // Views\MatchInfo\MatchCreated.xaml line 35
                {
                    this.Addition4 = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 11: // Views\MatchInfo\MatchCreated.xaml line 20
                {
                    this.MatchSystem = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
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
            return returnValue;
        }
    }
}

