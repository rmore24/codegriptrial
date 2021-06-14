using System.ComponentModel.DataAnnotations;

namespace TrialTemplate.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}