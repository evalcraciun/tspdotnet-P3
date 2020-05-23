using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Proiect3.Models;
using ServiceReferenceMyPhotosServiceWCF;

namespace Proiect3.Pages.Folders
{
    public class IndexModel : PageModel
    {
        MyPhotosClient client = new MyPhotosClient();
        public List<FolderDTO> Folders { get; set; }

        public IndexModel()
        {
            Folders = new List<FolderDTO>();
        }

        public async Task OnGetAsync()
        {
            var folders = await client.GetAllFoldersAsync();
            foreach (var item in folders)
            {
                FolderDTO pd = new FolderDTO();
                FileDTO file = new FileDTO();
                pd.Id = item.Id;
                pd.Name = item.Name;
                pd.Location = item.Location;
                pd.Date = item.Date;
                Folders.Add(pd);
            }
        }
    }
}