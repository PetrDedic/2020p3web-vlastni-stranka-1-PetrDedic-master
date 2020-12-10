using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace P3DedicApp.Models
{
    public class Song
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("PlaylistId")]
        public Playlist Playlist { get; set; }
        [Required]
        public int PlaylistId { get; set; }
        [Required]
        public string Interpret { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
