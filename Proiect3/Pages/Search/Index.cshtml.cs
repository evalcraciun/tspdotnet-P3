using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Proiect3.Models;
using ServiceReferenceMyPhotosServiceWCF;

namespace Proiect3.Pages.Search
{
    public class IndexModel : PageModel
    {
        MyPhotosClient client = new MyPhotosClient();
        public List<FileDTO> Files { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public IndexModel()
        {
            Files = new List<FileDTO>();
        }
        public async Task OnGetAsync()
        {
            if (!string.IsNullOrEmpty(SearchString))
            {
                var  items = await client.SearchInDescAndTagsAsync(SearchString);
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
            }
            
        }
    }
}