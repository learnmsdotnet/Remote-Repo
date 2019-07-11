using System.ComponentModel.DataAnnotations;

namespace LearnWebProject.Model
{
    public class Customer
    {
        //Ref: https://www.c-sharpcorner.com/article/developing-models-in-Asp-Net-mvc2/

        [Key]
        [Required]
        [Range (1, 100000)]
        public int CustomerId { get; set; }

        [Display(Name = "Customer Name")]
        [Required(ErrorMessage = "Customer Name is mandatory")]
        [StringLength(100, MinimumLength = 5)]
        public string Name { get; set; }

        [Display(Name = "Country")]
        [Required(ErrorMessage = "Customer Geograpthy is mandatory")]
        [StringLength(50)]
        //[Required, DataType(DataType.EmailAddress)] //Built in regular expression for email
        //[Required, RegularExpression("^[0-9]{5}[0-9]{7}-[0-9]{1}$", ErrorMessage = "Incorrect Country")]
        public string Country{ get; set; }
    }
}