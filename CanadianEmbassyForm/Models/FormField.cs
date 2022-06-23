using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CanadianEmbassyForm.Models
{
    public class FormField
    {
        [Key]
        [Display(Name = "Id")]
        public int? Id { get; set; }




        [Display(Name = "Given Name")]
        public string Name { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Age")]
        public int Age { get; set; }

        [Display(Name = "Date of birth")]
        [DataType(DataType.DateTime)]
        public DateTime DOB { get; set; }

    }
}
