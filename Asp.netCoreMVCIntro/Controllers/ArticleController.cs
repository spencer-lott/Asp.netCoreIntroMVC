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

        //List of all articles
        public IActionResult Index() 
        {
            IEnumerable<Article> articles = _articleRepository.GetAllArticles();
            return View(articles);        
        }

        //List of all articles for the specified tutorial 
        public IActionResult DisplayArticles(int id)
        {
            IEnumerable<Article> articles = _articleRepository.GetArticlesByTutorialId(id);
            return View(articles);
        }

        //List of all articles for the specified tutorial 
        public IActionResult DisplayArticlesByTutorialId(int id)
        {
            IEnumerable<Article> articles = _articleRepository.GetArticlesByTutorialId(id);
            return View(articles);
        }

        public IActionResult GetArticleByArticleId(int id)
        {
            Article article = _articleRepository.GetArticleById(id);
            return View(article);
        }

        //Add Article Get and Post
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

        //Edit Article Get and Post
        [HttpGet]
        public IActionResult EditArticle(int id)
        {
            Article article = _articleRepository.GetArticleById(id);
            var data = new ArticleViewModel()
            {
                ArticleTitle = article.ArticleTitle,
                ArticleContent = article.ArticleContent
            };
            var tutorials = _articleRepository.GetAllTutorials();
            ViewBag.Tutorials = new SelectList(tutorials, "Id", "Name");
            return View(data);
        }

        [HttpPost]
        public IActionResult EditArticle(ArticleViewModel modifiedData)
        {
            if(!ModelState.IsValid) 
            {
                return View(modifiedData);
            }
            Article article = _articleRepository.GetArticleById(modifiedData.Id);
            article.ArticleTitle = modifiedData.ArticleTitle;
            article.ArticleContent = modifiedData.ArticleContent;
            _articleRepository.UpdateArticle(article);
            return RedirectToAction("Index");

        }

    }
}
