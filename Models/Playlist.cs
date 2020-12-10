using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace P3DedicApp.Models
{
    public class Playlist
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [ForeignKey("UserId")]
        public IdentityUser User { get; set; }
        [Required]
        public string UserId { get; set; }
        public ICollection<Song> Songs { get; set; }
    }
}
