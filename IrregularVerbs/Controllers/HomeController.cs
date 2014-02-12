using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using IrregularVerbs.Models;

namespace IrregularVerbs.Controllers
{
    public class HomeController : Controller
    {
        private readonly ManagerDatabase _db = new ManagerDatabase();
        private static List<IrregularVerb> _verbs = new List<IrregularVerb>();

        public ActionResult ListOfWords()
        {
            ViewBag.IrregularVerbs = _db.GetIrregularVerbs();
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var verb = _db.GetIrregularVerb(id);
            return View(verb);
        }

        [HttpPost]
        public ActionResult Edit(IrregularVerb obj)
        {
            _db.EditVerb(obj);
            return RedirectToAction("ListOfWords");
        }

        public ActionResult Delete(int id)
        {
            _db.Delete(id);
            return RedirectToAction("ListOfWords");
        }

        [HttpGet]
        public ActionResult AddVerb()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddVerb(IrregularVerb obj)
        {
            _db.AddVerb(obj);
            return RedirectToAction("ListOfWords");
        }

        public ActionResult SelectNumberLesson()
        {
            var model = new SelectNumberLesson
            {
                NameDropDownList = "selectLessonNamber",
                LessonNumber = from lessonNumber in _db.GetUniqueLessonNumber()
                    select new SelectListItem {Text = lessonNumber.ToString(), Value = lessonNumber.ToString()}
            };

            return View(model);
        }

        public ActionResult ShowWordsSelectedLesson(int lessonNumber)
        {
            var irregularVerbs = _db.GetIrregularVerbs(lessonNumber).ToList();
            _verbs = irregularVerbs;
            return View(irregularVerbs);
        }

        public ActionResult TrainingVerb(int numberVerb)
        {
            if (numberVerb == 0)
                RandomOrderVerbs(_verbs);

            if (numberVerb == _verbs.Count)
            {
                return View("Congratulation");
            }

            var trainingVerb = new TrainingVerb
            {
                Translate = _verbs[numberVerb].Translate,
                NumberVerb = numberVerb + 1,
                AmountOfWords = _verbs.Count,
                PresentSimpleHide = _verbs[numberVerb].PresentSimple,
                PastSimpleHide = _verbs[numberVerb].PastSimple,
                PastParticipleHide = _verbs[numberVerb].PastParticiple
            };

            return View(trainingVerb);
        }

        private static void RandomOrderVerbs(IList<IrregularVerb> lst)
        {
            var rand = new Random();

            for (int i = 0; i < lst.Count; i++)
            {
                var irand = rand.Next(lst.Count);
                var irregularVerb = lst[0];
                lst[0] = lst[irand];
                lst[irand] = irregularVerb;
            }
        }
    }
}
