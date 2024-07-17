﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 17.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace EADotnetAngularCli.Templates.Client
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using CaseExtensions;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\David\source\repos\EA-dotnet-webapi\EADotnetWebapiCli\Templates\Client\EditComponent.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class EditComponent : EditComponentBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write(@"import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatDialogModule, MatDialogRef } from '@angular/material/dialog';
import { MatFormFieldModule } from '@angular/material/form-field';
import {MatInputModule} from '@angular/material/input';
import {MatGridListModule} from '@angular/material/grid-list';
import {FormGroup, FormControl} from '@angular/forms';
import {Component, Inject, OnInit} from '@angular/core';
import {MAT_DIALOG_DATA} from '@angular/material/dialog';
import { Api, ");
            
            #line 16 "C:\Users\David\source\repos\EA-dotnet-webapi\EADotnetWebapiCli\Templates\Client\EditComponent.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write(@" } from '../../api';
import {MatSlideToggleModule} from '@angular/material/slide-toggle';
@Component({
  selector: 'app-new-page-edit',
  standalone: true,
  imports: [MatButtonModule, MatDialogModule,FormsModule, MatFormFieldModule, MatInputModule, MatGridListModule, ReactiveFormsModule, MatSlideToggleModule],
  templateUrl: './");
            
            #line 22 "C:\Users\David\source\repos\EA-dotnet-webapi\EADotnetWebapiCli\Templates\Client\EditComponent.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name.ToKebabCase()));
            
            #line default
            #line hidden
            this.Write("-edit.component.html\',\r\n  styleUrl: \'./");
            
            #line 23 "C:\Users\David\source\repos\EA-dotnet-webapi\EADotnetWebapiCli\Templates\Client\EditComponent.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name.ToKebabCase()));
            
            #line default
            #line hidden
            this.Write("-edit.component.scss\'\r\n})\r\nexport class ");
            
            #line 25 "C:\Users\David\source\repos\EA-dotnet-webapi\EADotnetWebapiCli\Templates\Client\EditComponent.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("EditComponent implements OnInit{\r\n\r\n  errors: any[] = [];\r\n\r\n  editForm = new For" +
                    "mGroup({\r\n");
            
            #line 30 "C:\Users\David\source\repos\EA-dotnet-webapi\EADotnetWebapiCli\Templates\Client\EditComponent.tt"
 

var defaultValues = new Dictionary<string, string>(){
  {"EAC__int", "0"},
  {"EAC__String", "\"\""},
  {"EAC__Decimal", "0"},
  {"DateTime", "Date.now()"},
  {"EAC__Boolean", "false"}
};

foreach (var attr in Model.Attributes) { 
            
            #line default
            #line hidden
            this.Write("    ");
            
            #line 41 "C:\Users\David\source\repos\EA-dotnet-webapi\EADotnetWebapiCli\Templates\Client\EditComponent.tt"
 if(defaultValues.ContainsKey(attr.Type.Name)) { 
            
            #line default
            #line hidden
            this.Write("        ");
            
            #line 42 "C:\Users\David\source\repos\EA-dotnet-webapi\EADotnetWebapiCli\Templates\Client\EditComponent.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(attr.Name.ToCamelCase()));
            
            #line default
            #line hidden
            this.Write(": new FormControl(");
            
            #line 42 "C:\Users\David\source\repos\EA-dotnet-webapi\EADotnetWebapiCli\Templates\Client\EditComponent.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(defaultValues[attr.Type.Name]));
            
            #line default
            #line hidden
            this.Write("),\r\n    ");
            
            #line 43 "C:\Users\David\source\repos\EA-dotnet-webapi\EADotnetWebapiCli\Templates\Client\EditComponent.tt"
 } else {  
            
            #line default
            #line hidden
            this.Write("        ");
            
            #line 44 "C:\Users\David\source\repos\EA-dotnet-webapi\EADotnetWebapiCli\Templates\Client\EditComponent.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(attr.Name.ToCamelCase()));
            
            #line default
            #line hidden
            this.Write("Id: new FormControl(0),\r\n    ");
            
            #line 45 "C:\Users\David\source\repos\EA-dotnet-webapi\EADotnetWebapiCli\Templates\Client\EditComponent.tt"
 } 
            
            #line default
            #line hidden
            
            #line 46 "C:\Users\David\source\repos\EA-dotnet-webapi\EADotnetWebapiCli\Templates\Client\EditComponent.tt"
 } 
            
            #line default
            #line hidden
            this.Write("    \r\n  });\r\n\r\n  constructor(@Inject(MAT_DIALOG_DATA) public data: number | null," +
                    " public dialogRef: MatDialogRef<");
            
            #line 49 "C:\Users\David\source\repos\EA-dotnet-webapi\EADotnetWebapiCli\Templates\Client\EditComponent.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("EditComponent>, private api: Api<unknown>) { \r\n\r\n  }\r\n\r\n\r\n  async ngOnInit(): Pro" +
                    "mise<void> {\r\n    if(this.data!==null){\r\n      const detail = await this.api.");
            
            #line 56 "C:\Users\David\source\repos\EA-dotnet-webapi\EADotnetWebapiCli\Templates\Client\EditComponent.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name.ToCamelCase()));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 56 "C:\Users\David\source\repos\EA-dotnet-webapi\EADotnetWebapiCli\Templates\Client\EditComponent.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name.ToCamelCase()));
            
            #line default
            #line hidden
            this.Write("Detail(this.data);\r\n      this.editForm.patchValue(detail.data);\r\n    }\r\n  }\r\n\r\n\r" +
                    "\n  async ok(){\r\n   try{\r\n    \r\n    if(this.data===null){\r\n      await this.api.");
            
            #line 66 "C:\Users\David\source\repos\EA-dotnet-webapi\EADotnetWebapiCli\Templates\Client\EditComponent.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name.ToCamelCase()));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 66 "C:\Users\David\source\repos\EA-dotnet-webapi\EADotnetWebapiCli\Templates\Client\EditComponent.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name.ToCamelCase()));
            
            #line default
            #line hidden
            this.Write("Create(this.editForm.value as ");
            
            #line 66 "C:\Users\David\source\repos\EA-dotnet-webapi\EADotnetWebapiCli\Templates\Client\EditComponent.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write(");\r\n    } else {\r\n      await this.api.");
            
            #line 68 "C:\Users\David\source\repos\EA-dotnet-webapi\EADotnetWebapiCli\Templates\Client\EditComponent.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name.ToCamelCase()));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 68 "C:\Users\David\source\repos\EA-dotnet-webapi\EADotnetWebapiCli\Templates\Client\EditComponent.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name.ToCamelCase()));
            
            #line default
            #line hidden
            this.Write("Update(this.editForm.value as ");
            
            #line 68 "C:\Users\David\source\repos\EA-dotnet-webapi\EADotnetWebapiCli\Templates\Client\EditComponent.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write(");\r\n    }\r\n    \r\n    this.dialogRef.close(this.editForm.value);\r\n   } catch(e: an" +
                    "y){\r\n    if(e.status===400){\r\n      this.errors = Object.keys(e.error.errors).ma" +
                    "p(key=>e.error.errors[key][0]);\r\n    \r\n    }\r\n     \r\n   }\r\n    \r\n    \r\n  }\r\n\r\n}\r" +
                    "\n\r\n\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 86 "C:\Users\David\source\repos\EA-dotnet-webapi\EADotnetWebapiCli\Templates\Client\EditComponent.tt"


public Element Model { get; set; }


        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public class EditComponentBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        public System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
