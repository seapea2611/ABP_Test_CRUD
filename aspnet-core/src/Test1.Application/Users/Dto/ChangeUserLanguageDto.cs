using System.ComponentModel.DataAnnotations;

namespace Test1.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}