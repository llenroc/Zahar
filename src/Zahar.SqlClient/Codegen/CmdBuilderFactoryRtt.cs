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
    public partial class CmdBuilderFactoryRtt : Zahar.SqlClient.Codegen.RuntimeTextTemplate
    {
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("\r\n/// <summary>\r\n/// SQL command builder factory. Use istances of this class to c" +
                    "onstruct stored procedure command builder objects.\r\n/// </summary>\r\npublic seale" +
                    "d partial class ");
            this.Write(this.ToStringHelper.ToStringWithCulture(SqlCmdBuilderFactoryClassName));
            this.Write(" : ");
            this.Write(this.ToStringHelper.ToStringWithCulture(typeof(SqlCmdBuilderFactory).Name));
            this.Write("\r\n{\r\n\t#region Ctor\r\n\r\n\tpartial void OnCreated();\r\n\r\n\t/// <summary>\r\n    /// Initi" +
                    "alizes a new instance of the <see cref=\"");
            this.Write(this.ToStringHelper.ToStringWithCulture(SqlCmdBuilderFactoryClassName));
            this.Write("\"/> class.\r\n    /// </summary>\r\n    /// <param name=\"connectionString\">SQL Server" +
                    " database connection string.</param>\r\n\t/// <exception cref=\"global::System.Argum" +
                    "entNullException\">connectionString</exception>\r\n\t[");
            this.Write(this.ToStringHelper.ToStringWithCulture(DebuggerNonUserCodeAttribute));
            this.Write("]\r\n\t[");
            this.Write(this.ToStringHelper.ToStringWithCulture(GeneratedCodeAttribute));
            this.Write("]\r\n\tpublic ");
            this.Write(this.ToStringHelper.ToStringWithCulture(SqlCmdBuilderFactoryClassName));
            this.Write("(string connectionString) : base(connectionString) { OnCreated(); }\r\n\r\n\t/// <summ" +
                    "ary>\r\n    /// Initializes a new instance of the <see cref=\"");
            this.Write(this.ToStringHelper.ToStringWithCulture(SqlCmdBuilderFactoryClassName));
            this.Write("\"/> class.\r\n\t/// Implies the SQL Server context connection.\r\n    /// </summary>\r\n" +
                    "\t[");
            this.Write(this.ToStringHelper.ToStringWithCulture(DebuggerNonUserCodeAttribute));
            this.Write("]\r\n\t[");
            this.Write(this.ToStringHelper.ToStringWithCulture(GeneratedCodeAttribute));
            this.Write("]\r\n\tpublic ");
            this.Write(this.ToStringHelper.ToStringWithCulture(SqlCmdBuilderFactoryClassName));
            this.Write("() : base() { OnCreated(); }\r\n\r\n\t/// <summary>\r\n    /// Initializes a new instanc" +
                    "e of the <see cref=\"");
            this.Write(this.ToStringHelper.ToStringWithCulture(SqlCmdBuilderFactoryClassName));
            this.Write("\"/> class.\r\n    /// </summary>\r\n    /// <param name=\"connectionStringFactory\">SQL" +
                    " Server database connection string factory.</param>\r\n\t/// <exception cref=\"Syste" +
                    "m.ArgumentNullException\">connectionStringFactory</exception>\r\n\t[");
            this.Write(this.ToStringHelper.ToStringWithCulture(DebuggerNonUserCodeAttribute));
            this.Write("]\r\n\t[");
            this.Write(this.ToStringHelper.ToStringWithCulture(GeneratedCodeAttribute));
            this.Write("]\r\n\tpublic ");
            this.Write(this.ToStringHelper.ToStringWithCulture(SqlCmdBuilderFactoryClassName));
            this.Write("(System.Func<string> connectionStringFactory) : base(connectionStringFactory) { O" +
                    "nCreated(); }\r\n\r\n\t/// <summary>\r\n    /// Initializes a new instance of the <see " +
                    "cref=\"");
            this.Write(this.ToStringHelper.ToStringWithCulture(SqlCmdBuilderFactoryClassName));
            this.Write("\"/> class.\r\n    /// </summary>\r\n    /// <param name=\"connectionFactory\">SQL Serve" +
                    "r database connection string factory.</param>\r\n    /// <exception cref=\"System.A" +
                    "rgumentNullException\">connectionFactory</exception>\r\n\t[");
            this.Write(this.ToStringHelper.ToStringWithCulture(DebuggerNonUserCodeAttribute));
            this.Write("]\r\n\t[");
            this.Write(this.ToStringHelper.ToStringWithCulture(GeneratedCodeAttribute));
            this.Write("]\r\n\tpublic ");
            this.Write(this.ToStringHelper.ToStringWithCulture(SqlCmdBuilderFactoryClassName));
            this.Write("(System.Func<System.Data.SqlClient.SqlConnection> connectionFactory) : base(conne" +
                    "ctionFactory) { OnCreated(); }\r\n\t#endregion ");
 foreach(var procedure in Procedures){ 
	string spFullName = procedure.FullName;
	string factoryClass = GetStoredProcedureCmdBuilderClassName(spFullName);
	var parameters = procedure.Parameters.ToList();
	var inputParameters = parameters.Where(p=> p.Direction == ParameterDirection.Input || p.Direction == ParameterDirection.InputOutput).ToList();
	var tableInputParameters = inputParameters.Where(p=> p.TableTypeSchema != null);
	var ixPropertyTypeNamesByParameter = new Dictionary<object, string>();
	foreach(var p in parameters)
	{
		ixPropertyTypeNamesByParameter[p] = GetPropertyTypeName(p.DataType, true);
	}
	foreach(var p in tableInputParameters)
	{
		var schema = p.TableTypeSchema;
		var dataTypeName = GetUserDefinedDataTableClassName(schema.TableName);
		ixPropertyTypeNamesByParameter[p] = dataTypeName;
	}
	string paramsDeclaration = string.Join(", ",
		from p in inputParameters
		let type = ixPropertyTypeNamesByParameter[p]
		let name = GetParameterName(p.ParameterName)
		select string.Format("{0} {1}", type, name));
	 
            this.Write(" \r\n\r\n\t/// <summary>\r\n    /// Creates a new instance of the ");
            this.Write(this.ToStringHelper.ToStringWithCulture(spFullName));
            this.Write(" command builder.\r\n    /// </summary>\r\n\t[");
            this.Write(this.ToStringHelper.ToStringWithCulture(DebuggerNonUserCodeAttribute));
            this.Write("]\r\n\t[");
            this.Write(this.ToStringHelper.ToStringWithCulture(GeneratedCodeAttribute));
            this.Write("]\r\n\tpublic ");
            this.Write(this.ToStringHelper.ToStringWithCulture(factoryClass));
            this.Write(" Create");
            this.Write(this.ToStringHelper.ToStringWithCulture(factoryClass));
            this.Write("() { return new ");
            this.Write(this.ToStringHelper.ToStringWithCulture(factoryClass));
            this.Write("(); } \r\n\r\n\t");
 if(inputParameters.Any()){ 
            this.Write("\r\n\t/// <summary>\r\n    /// Creates a new instance of the ");
            this.Write(this.ToStringHelper.ToStringWithCulture(spFullName));
            this.Write(" command builder.\r\n    /// </summary>");
 foreach(var p in inputParameters){ 
            this.Write(" \r\n\t/// <param name=\"");
            this.Write(this.ToStringHelper.ToStringWithCulture(GetParameterName(p.ParameterName)));
            this.Write("\">Parameter ");
            this.Write(this.ToStringHelper.ToStringWithCulture(parameters.IndexOf(p)));
            this.Write(" (");
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Direction));
            this.Write(")</param> ");
 } 
            this.Write(" \r\n\t[");
            this.Write(this.ToStringHelper.ToStringWithCulture(DebuggerNonUserCodeAttribute));
            this.Write("]\r\n\t[");
            this.Write(this.ToStringHelper.ToStringWithCulture(GeneratedCodeAttribute));
            this.Write("]\r\n\tpublic ");
            this.Write(this.ToStringHelper.ToStringWithCulture(factoryClass));
            this.Write(" Create");
            this.Write(this.ToStringHelper.ToStringWithCulture(factoryClass));
            this.Write("(");
            this.Write(this.ToStringHelper.ToStringWithCulture(paramsDeclaration));
            this.Write(") \r\n\t{ \r\n\t\treturn new ");
            this.Write(this.ToStringHelper.ToStringWithCulture(factoryClass));
            this.Write("()\r\n\t\t{");
 foreach(var p in inputParameters){ 
            this.Write(" \r\n\t\t\t");
            this.Write(this.ToStringHelper.ToStringWithCulture(GetPropertyName(p.ParameterName)));
            this.Write(" = ");
            this.Write(this.ToStringHelper.ToStringWithCulture(GetParameterName(p.ParameterName)));
            this.Write(", ");
 } 
            this.Write(" \t\t\t\r\n\t\t}; \r\n\t} \r\n\r\n\t");
 } 
            this.Write("\t\r\n\t");
 } /* foreach(var procedure in Procedures) */ 
            this.Write(" \r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
}
