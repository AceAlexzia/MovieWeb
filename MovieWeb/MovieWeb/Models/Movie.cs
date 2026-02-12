using System.ComponentModel.DataAnnotations;

namespace MovieWeb.Models
{
    public class Movie
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "Movie tilte cannot blank")]
        public string title { get; set; }
        public string description { get; set; }
        public string imgUrl { get; set; }
        [Required, Range(0.0f, 10.0f)]
        public float rating { get; set; }
    }
}
