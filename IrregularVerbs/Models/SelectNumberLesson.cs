using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IrregularVerbs.Models
{
    public class SelectNumberLesson
    {
        public string NameDropDownList { get; set; }
        public IEnumerable<SelectListItem> LessonNumber { get; set; }
    }
}