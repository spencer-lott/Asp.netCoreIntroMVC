using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace Asp.netCoreMVCIntro.Models
{
    public class Article
    {
        public int ArticleId { get; set; }

        [Required(ErrorMessage = "Please enter arcticle title")]
        public string ArticleTitle { get; set; }

        [Required(ErrorMessage = "Please enter article content")]
        public string ArticleContent { get; set; }

        //Setup the relationship with Tutorial model/table
        public int TutorialId { get; set; } //Foreign Key

        public Tutorial Tutorial { get; set; } //Reference navigation property

    }
}
