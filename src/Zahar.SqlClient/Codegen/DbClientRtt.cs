﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Zahar.SqlClient.Codegen
{
    using System.Data;
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class DbClientRtt : Zahar.SqlClient.Codegen.RuntimeTextTemplate
    {
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("\r\n/// <summary>\r\n/// \r\n/// </summary>\r\npublic sealed class ");
            this.Write(this.ToStringHelper.ToStringWithCulture(SqlDbClientClassName));
            this.Write(" : ");
            this.Write(this.ToStringHelper.ToStringWithCulture(typeof(SqlDbClient).Name));
            this.Write("\r\n{\r\n\t/// <summary>\r\n    /// \r\n    /// </summary>\r\n\tpublic ");
            this.Write(this.ToStringHelper.ToStringWithCulture(SqlDbClientClassName));
            this.Write("(string connectionString)\r\n\t\t: base(connectionString)\r\n\t{\r\n\t\t\r\n\t}");
 foreach(var spFullName in SpFullNames){ string factoryClass = GetStoredProcedureComponentFactoryClassName(spFullName); 
            this.Write(" \r\n\r\n\t/// <summary>\r\n    /// Creates a new instance of the ");
            this.Write(this.ToStringHelper.ToStringWithCulture(spFullName));
            this.Write(" components factory.\r\n    /// </summary>\r\n\t[");
            this.Write(this.ToStringHelper.ToStringWithCulture(DebuggerNonUserCodeAttribute));
            this.Write("]\r\n\t[");
            this.Write(this.ToStringHelper.ToStringWithCulture(GeneratedCodeAttribute));
            this.Write("]\r\n\tpublic ");
            this.Write(this.ToStringHelper.ToStringWithCulture(factoryClass));
            this.Write(" Create");
            this.Write(this.ToStringHelper.ToStringWithCulture(factoryClass));
            this.Write("() { return new ");
            this.Write(this.ToStringHelper.ToStringWithCulture(factoryClass));
            this.Write("(); } ");
 } 
            this.Write(" \r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
}