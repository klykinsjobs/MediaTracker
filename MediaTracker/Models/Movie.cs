using System.ComponentModel.DataAnnotations;

namespace MediaTracker.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string? Title { get; set; }

        [StringLength(100, MinimumLength = 0)]
        public string? Genre { get; set; }

        public bool Finished { get; set; }

        [Range(1, 10)]
        public int? Rating { get; set; }

        [StringLength(1000, MinimumLength = 0)]
        public string? Notes { get; set; }
    }
}
