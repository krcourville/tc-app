﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TCApp.WebServices.SubmitResumeWebService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://turncommerce.com/", ConfigurationName="SubmitResumeWebService.SubmitResumeSoap")]
    public interface SubmitResumeSoap {
        
        // CODEGEN: Generating message contract since element name GetInstructionsResult from namespace http://turncommerce.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://turncommerce.com/GetInstructions", ReplyAction="*")]
        TCApp.WebServices.SubmitResumeWebService.GetInstructionsResponse GetInstructions(TCApp.WebServices.SubmitResumeWebService.GetInstructionsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://turncommerce.com/GetInstructions", ReplyAction="*")]
        System.Threading.Tasks.Task<TCApp.WebServices.SubmitResumeWebService.GetInstructionsResponse> GetInstructionsAsync(TCApp.WebServices.SubmitResumeWebService.GetInstructionsRequest request);
        
        // CODEGEN: Generating message contract since element name firstName from namespace http://turncommerce.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://turncommerce.com/SubmitInformation", ReplyAction="*")]
        TCApp.WebServices.SubmitResumeWebService.SubmitInformationResponse SubmitInformation(TCApp.WebServices.SubmitResumeWebService.SubmitInformationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://turncommerce.com/SubmitInformation", ReplyAction="*")]
        System.Threading.Tasks.Task<TCApp.WebServices.SubmitResumeWebService.SubmitInformationResponse> SubmitInformationAsync(TCApp.WebServices.SubmitResumeWebService.SubmitInformationRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetInstructionsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetInstructions", Namespace="http://turncommerce.com/", Order=0)]
        public TCApp.WebServices.SubmitResumeWebService.GetInstructionsRequestBody Body;
        
        public GetInstructionsRequest() {
        }
        
        public GetInstructionsRequest(TCApp.WebServices.SubmitResumeWebService.GetInstructionsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetInstructionsRequestBody {
        
        public GetInstructionsRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetInstructionsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetInstructionsResponse", Namespace="http://turncommerce.com/", Order=0)]
        public TCApp.WebServices.SubmitResumeWebService.GetInstructionsResponseBody Body;
        
        public GetInstructionsResponse() {
        }
        
        public GetInstructionsResponse(TCApp.WebServices.SubmitResumeWebService.GetInstructionsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://turncommerce.com/")]
    public partial class GetInstructionsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetInstructionsResult;
        
        public GetInstructionsResponseBody() {
        }
        
        public GetInstructionsResponseBody(string GetInstructionsResult) {
            this.GetInstructionsResult = GetInstructionsResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SubmitInformationRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SubmitInformation", Namespace="http://turncommerce.com/", Order=0)]
        public TCApp.WebServices.SubmitResumeWebService.SubmitInformationRequestBody Body;
        
        public SubmitInformationRequest() {
        }
        
        public SubmitInformationRequest(TCApp.WebServices.SubmitResumeWebService.SubmitInformationRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://turncommerce.com/")]
    public partial class SubmitInformationRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string firstName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string lastName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string emailAddress;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string phoneNumber;
        
        public SubmitInformationRequestBody() {
        }
        
        public SubmitInformationRequestBody(string firstName, string lastName, string emailAddress, string phoneNumber) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.emailAddress = emailAddress;
            this.phoneNumber = phoneNumber;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SubmitInformationResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SubmitInformationResponse", Namespace="http://turncommerce.com/", Order=0)]
        public TCApp.WebServices.SubmitResumeWebService.SubmitInformationResponseBody Body;
        
        public SubmitInformationResponse() {
        }
        
        public SubmitInformationResponse(TCApp.WebServices.SubmitResumeWebService.SubmitInformationResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://turncommerce.com/")]
    public partial class SubmitInformationResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string SubmitInformationResult;
        
        public SubmitInformationResponseBody() {
        }
        
        public SubmitInformationResponseBody(string SubmitInformationResult) {
            this.SubmitInformationResult = SubmitInformationResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SubmitResumeSoapChannel : TCApp.WebServices.SubmitResumeWebService.SubmitResumeSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SubmitResumeSoapClient : System.ServiceModel.ClientBase<TCApp.WebServices.SubmitResumeWebService.SubmitResumeSoap>, TCApp.WebServices.SubmitResumeWebService.SubmitResumeSoap {
        
        public SubmitResumeSoapClient() {
        }
        
        public SubmitResumeSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SubmitResumeSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SubmitResumeSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SubmitResumeSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TCApp.WebServices.SubmitResumeWebService.GetInstructionsResponse TCApp.WebServices.SubmitResumeWebService.SubmitResumeSoap.GetInstructions(TCApp.WebServices.SubmitResumeWebService.GetInstructionsRequest request) {
            return base.Channel.GetInstructions(request);
        }
        
        public string GetInstructions() {
            TCApp.WebServices.SubmitResumeWebService.GetInstructionsRequest inValue = new TCApp.WebServices.SubmitResumeWebService.GetInstructionsRequest();
            inValue.Body = new TCApp.WebServices.SubmitResumeWebService.GetInstructionsRequestBody();
            TCApp.WebServices.SubmitResumeWebService.GetInstructionsResponse retVal = ((TCApp.WebServices.SubmitResumeWebService.SubmitResumeSoap)(this)).GetInstructions(inValue);
            return retVal.Body.GetInstructionsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TCApp.WebServices.SubmitResumeWebService.GetInstructionsResponse> TCApp.WebServices.SubmitResumeWebService.SubmitResumeSoap.GetInstructionsAsync(TCApp.WebServices.SubmitResumeWebService.GetInstructionsRequest request) {
            return base.Channel.GetInstructionsAsync(request);
        }
        
        public System.Threading.Tasks.Task<TCApp.WebServices.SubmitResumeWebService.GetInstructionsResponse> GetInstructionsAsync() {
            TCApp.WebServices.SubmitResumeWebService.GetInstructionsRequest inValue = new TCApp.WebServices.SubmitResumeWebService.GetInstructionsRequest();
            inValue.Body = new TCApp.WebServices.SubmitResumeWebService.GetInstructionsRequestBody();
            return ((TCApp.WebServices.SubmitResumeWebService.SubmitResumeSoap)(this)).GetInstructionsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TCApp.WebServices.SubmitResumeWebService.SubmitInformationResponse TCApp.WebServices.SubmitResumeWebService.SubmitResumeSoap.SubmitInformation(TCApp.WebServices.SubmitResumeWebService.SubmitInformationRequest request) {
            return base.Channel.SubmitInformation(request);
        }
        
        public string SubmitInformation(string firstName, string lastName, string emailAddress, string phoneNumber) {
            TCApp.WebServices.SubmitResumeWebService.SubmitInformationRequest inValue = new TCApp.WebServices.SubmitResumeWebService.SubmitInformationRequest();
            inValue.Body = new TCApp.WebServices.SubmitResumeWebService.SubmitInformationRequestBody();
            inValue.Body.firstName = firstName;
            inValue.Body.lastName = lastName;
            inValue.Body.emailAddress = emailAddress;
            inValue.Body.phoneNumber = phoneNumber;
            TCApp.WebServices.SubmitResumeWebService.SubmitInformationResponse retVal = ((TCApp.WebServices.SubmitResumeWebService.SubmitResumeSoap)(this)).SubmitInformation(inValue);
            return retVal.Body.SubmitInformationResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TCApp.WebServices.SubmitResumeWebService.SubmitInformationResponse> TCApp.WebServices.SubmitResumeWebService.SubmitResumeSoap.SubmitInformationAsync(TCApp.WebServices.SubmitResumeWebService.SubmitInformationRequest request) {
            return base.Channel.SubmitInformationAsync(request);
        }
        
        public System.Threading.Tasks.Task<TCApp.WebServices.SubmitResumeWebService.SubmitInformationResponse> SubmitInformationAsync(string firstName, string lastName, string emailAddress, string phoneNumber) {
            TCApp.WebServices.SubmitResumeWebService.SubmitInformationRequest inValue = new TCApp.WebServices.SubmitResumeWebService.SubmitInformationRequest();
            inValue.Body = new TCApp.WebServices.SubmitResumeWebService.SubmitInformationRequestBody();
            inValue.Body.firstName = firstName;
            inValue.Body.lastName = lastName;
            inValue.Body.emailAddress = emailAddress;
            inValue.Body.phoneNumber = phoneNumber;
            return ((TCApp.WebServices.SubmitResumeWebService.SubmitResumeSoap)(this)).SubmitInformationAsync(inValue);
        }
    }
}