﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BestPing.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BestPing.Properties.Resources", typeof(Resources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;games&gt;
        ///	&lt;game name=&quot;World of Warcraft&quot;&gt;
        ///		&lt;region name=&quot;NA&quot;&gt;
        ///			&lt;server name=&quot;US West&quot; ip=&quot;137.221.105.2&quot;/&gt;
        ///			&lt;server name=&quot;US Central&quot; ip=&quot;24.105.62.129&quot;/&gt;
        ///		&lt;/region&gt;
        ///		&lt;region name=&quot;EU&quot;&gt;
        ///			&lt;server name=&quot;Europe 1&quot; ip=&quot;185.60.112.157&quot;/&gt;
        ///			&lt;server name=&quot;Europe 2&quot; ip=&quot;185.60.112.158&quot;/&gt;
        ///			&lt;server name=&quot;Europe 3&quot; ip=&quot;185.60.114.159&quot;/&gt;
        ///		&lt;/region&gt;
        ///	&lt;/game&gt;
        ///	&lt;game name=&quot;Diablo III&quot;&gt;
        ///		&lt;region name=&quot;EU&quot;&gt;
        ///			&lt;server name=&quot;Europe 1&quot; ip=&quot;185.60.112.157&quot;/&gt;
        ///			&lt;server name=&quot;Europe 2&quot; ip=&quot;185.60.112 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string gamesList {
            get {
                return ResourceManager.GetString("gamesList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap GreenDot {
            get {
                object obj = ResourceManager.GetObject("GreenDot", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap OrangeDot {
            get {
                object obj = ResourceManager.GetObject("OrangeDot", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap RedDot {
            get {
                object obj = ResourceManager.GetObject("RedDot", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap YellowDot {
            get {
                object obj = ResourceManager.GetObject("YellowDot", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}
