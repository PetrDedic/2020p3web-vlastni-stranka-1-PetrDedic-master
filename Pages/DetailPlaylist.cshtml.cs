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
    public class DetailPlaylistModel : PageModel
    {
        private readonly P3DedicApp.Data.ApplicationDbContext _context;

        public DetailPlaylistModel(P3DedicApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Playlist Playlist { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Playlist = await _context.Playlists
                .Include(p => p.User).FirstOrDefaultAsync(m => m.Id == id);

            if (Playlist == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
