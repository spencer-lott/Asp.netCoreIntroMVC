using Asp.netCoreMVCIntro.Models;

namespace Asp.netCoreMVCIntro.Repository
{
    public class TutorialRepository : ITutorialRepository
    {
        private List<Tutorial> _tutorials;

        public TutorialRepository() 
        {
            //Temporarily we are going to create mock data
            _tutorials = new List<Tutorial>
            {
                new Tutorial{ Id = 1, Name ="C#", Description ="C# tutorial"},
                new Tutorial{ Id = 2, Name ="Asp.net core", Description ="Asp.net tutorial"}
            };

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
            return _tutorials;
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
