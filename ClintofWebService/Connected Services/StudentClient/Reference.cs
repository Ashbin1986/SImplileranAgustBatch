//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClintofWebService.StudentClient {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://tempuri.org/", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Employee : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmpNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string EmpName {
            get {
                return this.EmpNameField;
            }
            set {
                if ((object.ReferenceEquals(this.EmpNameField, value) != true)) {
                    this.EmpNameField = value;
                    this.RaisePropertyChanged("EmpName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="StudentClient.StudentServiceSoap")]
    public interface StudentServiceSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        ClintofWebService.StudentClient.HelloWorldResponse HelloWorld(ClintofWebService.StudentClient.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<ClintofWebService.StudentClient.HelloWorldResponse> HelloWorldAsync(ClintofWebService.StudentClient.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name GetRecordsResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetRecords", ReplyAction="*")]
        ClintofWebService.StudentClient.GetRecordsResponse GetRecords(ClintofWebService.StudentClient.GetRecordsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetRecords", ReplyAction="*")]
        System.Threading.Tasks.Task<ClintofWebService.StudentClient.GetRecordsResponse> GetRecordsAsync(ClintofWebService.StudentClient.GetRecordsRequest request);
        
        // CODEGEN: Generating message contract since element name employee from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddEmployee", ReplyAction="*")]
        ClintofWebService.StudentClient.AddEmployeeResponse AddEmployee(ClintofWebService.StudentClient.AddEmployeeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddEmployee", ReplyAction="*")]
        System.Threading.Tasks.Task<ClintofWebService.StudentClient.AddEmployeeResponse> AddEmployeeAsync(ClintofWebService.StudentClient.AddEmployeeRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public ClintofWebService.StudentClient.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(ClintofWebService.StudentClient.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public ClintofWebService.StudentClient.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(ClintofWebService.StudentClient.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetRecordsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetRecords", Namespace="http://tempuri.org/", Order=0)]
        public ClintofWebService.StudentClient.GetRecordsRequestBody Body;
        
        public GetRecordsRequest() {
        }
        
        public GetRecordsRequest(ClintofWebService.StudentClient.GetRecordsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetRecordsRequestBody {
        
        public GetRecordsRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetRecordsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetRecordsResponse", Namespace="http://tempuri.org/", Order=0)]
        public ClintofWebService.StudentClient.GetRecordsResponseBody Body;
        
        public GetRecordsResponse() {
        }
        
        public GetRecordsResponse(ClintofWebService.StudentClient.GetRecordsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetRecordsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ClintofWebService.StudentClient.ArrayOfString GetRecordsResult;
        
        public GetRecordsResponseBody() {
        }
        
        public GetRecordsResponseBody(ClintofWebService.StudentClient.ArrayOfString GetRecordsResult) {
            this.GetRecordsResult = GetRecordsResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddEmployeeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddEmployee", Namespace="http://tempuri.org/", Order=0)]
        public ClintofWebService.StudentClient.AddEmployeeRequestBody Body;
        
        public AddEmployeeRequest() {
        }
        
        public AddEmployeeRequest(ClintofWebService.StudentClient.AddEmployeeRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddEmployeeRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ClintofWebService.StudentClient.Employee employee;
        
        public AddEmployeeRequestBody() {
        }
        
        public AddEmployeeRequestBody(ClintofWebService.StudentClient.Employee employee) {
            this.employee = employee;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddEmployeeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddEmployeeResponse", Namespace="http://tempuri.org/", Order=0)]
        public ClintofWebService.StudentClient.AddEmployeeResponseBody Body;
        
        public AddEmployeeResponse() {
        }
        
        public AddEmployeeResponse(ClintofWebService.StudentClient.AddEmployeeResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class AddEmployeeResponseBody {
        
        public AddEmployeeResponseBody() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface StudentServiceSoapChannel : ClintofWebService.StudentClient.StudentServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class StudentServiceSoapClient : System.ServiceModel.ClientBase<ClintofWebService.StudentClient.StudentServiceSoap>, ClintofWebService.StudentClient.StudentServiceSoap {
        
        public StudentServiceSoapClient() {
        }
        
        public StudentServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public StudentServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StudentServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StudentServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClintofWebService.StudentClient.HelloWorldResponse ClintofWebService.StudentClient.StudentServiceSoap.HelloWorld(ClintofWebService.StudentClient.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            ClintofWebService.StudentClient.HelloWorldRequest inValue = new ClintofWebService.StudentClient.HelloWorldRequest();
            inValue.Body = new ClintofWebService.StudentClient.HelloWorldRequestBody();
            ClintofWebService.StudentClient.HelloWorldResponse retVal = ((ClintofWebService.StudentClient.StudentServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClintofWebService.StudentClient.HelloWorldResponse> ClintofWebService.StudentClient.StudentServiceSoap.HelloWorldAsync(ClintofWebService.StudentClient.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClintofWebService.StudentClient.HelloWorldResponse> HelloWorldAsync() {
            ClintofWebService.StudentClient.HelloWorldRequest inValue = new ClintofWebService.StudentClient.HelloWorldRequest();
            inValue.Body = new ClintofWebService.StudentClient.HelloWorldRequestBody();
            return ((ClintofWebService.StudentClient.StudentServiceSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClintofWebService.StudentClient.GetRecordsResponse ClintofWebService.StudentClient.StudentServiceSoap.GetRecords(ClintofWebService.StudentClient.GetRecordsRequest request) {
            return base.Channel.GetRecords(request);
        }
        
        public ClintofWebService.StudentClient.ArrayOfString GetRecords() {
            ClintofWebService.StudentClient.GetRecordsRequest inValue = new ClintofWebService.StudentClient.GetRecordsRequest();
            inValue.Body = new ClintofWebService.StudentClient.GetRecordsRequestBody();
            ClintofWebService.StudentClient.GetRecordsResponse retVal = ((ClintofWebService.StudentClient.StudentServiceSoap)(this)).GetRecords(inValue);
            return retVal.Body.GetRecordsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClintofWebService.StudentClient.GetRecordsResponse> ClintofWebService.StudentClient.StudentServiceSoap.GetRecordsAsync(ClintofWebService.StudentClient.GetRecordsRequest request) {
            return base.Channel.GetRecordsAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClintofWebService.StudentClient.GetRecordsResponse> GetRecordsAsync() {
            ClintofWebService.StudentClient.GetRecordsRequest inValue = new ClintofWebService.StudentClient.GetRecordsRequest();
            inValue.Body = new ClintofWebService.StudentClient.GetRecordsRequestBody();
            return ((ClintofWebService.StudentClient.StudentServiceSoap)(this)).GetRecordsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClintofWebService.StudentClient.AddEmployeeResponse ClintofWebService.StudentClient.StudentServiceSoap.AddEmployee(ClintofWebService.StudentClient.AddEmployeeRequest request) {
            return base.Channel.AddEmployee(request);
        }
        
        public void AddEmployee(ClintofWebService.StudentClient.Employee employee) {
            ClintofWebService.StudentClient.AddEmployeeRequest inValue = new ClintofWebService.StudentClient.AddEmployeeRequest();
            inValue.Body = new ClintofWebService.StudentClient.AddEmployeeRequestBody();
            inValue.Body.employee = employee;
            ClintofWebService.StudentClient.AddEmployeeResponse retVal = ((ClintofWebService.StudentClient.StudentServiceSoap)(this)).AddEmployee(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClintofWebService.StudentClient.AddEmployeeResponse> ClintofWebService.StudentClient.StudentServiceSoap.AddEmployeeAsync(ClintofWebService.StudentClient.AddEmployeeRequest request) {
            return base.Channel.AddEmployeeAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClintofWebService.StudentClient.AddEmployeeResponse> AddEmployeeAsync(ClintofWebService.StudentClient.Employee employee) {
            ClintofWebService.StudentClient.AddEmployeeRequest inValue = new ClintofWebService.StudentClient.AddEmployeeRequest();
            inValue.Body = new ClintofWebService.StudentClient.AddEmployeeRequestBody();
            inValue.Body.employee = employee;
            return ((ClintofWebService.StudentClient.StudentServiceSoap)(this)).AddEmployeeAsync(inValue);
        }
    }
}
