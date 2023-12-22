using Asp.netCoreMVCIntro.Context;
using Asp.netCoreMVCIntro.Models;
using Microsoft.EntityFrameworkCore;

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
            _context.Tutorials.Add(tutorial);
            _context.SaveChanges();
            return tutorial;
        }

        public Tutorial Delete(int Id)
        {
            Tutorial tutorial = _context.Tutorials.Find(Id);
            if (tutorial != null) 
            { 
                _context.Tutorials.Remove(tutorial);
                _context.SaveChanges();
            }
            return tutorial;
        }

        public IEnumerable<Tutorial> GetAllTutorials()
        {
            return  _context.Tutorials.ToList();
        }
        //public async Task<IEnumerable<Tutorial>> GetAllTutorials()
        //{
        //    return await _context.Tutorials.ToListAsync();
        //}

        public Tutorial GetTutorial(int Id)
        {
            return _context.Tutorials.Find(Id);
        }
        //public async Task<Tutorial> GetTutorial(int Id)
        //{
        //    return await _context.Tutorials.FindAsync(Id);
        //}

        public Tutorial Update(Tutorial tutorialModified)
        {
            _context.Update(tutorialModified);
            _context.SaveChanges();
            return tutorialModified;
        }
    }
}
