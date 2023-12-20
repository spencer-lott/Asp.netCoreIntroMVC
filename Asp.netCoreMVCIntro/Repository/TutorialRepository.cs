using Asp.netCoreMVCIntro.Context;
using Asp.netCoreMVCIntro.Models;

namespace Asp.netCoreMVCIntro.Repository
{
    public class TutorialRepository : ITutorialRepository
    {
        private readonly TutorialDbContext _context;

        public TutorialRepository(TutorialDbContext context) 
        {
            _context = context;
        }
        public Tutorial Add(Tutorial tutorial)
        {
            throw new NotImplementedException();
        }

        public Tutorial Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tutorial> GetAllTutorials()
        {
            return _context.Tutorials;
        }

        public Tutorial GetTutorial(int Id)
        {
            throw new NotImplementedException();
        }

        public Tutorial Update(Tutorial tutorial)
        {
            throw new NotImplementedException();
        }
    }
}
