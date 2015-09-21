﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.17929
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

// 
// This source code was auto-generated by wsdl, Version=4.0.30319.17929.
// 

namespace WokSearchLite
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name = "WokSearchLiteServiceSoapBinding", Namespace = "http://woksearchlite.v3.wokmws.thomsonreuters.com")]
    public partial class WokSearchLiteService : System.Web.Services.Protocols.SoapHttpClientProtocol
    {

        private System.Threading.SendOrPostCallback retrieveByIdOperationCompleted;

        private System.Threading.SendOrPostCallback retrieveOperationCompleted;

        private System.Threading.SendOrPostCallback searchOperationCompleted;

        /// <remarks/>
        public WokSearchLiteService()
        {
            this.Url = "http://search.webofknowledge.com/esti/wokmws/ws/WokSearchLite";
        }

        /// <remarks/>
        public event retrieveByIdCompletedEventHandler retrieveByIdCompleted;

        /// <remarks/>
        public event retrieveCompletedEventHandler retrieveCompleted;

        /// <remarks/>
        public event searchCompletedEventHandler searchCompleted;

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://woksearchlite.v3.wokmws.thomsonreuters.com", ResponseNamespace = "http://woksearchlite.v3.wokmws.thomsonreuters.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public searchResults retrieveById([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string databaseId, [System.Xml.Serialization.XmlElementAttribute("uid", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string[] uid, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string queryLanguage, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] retrieveParameters retrieveParameters)
        {
            object[] results = this.Invoke("retrieveById", new object[] {
                    databaseId,
                    uid,
                    queryLanguage,
                    retrieveParameters});
            return ((searchResults)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginretrieveById(string databaseId, string[] uid, string queryLanguage, retrieveParameters retrieveParameters, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("retrieveById", new object[] {
                    databaseId,
                    uid,
                    queryLanguage,
                    retrieveParameters}, callback, asyncState);
        }

        /// <remarks/>
        public searchResults EndretrieveById(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((searchResults)(results[0]));
        }

        /// <remarks/>
        public void retrieveByIdAsync(string databaseId, string[] uid, string queryLanguage, retrieveParameters retrieveParameters)
        {
            this.retrieveByIdAsync(databaseId, uid, queryLanguage, retrieveParameters, null);
        }

        /// <remarks/>
        public void retrieveByIdAsync(string databaseId, string[] uid, string queryLanguage, retrieveParameters retrieveParameters, object userState)
        {
            if ((this.retrieveByIdOperationCompleted == null))
            {
                this.retrieveByIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnretrieveByIdOperationCompleted);
            }
            this.InvokeAsync("retrieveById", new object[] {
                    databaseId,
                    uid,
                    queryLanguage,
                    retrieveParameters}, this.retrieveByIdOperationCompleted, userState);
        }

        private void OnretrieveByIdOperationCompleted(object arg)
        {
            if ((this.retrieveByIdCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.retrieveByIdCompleted(this, new retrieveByIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://woksearchlite.v3.wokmws.thomsonreuters.com", ResponseNamespace = "http://woksearchlite.v3.wokmws.thomsonreuters.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public searchResults retrieve([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string queryId, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] retrieveParameters retrieveParameters)
        {
            object[] results = this.Invoke("retrieve", new object[] {
                    queryId,
                    retrieveParameters});
            return ((searchResults)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult Beginretrieve(string queryId, retrieveParameters retrieveParameters, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("retrieve", new object[] {
                    queryId,
                    retrieveParameters}, callback, asyncState);
        }

        /// <remarks/>
        public searchResults Endretrieve(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((searchResults)(results[0]));
        }

        /// <remarks/>
        public void retrieveAsync(string queryId, retrieveParameters retrieveParameters)
        {
            this.retrieveAsync(queryId, retrieveParameters, null);
        }

        /// <remarks/>
        public void retrieveAsync(string queryId, retrieveParameters retrieveParameters, object userState)
        {
            if ((this.retrieveOperationCompleted == null))
            {
                this.retrieveOperationCompleted = new System.Threading.SendOrPostCallback(this.OnretrieveOperationCompleted);
            }
            this.InvokeAsync("retrieve", new object[] {
                    queryId,
                    retrieveParameters}, this.retrieveOperationCompleted, userState);
        }

        private void OnretrieveOperationCompleted(object arg)
        {
            if ((this.retrieveCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.retrieveCompleted(this, new retrieveCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://woksearchlite.v3.wokmws.thomsonreuters.com", ResponseNamespace = "http://woksearchlite.v3.wokmws.thomsonreuters.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public searchResults search([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] queryParameters queryParameters, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] retrieveParameters retrieveParameters)
        {
            object[] results = this.Invoke("search", new object[] {
                    queryParameters,
                    retrieveParameters});
            return ((searchResults)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult Beginsearch(queryParameters queryParameters, retrieveParameters retrieveParameters, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("search", new object[] {
                    queryParameters,
                    retrieveParameters}, callback, asyncState);
        }

        /// <remarks/>
        public searchResults Endsearch(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((searchResults)(results[0]));
        }

        /// <remarks/>
        public void searchAsync(queryParameters queryParameters, retrieveParameters retrieveParameters)
        {
            this.searchAsync(queryParameters, retrieveParameters, null);
        }

        /// <remarks/>
        public void searchAsync(queryParameters queryParameters, retrieveParameters retrieveParameters, object userState)
        {
            if ((this.searchOperationCompleted == null))
            {
                this.searchOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsearchOperationCompleted);
            }
            this.InvokeAsync("search", new object[] {
                    queryParameters,
                    retrieveParameters}, this.searchOperationCompleted, userState);
        }

        private void OnsearchOperationCompleted(object arg)
        {
            if ((this.searchCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.searchCompleted(this, new searchCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        public new void CancelAsync(object userState)
        {
            base.CancelAsync(userState);
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://woksearchlite.v3.wokmws.thomsonreuters.com")]
    public partial class retrieveParameters
    {

        private int firstRecordField;

        private int countField;

        private sortField[] sortFieldField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int firstRecord
        {
            get
            {
                return this.firstRecordField;
            }
            set
            {
                this.firstRecordField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int count
        {
            get
            {
                return this.countField;
            }
            set
            {
                this.countField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("sortField", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public sortField[] sortField
        {
            get
            {
                return this.sortFieldField;
            }
            set
            {
                this.sortFieldField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://woksearchlite.v3.wokmws.thomsonreuters.com")]
    public partial class sortField
    {

        private string nameField;

        private string sortField1;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string sort
        {
            get
            {
                return this.sortField1;
            }
            set
            {
                this.sortField1 = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://woksearchlite.v3.wokmws.thomsonreuters.com")]
    public partial class timeSpan
    {

        private string beginField;

        private string endField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string begin
        {
            get
            {
                return this.beginField;
            }
            set
            {
                this.beginField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string end
        {
            get
            {
                return this.endField;
            }
            set
            {
                this.endField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://woksearchlite.v3.wokmws.thomsonreuters.com")]
    public partial class editionDesc
    {

        private string collectionField;

        private string editionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string collection
        {
            get
            {
                return this.collectionField;
            }
            set
            {
                this.collectionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string edition
        {
            get
            {
                return this.editionField;
            }
            set
            {
                this.editionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://woksearchlite.v3.wokmws.thomsonreuters.com")]
    public partial class queryParameters
    {

        private string databaseIdField;

        private string userQueryField;

        private editionDesc[] editionsField;

        private string symbolicTimeSpanField;

        private timeSpan timeSpanField;

        private string queryLanguageField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string databaseId
        {
            get
            {
                return this.databaseIdField;
            }
            set
            {
                this.databaseIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string userQuery
        {
            get
            {
                return this.userQueryField;
            }
            set
            {
                this.userQueryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("editions", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public editionDesc[] editions
        {
            get
            {
                return this.editionsField;
            }
            set
            {
                this.editionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string symbolicTimeSpan
        {
            get
            {
                return this.symbolicTimeSpanField;
            }
            set
            {
                this.symbolicTimeSpanField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public timeSpan timeSpan
        {
            get
            {
                return this.timeSpanField;
            }
            set
            {
                this.timeSpanField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string queryLanguage
        {
            get
            {
                return this.queryLanguageField;
            }
            set
            {
                this.queryLanguageField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://woksearchlite.v3.wokmws.thomsonreuters.com")]
    public partial class labelValuesPair
    {

        private string labelField;

        private string[] valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string label
        {
            get
            {
                return this.labelField;
            }
            set
            {
                this.labelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("value", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string[] value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://woksearchlite.v3.wokmws.thomsonreuters.com")]
    public partial class liteRecord
    {

        private string uidField;

        private labelValuesPair[] titleField;

        private labelValuesPair[] sourceField;

        private labelValuesPair[] authorsField;

        private labelValuesPair[] keywordsField;

        private labelValuesPair[] otherField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string uid
        {
            get
            {
                return this.uidField;
            }
            set
            {
                this.uidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("title", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public labelValuesPair[] title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("source", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public labelValuesPair[] source
        {
            get
            {
                return this.sourceField;
            }
            set
            {
                this.sourceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("authors", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public labelValuesPair[] authors
        {
            get
            {
                return this.authorsField;
            }
            set
            {
                this.authorsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("keywords", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public labelValuesPair[] keywords
        {
            get
            {
                return this.keywordsField;
            }
            set
            {
                this.keywordsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("other", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public labelValuesPair[] other
        {
            get
            {
                return this.otherField;
            }
            set
            {
                this.otherField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://woksearchlite.v3.wokmws.thomsonreuters.com")]
    public class searchResults
    {

        private string queryIdField;

        private int recordsFoundField;

        private long recordsSearchedField;

        private liteRecord parentField;

        private liteRecord[] recordsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string queryId
        {
            get
            {
                return this.queryIdField;
            }
            set
            {
                this.queryIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int recordsFound
        {
            get
            {
                return this.recordsFoundField;
            }
            set
            {
                this.recordsFoundField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long recordsSearched
        {
            get
            {
                return this.recordsSearchedField;
            }
            set
            {
                this.recordsSearchedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public liteRecord parent
        {
            get
            {
                return this.parentField;
            }
            set
            {
                this.parentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("records", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public liteRecord[] records
        {
            get
            {
                return this.recordsField;
            }
            set
            {
                this.recordsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    public delegate void retrieveByIdCompletedEventHandler(object sender, retrieveByIdCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class retrieveByIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal retrieveByIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public searchResults Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((searchResults)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    public delegate void retrieveCompletedEventHandler(object sender, retrieveCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class retrieveCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal retrieveCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public searchResults Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((searchResults)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    public delegate void searchCompletedEventHandler(object sender, searchCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class searchCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal searchCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public searchResults Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((searchResults)(this.results[0]));
            }
        }
    }
}