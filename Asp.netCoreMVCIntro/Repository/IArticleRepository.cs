using Asp.netCoreMVCIntro.Models;
using Asp.netCoreMVCIntro.ViewModels;

namespace Asp.netCoreMVCIntro.Repository
{
    public interface IArticleRepository
    {
        void AddArticle(ArticleViewModel article);

        Article UpdateArticle(Article article);

        void DeleteArticle(int Id); 

        Article GetArticleById(int id);

        IEnumerable<Article> GetAllArticles();

        IEnumerable<Tutorial> GetAllTutorials();

        IEnumerable<Article> GetArticlesByTutorialId(int tutorialId);
    }
}
