using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IrregularVerbs.Models
{
    public class TrainingVerb
    {
        public string PresentSimpleHide { get; set; }
        public string PastSimpleHide { get; set; }
        public string PastParticipleHide { get; set; }

        [DisplayName("Перевод")]
        public string Translate { get; set; }

        [DisplayName("Present Simple")]
        [Compare("PresentSimpleHide", ErrorMessage="Неверно!")]
        public string PresentSimpleShow { get; set; }

        [DisplayName("Past Simple")]
        [Compare("PastSimpleHide", ErrorMessage = "Неверно!")]
        public string PastSimpleShow { get; set; }

        [DisplayName("Past Participle")]
        [Compare("PastParticipleHide", ErrorMessage = "Неверно!")]
        public string PastParticipleShow { get; set; }

        public int NumberVerb { get; set; }
        public int AmountOfWords { get; set; }
    }
}