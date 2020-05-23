using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Proiect3.Models
{
    [DataContract(IsReference = true)]
    public class FileDTO
    {
        [DataMember]
        public int FileID { get; set; }
        [DataMember]
        public string FileName { get; set; }
        [DataMember]
        public string FileDesc { get; set; }
        [DataMember]
        public string FileType { get; set; }
        [DataMember]
        public string FileSize { get; set; }
        [DataMember]
        public string FilePath { get; set; }
        [DataMember]
        public string FileTags { get; set; }
        [DataMember]
        public string FileDate { get; set; }
        [DataMember]
        public int FolderId { get; set; }
        [DataMember]
        public virtual FolderDTO Folder { get; set; }
    }
}
