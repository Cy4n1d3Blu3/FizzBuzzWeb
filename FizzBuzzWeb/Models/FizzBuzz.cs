using System.ComponentModel.DataAnnotations;

namespace FizzBuzzWeb.Models
{
    public class FizzBuzz
    {
        [Display(Name = "NUMBER:")]
        [Required, Range(1, 1000, ErrorMessage = "Required value is from range {1}-{2}.")]
        public int? Number { get; set; }
    }
}
