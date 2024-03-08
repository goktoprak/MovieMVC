using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieWeb.Models
{
    public class Movie
    {
        [Key]
        [DisplayName("MovieID")]
        public int MovieID { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        [DisplayName("Title")]
        public required string Title { get; set; }
    }
}