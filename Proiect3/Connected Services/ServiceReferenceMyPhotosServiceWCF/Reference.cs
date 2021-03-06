﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReferenceMyPhotosServiceWCF
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="File", Namespace="http://schemas.datacontract.org/2004/07/MyPhotosWCF", IsReference=true)]
    public partial class File : object
    {
        
        private string FileDateField;
        
        private string FileDescField;
        
        private int FileIDField;
        
        private string FileNameField;
        
        private string FilePathField;
        
        private string FileSizeField;
        
        private string FileTagsField;
        
        private string FileTypeField;
        
        private ServiceReferenceMyPhotosServiceWCF.Folder FolderField;
        
        private int FolderIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FileDate
        {
            get
            {
                return this.FileDateField;
            }
            set
            {
                this.FileDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FileDesc
        {
            get
            {
                return this.FileDescField;
            }
            set
            {
                this.FileDescField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int FileID
        {
            get
            {
                return this.FileIDField;
            }
            set
            {
                this.FileIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FileName
        {
            get
            {
                return this.FileNameField;
            }
            set
            {
                this.FileNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FilePath
        {
            get
            {
                return this.FilePathField;
            }
            set
            {
                this.FilePathField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FileSize
        {
            get
            {
                return this.FileSizeField;
            }
            set
            {
                this.FileSizeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FileTags
        {
            get
            {
                return this.FileTagsField;
            }
            set
            {
                this.FileTagsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FileType
        {
            get
            {
                return this.FileTypeField;
            }
            set
            {
                this.FileTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReferenceMyPhotosServiceWCF.Folder Folder
        {
            get
            {
                return this.FolderField;
            }
            set
            {
                this.FolderField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int FolderId
        {
            get
            {
                return this.FolderIdField;
            }
            set
            {
                this.FolderIdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Folder", Namespace="http://schemas.datacontract.org/2004/07/MyPhotosWCF", IsReference=true)]
    public partial class Folder : object
    {
        
        private string DateField;
        
        private ServiceReferenceMyPhotosServiceWCF.File[] FilesField;
        
        private int IdField;
        
        private string LocationField;
        
        private string NameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Date
        {
            get
            {
                return this.DateField;
            }
            set
            {
                this.DateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReferenceMyPhotosServiceWCF.File[] Files
        {
            get
            {
                return this.FilesField;
            }
            set
            {
                this.FilesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Location
        {
            get
            {
                return this.LocationField;
            }
            set
            {
                this.LocationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceMyPhotosServiceWCF.IMyPhotos")]
    public interface IMyPhotos
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFile/GetFile", ReplyAction="http://tempuri.org/InterfaceFile/GetFileResponse")]
        System.Threading.Tasks.Task<ServiceReferenceMyPhotosServiceWCF.File> GetFileAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFile/GetFileName", ReplyAction="http://tempuri.org/InterfaceFile/GetFileNameResponse")]
        System.Threading.Tasks.Task<ServiceReferenceMyPhotosServiceWCF.File> GetFileNameAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFile/GetFilesByFolderId", ReplyAction="http://tempuri.org/InterfaceFile/GetFilesByFolderIdResponse")]
        System.Threading.Tasks.Task<ServiceReferenceMyPhotosServiceWCF.File[]> GetFilesByFolderIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFile/DeleteFile", ReplyAction="http://tempuri.org/InterfaceFile/DeleteFileResponse")]
        System.Threading.Tasks.Task DeleteFileAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFile/SearchInDescAndTags", ReplyAction="http://tempuri.org/InterfaceFile/SearchInDescAndTagsResponse")]
        System.Threading.Tasks.Task<ServiceReferenceMyPhotosServiceWCF.File[]> SearchInDescAndTagsAsync(string text);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFile/SearchInDesc", ReplyAction="http://tempuri.org/InterfaceFile/SearchInDescResponse")]
        System.Threading.Tasks.Task<ServiceReferenceMyPhotosServiceWCF.File[]> SearchInDescAsync(string text);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFile/AddFile", ReplyAction="http://tempuri.org/InterfaceFile/AddFileResponse")]
        System.Threading.Tasks.Task AddFileAsync(string FileName, string FileDesc, string FileType, string FileSize, string FilePath, string FileTags, int FolderId, string FileDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFile/UpdateFile", ReplyAction="http://tempuri.org/InterfaceFile/UpdateFileResponse")]
        System.Threading.Tasks.Task UpdateFileAsync(string selectedFile, string desc, string tags);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFolder/GetFolderId", ReplyAction="http://tempuri.org/InterfaceFolder/GetFolderIdResponse")]
        System.Threading.Tasks.Task<int> GetFolderIdAsync(string folder);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFolder/GetAllFolders", ReplyAction="http://tempuri.org/InterfaceFolder/GetAllFoldersResponse")]
        System.Threading.Tasks.Task<ServiceReferenceMyPhotosServiceWCF.Folder[]> GetAllFoldersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFolder/AddFolder", ReplyAction="http://tempuri.org/InterfaceFolder/AddFolderResponse")]
        System.Threading.Tasks.Task AddFolderAsync(string folderName, string folderLocation, string folderDate);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface IMyPhotosChannel : ServiceReferenceMyPhotosServiceWCF.IMyPhotos, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class MyPhotosClient : System.ServiceModel.ClientBase<ServiceReferenceMyPhotosServiceWCF.IMyPhotos>, ServiceReferenceMyPhotosServiceWCF.IMyPhotos
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public MyPhotosClient() : 
                base(MyPhotosClient.GetDefaultBinding(), MyPhotosClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IMyPhotos.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MyPhotosClient(EndpointConfiguration endpointConfiguration) : 
                base(MyPhotosClient.GetBindingForEndpoint(endpointConfiguration), MyPhotosClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MyPhotosClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(MyPhotosClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MyPhotosClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(MyPhotosClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MyPhotosClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceMyPhotosServiceWCF.File> GetFileAsync(string name)
        {
            return base.Channel.GetFileAsync(name);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceMyPhotosServiceWCF.File> GetFileNameAsync(string name)
        {
            return base.Channel.GetFileNameAsync(name);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceMyPhotosServiceWCF.File[]> GetFilesByFolderIdAsync(int id)
        {
            return base.Channel.GetFilesByFolderIdAsync(id);
        }
        
        public System.Threading.Tasks.Task DeleteFileAsync(string name)
        {
            return base.Channel.DeleteFileAsync(name);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceMyPhotosServiceWCF.File[]> SearchInDescAndTagsAsync(string text)
        {
            return base.Channel.SearchInDescAndTagsAsync(text);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceMyPhotosServiceWCF.File[]> SearchInDescAsync(string text)
        {
            return base.Channel.SearchInDescAsync(text);
        }
        
        public System.Threading.Tasks.Task AddFileAsync(string FileName, string FileDesc, string FileType, string FileSize, string FilePath, string FileTags, int FolderId, string FileDate)
        {
            return base.Channel.AddFileAsync(FileName, FileDesc, FileType, FileSize, FilePath, FileTags, FolderId, FileDate);
        }
        
        public System.Threading.Tasks.Task UpdateFileAsync(string selectedFile, string desc, string tags)
        {
            return base.Channel.UpdateFileAsync(selectedFile, desc, tags);
        }
        
        public System.Threading.Tasks.Task<int> GetFolderIdAsync(string folder)
        {
            return base.Channel.GetFolderIdAsync(folder);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceMyPhotosServiceWCF.Folder[]> GetAllFoldersAsync()
        {
            return base.Channel.GetAllFoldersAsync();
        }
        
        public System.Threading.Tasks.Task AddFolderAsync(string folderName, string folderLocation, string folderDate)
        {
            return base.Channel.AddFolderAsync(folderName, folderLocation, folderDate);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IMyPhotos))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IMyPhotos))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:8000/PC");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return MyPhotosClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IMyPhotos);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return MyPhotosClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IMyPhotos);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IMyPhotos,
        }
    }
}
