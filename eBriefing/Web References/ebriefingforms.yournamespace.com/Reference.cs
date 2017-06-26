// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.17020
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace eBriefing.ebriefingforms.yourNameSpaceURL.com {
    
    
    /// <remarks/>
    [System.Web.Services.WebServiceBinding(Name="AuthenticationSoap", Namespace="http://schemas.microsoft.com/sharepoint/soap/")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class Authentication : System.Web.Services.Protocols.SoapHttpClientBridge {
        
        private System.Threading.SendOrPostCallback LoginOperationCompleted;
        
        private System.Threading.SendOrPostCallback ModeOperationCompleted;
        
        public Authentication() {
            this.Url = "http://yourEbriefingSharePointInstall/_vti_bin/authentication.asmx";
        }
        
        public Authentication(string url) {
            this.Url = url;
        }
        
        public event LoginCompletedEventHandler LoginCompleted;
        
        public event ModeCompletedEventHandler ModeCompleted;
        
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sharepoint/soap/Login", RequestNamespace="http://schemas.microsoft.com/sharepoint/soap/", ResponseNamespace="http://schemas.microsoft.com/sharepoint/soap/", ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use=System.Web.Services.Description.SoapBindingUse.Literal)]
        public LoginResult Login(string username, string password) {
            object[] results = this.Invoke("Login", new object[] {
                        username,
                        password});
            return ((LoginResult)(results[0]));
        }
        
        public System.IAsyncResult BeginLogin(string username, string password, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("Login", new object[] {
                        username,
                        password}, callback, asyncState);
        }
        
        public LoginResult EndLogin(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((LoginResult)(results[0]));
        }
        
        public void LoginAsync(string username, string password) {
            this.LoginAsync(username, password, null);
        }
        
        public void LoginAsync(string username, string password, object userState) {
            if ((this.LoginOperationCompleted == null)) {
                this.LoginOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLoginCompleted);
            }
            this.InvokeAsync("Login", new object[] {
                        username,
                        password}, this.LoginOperationCompleted, userState);
        }
        
        private void OnLoginCompleted(object arg) {
            if ((this.LoginCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LoginCompleted(this, new LoginCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sharepoint/soap/Mode", RequestNamespace="http://schemas.microsoft.com/sharepoint/soap/", ResponseNamespace="http://schemas.microsoft.com/sharepoint/soap/", ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use=System.Web.Services.Description.SoapBindingUse.Literal)]
        public AuthenticationMode Mode() {
            object[] results = this.Invoke("Mode", new object[0]);
            return ((AuthenticationMode)(results[0]));
        }
        
        public System.IAsyncResult BeginMode(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("Mode", new object[0], callback, asyncState);
        }
        
        public AuthenticationMode EndMode(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((AuthenticationMode)(results[0]));
        }
        
        public void ModeAsync() {
            this.ModeAsync(null);
        }
        
        public void ModeAsync(object userState) {
            if ((this.ModeOperationCompleted == null)) {
                this.ModeOperationCompleted = new System.Threading.SendOrPostCallback(this.OnModeCompleted);
            }
            this.InvokeAsync("Mode", new object[0], this.ModeOperationCompleted, userState);
        }
        
        private void OnModeCompleted(object arg) {
            if ((this.ModeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ModeCompleted(this, new ModeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sharepoint/soap/")]
    public partial class LoginResult {
        
        /// <remarks/>
        public string CookieName;
        
        /// <remarks/>
        public LoginErrorCode ErrorCode;
        
        /// <remarks/>
        public int TimeoutSeconds;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sharepoint/soap/")]
    public enum LoginErrorCode {
        
        /// <remarks/>
        NoError,
        
        /// <remarks/>
        NotInFormsAuthenticationMode,
        
        /// <remarks/>
        PasswordNotMatch,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sharepoint/soap/")]
    public enum AuthenticationMode {
        
        /// <remarks/>
        None,
        
        /// <remarks/>
        Windows,
        
        /// <remarks/>
        Passport,
        
        /// <remarks/>
        Forms,
    }
    
    public partial class LoginCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal LoginCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public LoginResult Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((LoginResult)(this.results[0]));
            }
        }
    }
    
    public delegate void LoginCompletedEventHandler(object sender, LoginCompletedEventArgs args);
    
    public partial class ModeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ModeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public AuthenticationMode Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((AuthenticationMode)(this.results[0]));
            }
        }
    }
    
    public delegate void ModeCompletedEventHandler(object sender, ModeCompletedEventArgs args);
}
