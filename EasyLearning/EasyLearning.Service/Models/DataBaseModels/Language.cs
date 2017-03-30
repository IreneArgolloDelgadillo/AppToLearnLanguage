using System.ComponentModel.DataAnnotations;

namespace EasyLearning.Service.Models.DataBaseModels
{
    public class Language
    {
        public int LanguageId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Code { get; set; }
    }
}