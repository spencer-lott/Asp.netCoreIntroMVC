using Asp.netCoreMVCIntro.Models;
using Asp.netCoreMVCIntro.ViewModels;

namespace Asp.netCoreMVCIntro.Repository
{
    public interface IArticleRepository
    {
        void AddArticle(ArticleViewModel article);
        //Article AddArticle(Article article);

        Article UpdateArticle(Article article);

        Article DeleteArticle(int Id); 

        Article GetArticle(int id);

        IEnumerable<Article> GetAllArticles();

        IEnumerable<Tutorial> GetAllTutorials();

        IEnumerable<Article> GetArticlesByTutorialId(int tutorialId);
    }
}
