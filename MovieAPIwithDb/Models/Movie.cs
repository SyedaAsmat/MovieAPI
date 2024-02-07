using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieAPIwithDb.Models
{
    [Table("Movies")]
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string? MName { get; set; }
        [StringLength(100)]
        public string? StarCast { get; set; }
        [StringLength(100)]
        public string? Director { get; set; }
        [StringLength(100)]
        public string? Producer { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
