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
    public partial class UserDefinedTableTypeRtt : Zahar.SqlClient.Codegen.RuntimeTextTemplate
    {
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
  
	string utilsClassName = typeof(SqlCmdBuilder).Name;
	string dataTableClassName = GetUserDefinedDataTableClassName(Schema.TableName);
	string dataRowClassName = GetUserDefinedDataRowClassName(Schema.TableName);
	var columns = Schema.Columns.OfType<DataColumn>().ToList();
	var primaryKey = Schema.PrimaryKey ?? new DataColumn[0];
	var uniqueConstraints = Schema.Constraints.OfType<UniqueConstraint>().ToList();

            this.Write("\r\n/// <summary>\r\n/// ");
            this.Write(this.ToStringHelper.ToStringWithCulture(Schema.TableName));
            this.Write(" user defined tabletype.\r\n/// </summary>\t\r\n[global::System.Serializable()]\r\npubli" +
                    "c partial class ");
            this.Write(this.ToStringHelper.ToStringWithCulture(dataTableClassName));
            this.Write(" : global::System.Data.TypedTableBase<");
            this.Write(this.ToStringHelper.ToStringWithCulture(dataRowClassName));
            this.Write(">\r\n{\r\n\t[");
            this.Write(this.ToStringHelper.ToStringWithCulture(DebuggerNonUserCodeAttribute));
            this.Write("]\r\n\t[");
            this.Write(this.ToStringHelper.ToStringWithCulture(GeneratedCodeAttribute));
            this.Write("]\r\n\tpublic ");
            this.Write(this.ToStringHelper.ToStringWithCulture(dataTableClassName));
            this.Write("()\r\n\t{\r\n\t\tthis.TableName = @\"");
            this.Write(this.ToStringHelper.ToStringWithCulture(Schema.TableName));
            this.Write("\";\r\n\t\tthis.BeginInit();\r\n\t\tthis.InitClass();\r\n\t\tthis.EndInit();\r\n\t}\r\n\r\n\t[");
            this.Write(this.ToStringHelper.ToStringWithCulture(DebuggerNonUserCodeAttribute));
            this.Write("]\r\n\t[");
            this.Write(this.ToStringHelper.ToStringWithCulture(GeneratedCodeAttribute));
            this.Write("]\r\n\tprotected ");
            this.Write(this.ToStringHelper.ToStringWithCulture(dataTableClassName));
            this.Write(@"(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
			base(info, context) 
	{
		
	}

	public void AddRows<T>(
		System.Collections.Generic.IEnumerable<T> entities, 
		System.Action<T, ");
            this.Write(this.ToStringHelper.ToStringWithCulture(dataRowClassName));
            this.Write("> initializeRow)\r\n\t{\r\n\t\tforeach(var entity in entities)\r\n\t\t{\r\n\t\t\tvar row = this.N" +
                    "ewRow();\r\n\t\t\tinitializeRow(entity, row);\r\n\t\t\tthis.Rows.Add(row);\r\n\t\t}\r\n\t}\r\n\r\n\t[");
            this.Write(this.ToStringHelper.ToStringWithCulture(DebuggerNonUserCodeAttribute));
            this.Write("]\r\n\t[");
            this.Write(this.ToStringHelper.ToStringWithCulture(GeneratedCodeAttribute));
            this.Write("]\r\n\tpublic new ");
            this.Write(this.ToStringHelper.ToStringWithCulture(dataRowClassName));
            this.Write(" NewRow() { return ((");
            this.Write(this.ToStringHelper.ToStringWithCulture(dataRowClassName));
            this.Write(")(base.NewRow())); }\r\n\t\t\t\r\n\t[");
            this.Write(this.ToStringHelper.ToStringWithCulture(DebuggerNonUserCodeAttribute));
            this.Write("]\r\n\t[");
            this.Write(this.ToStringHelper.ToStringWithCulture(GeneratedCodeAttribute));
            this.Write("]\r\n\tprotected override global::System.Data.DataRow NewRowFromBuilder(global::Syst" +
                    "em.Data.DataRowBuilder builder) { return new ");
            this.Write(this.ToStringHelper.ToStringWithCulture(dataRowClassName));
            this.Write("(builder); }\r\n\t\t\t\r\n\t[");
            this.Write(this.ToStringHelper.ToStringWithCulture(DebuggerNonUserCodeAttribute));
            this.Write("]\r\n\t[");
            this.Write(this.ToStringHelper.ToStringWithCulture(GeneratedCodeAttribute));
            this.Write("]\r\n\tprotected override global::System.Type GetRowType() { return typeof(");
            this.Write(this.ToStringHelper.ToStringWithCulture(dataRowClassName));
            this.Write("); }\r\n\r\n\tpublic static global::System.Data.DataColumn[] CreateColumnsArray()\r\n\t{\r" +
                    "\n\t\tvar columns = new global::System.Data.DataColumn[]{");
 foreach(DataColumn column in Schema.Columns){ 
            this.Write(" \r\n\t\t\tnew global::System.Data.DataColumn(\"");
            this.Write(this.ToStringHelper.ToStringWithCulture(column.ColumnName));
            this.Write("\", typeof(");
            this.Write(this.ToStringHelper.ToStringWithCulture(column.DataType));
            this.Write("), null, global::System.Data.MappingType.Element), ");
 } 
            this.Write(" \r\n\t\t};\r\n\t\t");
 foreach(var column in columns.Where(c=> !c.AllowDBNull)){ 
            this.Write(" \r\n\t\tcolumns[");
            this.Write(this.ToStringHelper.ToStringWithCulture(column.Ordinal));
            this.Write("].AllowDBNull = false; // ");
            this.Write(this.ToStringHelper.ToStringWithCulture(column.ColumnName));
            this.Write(" ");
 } 
            this.Write(" ");
 foreach(var column in columns.Where(c=> c.MaxLength > 0)){ 
            this.Write(" \r\n\t\tcolumns[");
            this.Write(this.ToStringHelper.ToStringWithCulture(column.Ordinal));
            this.Write("].MaxLength = ");
            this.Write(this.ToStringHelper.ToStringWithCulture(column.MaxLength));
            this.Write("; // ");
            this.Write(this.ToStringHelper.ToStringWithCulture(column.ColumnName));
            this.Write(" ");
 } 
            this.Write("  ");
 foreach(var column in columns.Where(c=> c.AutoIncrement)){ 
            this.Write(" \r\n\t\tcolumns[");
            this.Write(this.ToStringHelper.ToStringWithCulture(column.Ordinal));
            this.Write("].AutoIncrement = true; // ");
            this.Write(this.ToStringHelper.ToStringWithCulture(column.ColumnName));
            this.Write(" \r\n\t\tcolumns[");
            this.Write(this.ToStringHelper.ToStringWithCulture(column.Ordinal));
            this.Write("].AutoIncrementSeed = ");
            this.Write(this.ToStringHelper.ToStringWithCulture(column.AutoIncrementSeed));
            this.Write("; // ");
            this.Write(this.ToStringHelper.ToStringWithCulture(column.ColumnName));
            this.Write(" \r\n\t\tcolumns[");
            this.Write(this.ToStringHelper.ToStringWithCulture(column.Ordinal));
            this.Write("].AutoIncrementStep = ");
            this.Write(this.ToStringHelper.ToStringWithCulture(column.AutoIncrementStep));
            this.Write("; // ");
            this.Write(this.ToStringHelper.ToStringWithCulture(column.ColumnName));
            this.Write(" ");
 } 
            this.Write("  ");
 foreach(var column in columns.Where(c=> c.ReadOnly)){ 
            this.Write(" \r\n\t\tcolumns[");
            this.Write(this.ToStringHelper.ToStringWithCulture(column.Ordinal));
            this.Write("].ReadOnly = true; // ");
            this.Write(this.ToStringHelper.ToStringWithCulture(column.ColumnName));
            this.Write(" ");
 } 
            this.Write("  ");
 foreach(var column in columns.Where(c=> c.Unique)){ 
            this.Write(" \r\n\t\tcolumns[");
            this.Write(this.ToStringHelper.ToStringWithCulture(column.Ordinal));
            this.Write("].Unique = true; // ");
            this.Write(this.ToStringHelper.ToStringWithCulture(column.ColumnName));
            this.Write(" ");
 } 
            this.Write("  ");
 foreach(var column in columns.Where(c=> c.DataType.IsValueType && c.AllowDBNull == false && !c.AutoIncrement)){ 
            this.Write(" \r\n\t\tcolumns[");
            this.Write(this.ToStringHelper.ToStringWithCulture(column.Ordinal));
            this.Write("].DefaultValue = default(");
            this.Write(this.ToStringHelper.ToStringWithCulture(GetPropertyTypeName(column.DataType, false)));
            this.Write("); // ");
            this.Write(this.ToStringHelper.ToStringWithCulture(column.ColumnName));
            this.Write(" ");
 } 
            this.Write("  \r\n\r\n\t\treturn columns;\r\n\t}\r\n\r\n\tprivate void InitClass()\r\n\t{\r\n\t\tvar columns = ");
            this.Write(this.ToStringHelper.ToStringWithCulture(dataTableClassName));
            this.Write(".CreateColumnsArray();\r\n\t\tforeach (var column in columns) { this.Columns.Add(colu" +
                    "mn); } \r\n\t\tthis.Constraints.Clear(); ");
 foreach(var dc in uniqueConstraints){ int indx = uniqueConstraints.IndexOf(dc); 
            this.Write(" \r\n\t\tthis.Constraints.Add(new global::System.Data.UniqueConstraint(\"");
            this.Write(this.ToStringHelper.ToStringWithCulture("UniqueConstraint_" + indx.ToString()));
            this.Write("\", \r\n\t\t\t new global::System.Data.DataColumn[]\r\n\t\t\t {");
 foreach(DataColumn c in dc.Columns){ 
            this.Write(" \r\n\t\t\t\tthis.Columns[");
            this.Write(this.ToStringHelper.ToStringWithCulture(c.Ordinal));
            this.Write("], // ");
            this.Write(this.ToStringHelper.ToStringWithCulture(c.ColumnName));
            this.Write(" ");
 } 
            this.Write(" \r\n\t\t\t }, isPrimaryKey: ");
            this.Write(this.ToStringHelper.ToStringWithCulture(dc.IsPrimaryKey.ToString().ToLower()));
            this.Write("));\r\n\t\t");
 } 
            this.Write(" ");
 if(primaryKey.Length > 0){ 
            this.Write(" \r\n\t\tthis.PrimaryKey = new []{ ");
 for(int i = 0; i < primaryKey.Length; ++i)Write("this.Columns[{0}]", primaryKey[i].Ordinal); 
            this.Write(" }; ");
 } 
            this.Write(" \r\n\t}\r\n}\r\n\r\n/// <summary>\r\n/// ");
            this.Write(this.ToStringHelper.ToStringWithCulture(Schema.TableName));
            this.Write(" data row\r\n/// </summary>\t\t\r\npublic partial class ");
            this.Write(this.ToStringHelper.ToStringWithCulture(dataRowClassName));
            this.Write(" : global::System.Data.DataRow\r\n{\t\r\n\t[");
            this.Write(this.ToStringHelper.ToStringWithCulture(DebuggerNonUserCodeAttribute));
            this.Write("]\r\n\t[");
            this.Write(this.ToStringHelper.ToStringWithCulture(GeneratedCodeAttribute));
            this.Write("]\r\n\tinternal ");
            this.Write(this.ToStringHelper.ToStringWithCulture(dataRowClassName));
            this.Write("(global::System.Data.DataRowBuilder rb) : base(rb) \r\n\t{\r\n\t}\r\n\r\n\t[");
            this.Write(this.ToStringHelper.ToStringWithCulture(DebuggerNonUserCodeAttribute));
            this.Write("]\r\n\t[");
            this.Write(this.ToStringHelper.ToStringWithCulture(GeneratedCodeAttribute));
            this.Write("]\r\n\tpublic new ");
            this.Write(this.ToStringHelper.ToStringWithCulture(dataTableClassName));
            this.Write(" Table => (");
            this.Write(this.ToStringHelper.ToStringWithCulture(dataTableClassName));
            this.Write(")base.Table;\r\n\r\n\t");
 for(int i = 0; i < Schema.Columns.Count; ++i){ 
		DataColumn column = Schema.Columns[i];
		string propertyName = GetPropertyName( column.ColumnName );
		string propertyType = GetPropertyTypeName( column.DataType, column.AllowDBNull );

	
            this.Write(" \r\n\t/// <summary>\r\n    /// Gets or sets the \"");
            this.Write(this.ToStringHelper.ToStringWithCulture(column.ColumnName));
            this.Write("\" value.\r\n    /// </summary>\r\n\t[");
            this.Write(this.ToStringHelper.ToStringWithCulture(DebuggerNonUserCodeAttribute));
            this.Write("]\r\n\t[");
            this.Write(this.ToStringHelper.ToStringWithCulture(GeneratedCodeAttribute));
            this.Write("]");
 if(Schema.PrimaryKey.Contains(column)){ 
            this.Write(" \r\n\t[global::System.ComponentModel.DataAnnotations.Key()] ");
 } 
            this.Write(" \r\n\t[global::System.ComponentModel.DataAnnotations.Schema.Column(\"");
            this.Write(this.ToStringHelper.ToStringWithCulture(column.ColumnName));
            this.Write("\", Order = ");
            this.Write(this.ToStringHelper.ToStringWithCulture(column.Ordinal));
            this.Write(")]\r\n\tpublic ");
            this.Write(this.ToStringHelper.ToStringWithCulture(propertyType));
            this.Write(" ");
            this.Write(this.ToStringHelper.ToStringWithCulture(propertyName));
            this.Write("\r\n\t{\r\n\t\tget { return ");
            this.Write(this.ToStringHelper.ToStringWithCulture(utilsClassName));
            this.Write(".ToClrValue<");
            this.Write(this.ToStringHelper.ToStringWithCulture(propertyType));
            this.Write(">(this[");
            this.Write(this.ToStringHelper.ToStringWithCulture(i));
            this.Write("]); }\r\n\t\tset { this[");
            this.Write(this.ToStringHelper.ToStringWithCulture(i));
            this.Write("] = ");
            this.Write(this.ToStringHelper.ToStringWithCulture(utilsClassName));
            this.Write(".ToSqlValue(value); }\r\n\t}\r\n\t");
 } 
            this.Write(" \r\n}\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
}
