﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Ce code source a été automatiquement généré par Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace H21AndroidAppForWebService.ContactWebservice {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WebServiceH21Soap", Namespace="http://tempuri.org/")]
    public partial class WebServiceH21 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetXMLOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetJsonOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WebServiceH21() {
            this.Url = "https://localhost:44374/WebServiceH21.asmx";
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetXMLCompletedEventHandler GetXMLCompleted;
        
        /// <remarks/>
        public event GetJsonCompletedEventHandler GetJsonCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetXML", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public contact GetXML() {
            object[] results = this.Invoke("GetXML", new object[0]);
            return ((contact)(results[0]));
        }
        
        /// <remarks/>
        public void GetXMLAsync() {
            this.GetXMLAsync(null);
        }
        
        /// <remarks/>
        public void GetXMLAsync(object userState) {
            if ((this.GetXMLOperationCompleted == null)) {
                this.GetXMLOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetXMLOperationCompleted);
            }
            this.InvokeAsync("GetXML", new object[0], this.GetXMLOperationCompleted, userState);
        }
        
        private void OnGetXMLOperationCompleted(object arg) {
            if ((this.GetXMLCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetXMLCompleted(this, new GetXMLCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetJson", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetJson() {
            object[] results = this.Invoke("GetJson", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetJsonAsync() {
            this.GetJsonAsync(null);
        }
        
        /// <remarks/>
        public void GetJsonAsync(object userState) {
            if ((this.GetJsonOperationCompleted == null)) {
                this.GetJsonOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetJsonOperationCompleted);
            }
            this.InvokeAsync("GetJson", new object[0], this.GetJsonOperationCompleted, userState);
        }
        
        private void OnGetJsonOperationCompleted(object arg) {
            if ((this.GetJsonCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetJsonCompleted(this, new GetJsonCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class contact {
        
        private int idField;
        
        private string nameField;
        
        private string emailField;
        
        private string mobileField;
        
        /// <remarks/>
        public int id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        public string mobile {
            get {
                return this.mobileField;
            }
            set {
                this.mobileField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void GetXMLCompletedEventHandler(object sender, GetXMLCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetXMLCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetXMLCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public contact Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((contact)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void GetJsonCompletedEventHandler(object sender, GetJsonCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetJsonCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetJsonCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
       /// <remarks/>
        public string Result {
           get {
                 this.RaiseExceptionIfNecessary();
                 return ((string)(this.results[0]));
               }
         }
    }
}

#pragma warning restore 1591