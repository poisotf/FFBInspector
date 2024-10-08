﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FFBInspector.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("FFBInspector.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Device error.
        /// </summary>
        public static string errCap_devError {
            get {
                return ResourceManager.GetString("errCap_devError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DirectInput error.
        /// </summary>
        public static string errCap_dihError {
            get {
                return ResourceManager.GetString("errCap_dihError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Effect error.
        /// </summary>
        public static string errCap_effError {
            get {
                return ResourceManager.GetString("errCap_effError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;Impossible&quot; error.
        /// </summary>
        public static string errCap_impossible {
            get {
                return ResourceManager.GetString("errCap_impossible", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid data.
        /// </summary>
        public static string errCap_invalData {
            get {
                return ResourceManager.GetString("errCap_invalData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No effect.
        /// </summary>
        public static string errCap_noEffect {
            get {
                return ResourceManager.GetString("errCap_noEffect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot acquire device..
        /// </summary>
        public static string errMsg_dihCantAcquire {
            get {
                return ResourceManager.GetString("errMsg_dihCantAcquire", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot get status of the device..
        /// </summary>
        public static string errMsg_dihGetDevStat {
            get {
                return ResourceManager.GetString("errMsg_dihGetDevStat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Area around the offset at which the effect&apos;s force will be zero.
        ///Range: 0 - 10000
        ///Range of deadband: Offset-Deadband - Offset+Deadband
        ///.
        /// </summary>
        public static string tip_conditionDeadband {
            get {
                return ResourceManager.GetString("tip_conditionDeadband", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Coefficient constant on the negative side of the effect.
        ///Range: -10000 - 10000.
        /// </summary>
        public static string tip_conditionNegCoeff {
            get {
                return ResourceManager.GetString("tip_conditionNegCoeff", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Maximum force on the negative side of the effect.
        ///Range: -10000 - 10000.
        /// </summary>
        public static string tip_conditionNegSat {
            get {
                return ResourceManager.GetString("tip_conditionNegSat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Device&apos;s position relative to its center at which the effect&apos;s force will be zero.
        ///Range -10000 - 10000.
        /// </summary>
        public static string tip_conditionOffset {
            get {
                return ResourceManager.GetString("tip_conditionOffset", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Coefficient constant on the positive side of the effect.
        ///Range: -10000 - 10000.
        /// </summary>
        public static string tip_conditionPosCoeff {
            get {
                return ResourceManager.GetString("tip_conditionPosCoeff", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Maximum force on the positive side of the effect.
        ///Range: -10000 - 10000.
        /// </summary>
        public static string tip_conditionPosSat {
            get {
                return ResourceManager.GetString("tip_conditionPosSat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Strength of the constant force.
        ///Negative values create an inverse force.
        ///Range: -10000 - 10000.
        /// </summary>
        public static string tip_constantMagnitude {
            get {
                return ResourceManager.GetString("tip_constantMagnitude", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Direction of the effect expressed in cartesian coordinates (where applicable)..
        /// </summary>
        public static string tip_directions {
            get {
                return ResourceManager.GetString("tip_directions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Envelope is a set of conditions that adjust effect&apos;s
        ///magnitude at the beginning and the end of playback.
        ///
        ///When an envelope is applied, effect&apos;s magnitude changes
        ///gradually from a start value to target value when the playback
        ///starts and then fades to a final level at the end of the playback..
        /// </summary>
        public static string tip_envelope {
            get {
                return ResourceManager.GetString("tip_envelope", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Magnitude at the beggining of playback.
        ///Range: 0 - 10000.
        /// </summary>
        public static string tip_envelopeAttackLevel {
            get {
                return ResourceManager.GetString("tip_envelopeAttackLevel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to How long should the magnitude be changing to the target one (in microseconds)..
        /// </summary>
        public static string tip_envelopeAttackTime {
            get {
                return ResourceManager.GetString("tip_envelopeAttackTime", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Magnitude at the end of the playback.
        ///Range: 0 - 10000.
        /// </summary>
        public static string tip_envelopeFadeLevel {
            get {
                return ResourceManager.GetString("tip_envelopeFadeLevel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to How long should the magnitude be fading to the final one (in microseconds)..
        /// </summary>
        public static string tip_envelopeFadeTime {
            get {
                return ResourceManager.GetString("tip_envelopeFadeTime", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Delay before the effect starts playing (in microseconds).
        ///0 = Start immediately.
        /// </summary>
        public static string tip_generalDelay {
            get {
                return ResourceManager.GetString("tip_generalDelay", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to How long the effect should play (in microseconds).
        ///-1 = Infinite.
        /// </summary>
        public static string tip_generalDuration {
            get {
                return ResourceManager.GetString("tip_generalDuration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Overall strength of the effect.
        ///Range: 0 - 10000.
        /// </summary>
        public static string tip_generalGain {
            get {
                return ResourceManager.GetString("tip_generalGain", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Start playback when a button is pressed.
        ///Number corresponds to the button number reported by the device.
        ///-1 = No trigger.
        /// </summary>
        public static string tip_generalTrig {
            get {
                return ResourceManager.GetString("tip_generalTrig", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Delay between the end of one playback and start of another one (in microseconds).
        ///Applicable only if the effect is triggered by button.
        ///0 = No delay.
        /// </summary>
        public static string tip_generalTrigRep {
            get {
                return ResourceManager.GetString("tip_generalTrigRep", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Maximum strength of the effect.
        ///Range: 0 - 10000.
        /// </summary>
        public static string tip_periodicMagnitude {
            get {
                return ResourceManager.GetString("tip_periodicMagnitude", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ranges of forces generated by the effect.
        ///Generated ranges: Offset-Magnitude - Offset+Magnitude.
        /// </summary>
        public static string tip_periodicOffset {
            get {
                return ResourceManager.GetString("tip_periodicOffset", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to How long will one cycle of the effect last (in microseconds)..
        /// </summary>
        public static string tip_periodicPeriod {
            get {
                return ResourceManager.GetString("tip_periodicPeriod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Position in the cycle at which the playback will start.
        ///Range: 0 - 35999.
        /// </summary>
        public static string tip_periodicPhase {
            get {
                return ResourceManager.GetString("tip_periodicPhase", resourceCulture);
            }
        }
    }
}
