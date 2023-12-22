using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Asp.netCoreMVCIntro.Models
{
    public class Tutorial
    {
        public int Id { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z]+[ a-zA-Z_]*$", ErrorMessage = "Please enter text")]
        [DisplayName("Tutorial Name")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Tutorial Description")]
        public string Description { get; set; }

        //Relationship
        public List<Article> Articles { get; set; }

    }
}
