using Asp.netCoreMVCIntro.Models;
using Asp.netCoreMVCIntro.ViewModels;
using Asp.netCoreMVCIntro.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Asp.netCoreMVCIntro.Controllers
{
    public class TutorialController : Controller
    {
        private readonly ITutorialRepository _tutorialRepository;

        public TutorialController(ITutorialRepository tutorialRepository)
        {
            _tutorialRepository = tutorialRepository;
        }

        public IActionResult Index()
        {
            var tutorials = _tutorialRepository.GetAllTutorials();
            return View(tutorials);
        }

        [HttpGet]
        public IActionResult CreateTutorial()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateTutorial(Tutorial tutorial)
        {
            if(!ModelState.IsValid)
            {
                return View(tutorial);
            }
            Tutorial newTutorial = _tutorialRepository.Add(tutorial);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditTutorial(int Id)
        {
            Tutorial tutorial = _tutorialRepository.GetTutorial(Id);
            return View(tutorial);
        }

        [HttpPost]
        public IActionResult EditTutorial(Tutorial modifiedData)
        {
            Tutorial tutorial = _tutorialRepository.GetTutorial(modifiedData.Id);
            tutorial.Name = modifiedData.Name;
            tutorial.Description = modifiedData.Description;
            Tutorial updatedTutorial = _tutorialRepository.Update(tutorial);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteTutorial(int Id) 
        { 
            Tutorial deletedTutorial = _tutorialRepository.Delete(Id);
            return RedirectToAction("Index");
        }
    }
}
