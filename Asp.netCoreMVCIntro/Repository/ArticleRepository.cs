using Asp.netCoreMVCIntro.Context;
using Asp.netCoreMVCIntro.Models;
using Asp.netCoreMVCIntro.ViewModels;

namespace Asp.netCoreMVCIntro.Repository
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly TutorialDbContext _context;
        public ArticleRepository(TutorialDbContext context)
        {
            _context = context;
        }
        //public Article AddArticle(Article article)
        //{
        //    throw new NotImplementedException();
        //}
        public void AddArticle(ArticleViewModel article)
        {
            var newArticle = new Article()
            {
                ArticleTitle = article.ArticleTitle,
                ArticleContent = article.ArticleContent,
                TutorialId = article.TutorialId
            };

            _context.Articles.Add(newArticle);
            _context.SaveChanges();
        }


        public Article DeleteArticle(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Article> GetAllArticles()
        {
            return _context.Articles;
        }

        public Article GetArticle(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tutorial> GetAllTutorials()
        {
            return _context.Tutorials;
        }

        public IEnumerable<Article> GetArticlesByTutorialId(int tutorialId)
        {
            return _context.Articles.Where(a => a.TutorialId == tutorialId).ToList();
        }

        public Article UpdateArticle(Article article)
        {
            throw new NotImplementedException();
        }

    }
}
