using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrregularVerbs.Models
{
    public class ManagerDatabase
    {
        private IrregularVerbsDbEntities db; 

        public ManagerDatabase()
        {
            db = new IrregularVerbsDbEntities();
        }

        public IEnumerable<IrregularVerb> GetIrregularVerbs()
        {
            return db.IrregularVerbs;
        }

        public IEnumerable<IrregularVerb> GetIrregularVerbs(int lessonNumber)
        {
            return db.IrregularVerbs.Where(v => v.LessonNumber == lessonNumber);
        }

        public IrregularVerb GetIrregularVerb(int id)
        {
            return db.IrregularVerbs.SingleOrDefault(v => v.Id == id);
        }



        public void EditVerb(IrregularVerb obj)
        {
            var verb = db.IrregularVerbs.FirstOrDefault(v => v.Id == obj.Id);

            verb.PresentSimple = obj.PresentSimple;
            verb.PastSimple = obj.PastSimple;
            verb.PastParticiple = obj.PastParticiple;
            verb.LessonNumber = obj.LessonNumber;
            verb.Translate = obj.Translate;

            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var verb = db.IrregularVerbs.FirstOrDefault(v => v.Id == id);
            db.IrregularVerbs.DeleteObject(verb);

            db.SaveChanges();
        }

        internal void AddVerb(IrregularVerb obj)
        {
            db.IrregularVerbs.AddObject(obj);

            db.SaveChanges();
        }

        public IEnumerable<int> GetUniqueLessonNumber()
        {
            return GetIrregularVerbs().Select(x => x.LessonNumber).Distinct();
        }
    }
}