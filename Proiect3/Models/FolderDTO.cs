using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Proiect3.Models
{
    [DataContract(IsReference = true)]
    public class FolderDTO
    {
        public FolderDTO()
        {
            this.Files = new List<FileDTO>();
        }

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Location { get; set; }

        [DataMember]
        public string Date { get; set; }

        [DataMember]
        public virtual List<FileDTO> Files { get; set; }

    }
}
