﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HomeAccounting.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Tahoma, 8.25pt")]
        public global::System.Drawing.Font GeneralFont {
            get {
                return ((global::System.Drawing.Font)(this["GeneralFont"]));
            }
            set {
                this["GeneralFont"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("data source=D:\\Development\\cSharp\\HomeAccounting\\accounting.sqlite")]
        public string AccountingConnectionString {
            get {
                return ((string)(this["AccountingConnectionString"]));
            }
            set
            {
                this["AccountingConnectionString"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool RecordDetailsWarningShown {
            get {
                return ((bool)(this["RecordDetailsWarningShown"]));
            }
            set {
                this["RecordDetailsWarningShown"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ShowRecordDetails {
            get {
                return ((bool)(this["ShowRecordDetails"]));
            }
            set {
                this["ShowRecordDetails"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0, 0")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public global::System.Drawing.Point FormLocation {
            get {
                return ((global::System.Drawing.Point)(this["FormLocation"]));
            }
            set {
                this["FormLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("640, 480")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public global::System.Drawing.Size FormSize {
            get {
                return ((global::System.Drawing.Size)(this["FormSize"]));
            }
            set {
                this["FormSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("192, 255, 192")]
        public global::System.Drawing.Color PositiveTotalRowColor {
            get {
                return ((global::System.Drawing.Color)(this["PositiveTotalRowColor"]));
            }
            set {
                this["PositiveTotalRowColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("255, 192, 192")]
        public global::System.Drawing.Color NegativeTotalRowColor {
            get {
                return ((global::System.Drawing.Color)(this["NegativeTotalRowColor"]));
            }
            set {
                this["NegativeTotalRowColor"] = value;
            }
        }
    }
}
