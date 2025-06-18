using System;
using System.ComponentModel.DataAnnotations;
using BookApp.Utilities;


namespace BookApp.Models
{
    public class Book
    {
        [Required(ErrorMessage = "ISBN is required.")]
        public int Isbn { get; set; }

        [Required(ErrorMessage = "Book name is required.")]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "Book name must be between 1 and 20 characters.")]
        public string BookName { get; set; }

        [Required(ErrorMessage = "Author name is required.")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Author name must be between 1 and 50 characters.")]
        public string AuthorName { get; set; }

        [Required(ErrorMessage = "Published date is required.")]
        [NoFutureDate(ErrorMessage = "Published date cannot be in the future.")]
        public DateTime PublishedDate { get; set; }

        [Required(ErrorMessage = "Book URL is required.")]
        [Url(ErrorMessage = "Please enter a valid URL.")]
        public string BookUrl { get; set; }
    }
}
