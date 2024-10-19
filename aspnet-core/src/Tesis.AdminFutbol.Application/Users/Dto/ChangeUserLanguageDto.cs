using System.ComponentModel.DataAnnotations;

namespace Tesis.AdminFutbol.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}