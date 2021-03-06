﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1026
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.1026.
// 
#pragma warning disable 1591

namespace FloraSoft.MQService {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="MQWebServiceSoap", Namespace="http://tempuri.org/")]
    public partial class MQWebService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetHUBDataOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetSignatureOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetResponseOperationCompleted;
        
        private System.Threading.SendOrPostCallback TestResponseOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public MQWebService() {
            this.Url = global::FloraSoft.Properties.Settings.Default.FCP_MQService_MQWebService;
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
        public event GetHUBDataCompletedEventHandler GetHUBDataCompleted;
        
        /// <remarks/>
        public event GetSignatureCompletedEventHandler GetSignatureCompleted;
        
        /// <remarks/>
        public event GetResponseCompletedEventHandler GetResponseCompleted;
        
        /// <remarks/>
        public event TestResponseCompletedEventHandler TestResponseCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetHUBData", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetHUBData(string acno, string userID) {
            object[] results = this.Invoke("GetHUBData", new object[] {
                        acno,
                        userID});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetHUBDataAsync(string acno, string userID) {
            this.GetHUBDataAsync(acno, userID, null);
        }
        
        /// <remarks/>
        public void GetHUBDataAsync(string acno, string userID, object userState) {
            if ((this.GetHUBDataOperationCompleted == null)) {
                this.GetHUBDataOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetHUBDataOperationCompleted);
            }
            this.InvokeAsync("GetHUBData", new object[] {
                        acno,
                        userID}, this.GetHUBDataOperationCompleted, userState);
        }
        
        private void OnGetHUBDataOperationCompleted(object arg) {
            if ((this.GetHUBDataCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetHUBDataCompleted(this, new GetHUBDataCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetSignature", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetSignature(string acno, string userID) {
            object[] results = this.Invoke("GetSignature", new object[] {
                        acno,
                        userID});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetSignatureAsync(string acno, string userID) {
            this.GetSignatureAsync(acno, userID, null);
        }
        
        /// <remarks/>
        public void GetSignatureAsync(string acno, string userID, object userState) {
            if ((this.GetSignatureOperationCompleted == null)) {
                this.GetSignatureOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetSignatureOperationCompleted);
            }
            this.InvokeAsync("GetSignature", new object[] {
                        acno,
                        userID}, this.GetSignatureOperationCompleted, userState);
        }
        
        private void OnGetSignatureOperationCompleted(object arg) {
            if ((this.GetSignatureCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetSignatureCompleted(this, new GetSignatureCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetResponse", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetResponse(string acno, string userID, string flag) {
            object[] results = this.Invoke("GetResponse", new object[] {
                        acno,
                        userID,
                        flag});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetResponseAsync(string acno, string userID, string flag) {
            this.GetResponseAsync(acno, userID, flag, null);
        }
        
        /// <remarks/>
        public void GetResponseAsync(string acno, string userID, string flag, object userState) {
            if ((this.GetResponseOperationCompleted == null)) {
                this.GetResponseOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetResponseOperationCompleted);
            }
            this.InvokeAsync("GetResponse", new object[] {
                        acno,
                        userID,
                        flag}, this.GetResponseOperationCompleted, userState);
        }
        
        private void OnGetResponseOperationCompleted(object arg) {
            if ((this.GetResponseCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetResponseCompleted(this, new GetResponseCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/TestResponse", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string TestResponse() {
            object[] results = this.Invoke("TestResponse", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void TestResponseAsync() {
            this.TestResponseAsync(null);
        }
        
        /// <remarks/>
        public void TestResponseAsync(object userState) {
            if ((this.TestResponseOperationCompleted == null)) {
                this.TestResponseOperationCompleted = new System.Threading.SendOrPostCallback(this.OnTestResponseOperationCompleted);
            }
            this.InvokeAsync("TestResponse", new object[0], this.TestResponseOperationCompleted, userState);
        }
        
        private void OnTestResponseOperationCompleted(object arg) {
            if ((this.TestResponseCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.TestResponseCompleted(this, new TestResponseCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void GetHUBDataCompletedEventHandler(object sender, GetHUBDataCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetHUBDataCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetHUBDataCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void GetSignatureCompletedEventHandler(object sender, GetSignatureCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetSignatureCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetSignatureCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void GetResponseCompletedEventHandler(object sender, GetResponseCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetResponseCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetResponseCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void TestResponseCompletedEventHandler(object sender, TestResponseCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestResponseCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal TestResponseCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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