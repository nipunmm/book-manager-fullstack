using System.ComponentModel.DataAnnotations;

namespace book_manager_backend.Models
{
    public class Book
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Title must be 2-100 characters")]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Author { get; set; } = string.Empty;

        [Required]
        public string ISBN { get; set; } = string.Empty;

        [Required]
        public DateTime PublicationDate { get; set; }

    }
}
