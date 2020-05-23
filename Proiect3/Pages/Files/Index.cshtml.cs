using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Proiect3.Models;
using ServiceReferenceMyPhotosServiceWCF;

namespace Proiect3.Pages.Files
{
    public class IndexModel : PageModel
    {
        MyPhotosClient client = new MyPhotosClient();
        public List<FileDTO> Files { get; set; }

        public IndexModel()
        {
            Files = new List<FileDTO>();

        }
        public async Task OnGetAsync(int? id, string sortOrder)
        {
            if (!id.HasValue)
                return;
            var items = await client.GetFilesByFolderIdAsync(id.Value);
            switch (sortOrder)
            {
                case "Name":
                    foreach (var cc in items)
                    {
                        FileDTO files = new FileDTO();
                        files.FolderId = cc.FolderId;
                        files.FileName = cc.FileName;
                        files.FileDesc = cc.FileDesc;
                        files.FilePath = cc.FilePath;
                        files.FileTags = cc.FileTags;
                        files.FileDate = cc.FileDate;
                        Files.Add(files);
                    }
                    break;
                default:
                    items.OrderBy(s => s.FileID);
                    break;
            }
        }
    }
}