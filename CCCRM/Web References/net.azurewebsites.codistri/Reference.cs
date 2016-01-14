﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.34209.
// 
#pragma warning disable 1591

namespace CCCRM.net.azurewebsites.codistri {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WebServicesSoap", Namespace="http://tempuri.org/")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(object[]))]
    public partial class WebServices : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback RunActionByNameOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetComboListByNameOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WebServices() {
            this.Url = global::CCCRM.Properties.Settings.Default.CCCRM_net_azurewebsites_codistri_WebServices;
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
        public event RunActionByNameCompletedEventHandler RunActionByNameCompleted;
        
        /// <remarks/>
        public event GetComboListByNameCompletedEventHandler GetComboListByNameCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/RunActionByName", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string RunActionByName(string userName, string password, ExportStyle exportStyle, string applicationURL, string gridURL, string actionName, object[] args) {
            object[] results = this.Invoke("RunActionByName", new object[] {
                        userName,
                        password,
                        exportStyle,
                        applicationURL,
                        gridURL,
                        actionName,
                        args});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void RunActionByNameAsync(string userName, string password, ExportStyle exportStyle, string applicationURL, string gridURL, string actionName, object[] args) {
            this.RunActionByNameAsync(userName, password, exportStyle, applicationURL, gridURL, actionName, args, null);
        }
        
        /// <remarks/>
        public void RunActionByNameAsync(string userName, string password, ExportStyle exportStyle, string applicationURL, string gridURL, string actionName, object[] args, object userState) {
            if ((this.RunActionByNameOperationCompleted == null)) {
                this.RunActionByNameOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRunActionByNameOperationCompleted);
            }
            this.InvokeAsync("RunActionByName", new object[] {
                        userName,
                        password,
                        exportStyle,
                        applicationURL,
                        gridURL,
                        actionName,
                        args}, this.RunActionByNameOperationCompleted, userState);
        }
        
        private void OnRunActionByNameOperationCompleted(object arg) {
            if ((this.RunActionByNameCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RunActionByNameCompleted(this, new RunActionByNameCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetComboListByName", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetComboListByName(string userName, string password, ExportStyle exportStyle, string applicationURL, string gridURL, string comboName, object[] args) {
            object[] results = this.Invoke("GetComboListByName", new object[] {
                        userName,
                        password,
                        exportStyle,
                        applicationURL,
                        gridURL,
                        comboName,
                        args});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetComboListByNameAsync(string userName, string password, ExportStyle exportStyle, string applicationURL, string gridURL, string comboName, object[] args) {
            this.GetComboListByNameAsync(userName, password, exportStyle, applicationURL, gridURL, comboName, args, null);
        }
        
        /// <remarks/>
        public void GetComboListByNameAsync(string userName, string password, ExportStyle exportStyle, string applicationURL, string gridURL, string comboName, object[] args, object userState) {
            if ((this.GetComboListByNameOperationCompleted == null)) {
                this.GetComboListByNameOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetComboListByNameOperationCompleted);
            }
            this.InvokeAsync("GetComboListByName", new object[] {
                        userName,
                        password,
                        exportStyle,
                        applicationURL,
                        gridURL,
                        comboName,
                        args}, this.GetComboListByNameOperationCompleted, userState);
        }
        
        private void OnGetComboListByNameOperationCompleted(object arg) {
            if ((this.GetComboListByNameCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetComboListByNameCompleted(this, new GetComboListByNameCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public enum ExportStyle {
        
        /// <remarks/>
        CsvWithHeader,
        
        /// <remarks/>
        CsvWithoutHeader,
        
        /// <remarks/>
        Json,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void RunActionByNameCompletedEventHandler(object sender, RunActionByNameCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RunActionByNameCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal RunActionByNameCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void GetComboListByNameCompletedEventHandler(object sender, GetComboListByNameCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetComboListByNameCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetComboListByNameCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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