using Asp.netCoreMVCIntro.Context;
using Asp.netCoreMVCIntro.Models;
using Asp.netCoreMVCIntro.Repository;
using Asp.netCoreMVCIntro.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Asp.netCoreMVCIntro.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleRepository _articleRepository;
        public ArticleController(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public IActionResult Index() 
        {
            IEnumerable<Article> articles = _articleRepository.GetAllArticles();
            return View(articles);        
        }

        [HttpGet]
        public IActionResult AddNewArticle()
        {
            var tutorials = _articleRepository.GetAllTutorials();
            ViewBag.Tutorials = new SelectList(tutorials, "Id", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult AddArticle(ArticleViewModel article)
        {
            if(!ModelState.IsValid) 
            {
                var tutorials = _articleRepository.GetAllTutorials();
                ViewBag.Tutorials = new SelectList(tutorials, "TutorialId", "Name");
                return View(article);
            }

            _articleRepository.AddArticle(article);
            return RedirectToAction("Index");
        }

        public IActionResult DisplayArticles(int id)
        {
            IEnumerable<Article> articles = _articleRepository.GetArticlesByTutorialId(id);
            return View(articles);
        }
    }
}
