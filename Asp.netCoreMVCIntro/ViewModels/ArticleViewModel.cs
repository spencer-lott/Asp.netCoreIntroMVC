using Asp.netCoreMVCIntro.Migrations;
using Asp.netCoreMVCIntro.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Asp.netCoreMVCIntro.ViewModels
{
    public class ArticleViewModel
    {
        public ArticleViewModel() 
        {
            tutorials = new List<Tutorial>();
        }

        [Required(ErrorMessage = "Please enter article title")]
        [DisplayName("Please enter article title")]
        public string ArticleTitle { get; set; }

        [Required(ErrorMessage = "Please enter article content")]
        [DisplayName("Please enter article content")]
        public string ArticleContent { get; set; }

        public int TutorialId { get; set; }

        public List<Tutorial> tutorials { get; set; }


    }
}
