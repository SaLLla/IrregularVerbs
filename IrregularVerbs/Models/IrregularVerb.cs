using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IrregularVerbs.Models
{
    [MetadataType(typeof(IrregularVerbMetadata))]
    public partial class IrregularVerb
    {
    }
    
    
    public class IrregularVerbMetadata
    {
        [Required (ErrorMessage="Поле должно быть заполнено")]
        [DisplayName("Present Simple")]
        public string PresentSimple { get; set; }

        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [DisplayName("Past Simple")]
        public string PastSimple { get; set; }

        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [DisplayName("Past Participle")]
        public string PastParticiple { get; set; }

        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [DisplayName("Перевод")]
        public string Translate { get; set; }

        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [DisplayName("Номер урока")]
        [Range(1, 100, ErrorMessage="Введите от 1 до 100")]
        public int LessonNumber { get; set; }
    }
}