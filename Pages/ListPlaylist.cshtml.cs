using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using P3DedicApp.Data;
using P3DedicApp.Models;

namespace P3DedicApp
{
    public class ListPlaylistModel : PageModel
    {
        private readonly P3DedicApp.Data.ApplicationDbContext _context;

        public ListPlaylistModel(P3DedicApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Playlist> Playlist { get;set; }

        public async Task OnGetAsync()
        {
            Playlist = await _context.Playlists
                .Include(p => p.User).ToListAsync();
        }
    }
}
