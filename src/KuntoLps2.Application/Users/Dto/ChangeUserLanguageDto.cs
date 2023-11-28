using System.ComponentModel.DataAnnotations;

namespace KuntoLps2.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}