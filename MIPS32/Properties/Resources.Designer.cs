﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MIPS32.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MIPS32.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to add R 0 20
        ///addi I 8 null
        ///addiu I 9 null
        ///addu R 0 21
        ///sub R 0 22
        ///subu R 0 23
        ///and R 0 24
        ///andi I c null
        ///nor R 0 27
        ///or R 0 25
        ///ori I d null
        ///xor R 0 26
        ///xori I e null
        ///sll R 0 00
        ///srl R 0 02
        ///sra R 0 03
        ///sllv R 0 04
        ///srlv R 0 06
        ///srav R‬ 0 07
        ///slt R 0 2a
        ///slti I a null
        ///sltiu I b null
        ///sltu R 0 2b
        ///beq I 4 null
        ///bne I 5 null
        ///j J 2 null
        ///jal J 3 null
        ///jr R 0 08
        ///jalr R 0 09
        ///lb I 20 null
        ///lbu I 24 null
        ///lh I 25 null
        ///lhu I 25 null
        ///lui I f null
        ///lw I 23 null
        ///sb I 28 null
        ///sh I 29 null
        ///sw I 2b null
        ///di [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string instructions {
            get {
                return ResourceManager.GetString("instructions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to $zero 0
        ///$at 1
        ///$v0 2
        ///$v1 3
        ///$a0 4
        ///$a1 5
        ///$a2 6
        ///$a3 7
        ///$t0 8
        ///$t1 9
        ///$t2 10
        ///$t3 11
        ///$t4 12
        ///$t5 13
        ///$t6 14
        ///$t7 15
        ///$s0 16
        ///$s1 17
        ///$s2 18
        ///$s3 19
        ///$s4 20
        ///$s5 21
        ///$s6 22
        ///$s7 23
        ///$t8 24
        ///$t9 25
        ///$k0 25
        ///$k1 26
        ///$gp 28
        ///$sp 29
        ///$fp 30
        ///$ra 31
        ///noregister 0.
        /// </summary>
        internal static string registers {
            get {
                return ResourceManager.GetString("registers", resourceCulture);
            }
        }
    }
}
