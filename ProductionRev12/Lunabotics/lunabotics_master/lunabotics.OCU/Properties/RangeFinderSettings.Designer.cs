﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lunabotics.OCU.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class RangeFinderSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static RangeFinderSettings defaultInstance = ((RangeFinderSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new RangeFinderSettings())));
        
        public static RangeFinderSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("135")]
        public int FrontStartAngle {
            get {
                return ((int)(this["FrontStartAngle"]));
            }
            set {
                this["FrontStartAngle"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-4.25")]
        public double FrontStepAngle {
            get {
                return ((double)(this["FrontStepAngle"]));
            }
            set {
                this["FrontStepAngle"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("135")]
        public int RearStartAngle {
            get {
                return ((int)(this["RearStartAngle"]));
            }
            set {
                this["RearStartAngle"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-4.25")]
        public double RearStepAngle {
            get {
                return ((double)(this["RearStepAngle"]));
            }
            set {
                this["RearStepAngle"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("20")]
        public int FrontDataLength {
            get {
                return ((int)(this["FrontDataLength"]));
            }
            set {
                this["FrontDataLength"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("20")]
        public int RearDataLength {
            get {
                return ((int)(this["RearDataLength"]));
            }
            set {
                this["RearDataLength"] = value;
            }
        }
    }
}
