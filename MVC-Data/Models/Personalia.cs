using System.ComponentModel.DataAnnotations;

namespace MVC_Data.Models
{
    public class Personalia
    {
        [Key]
        public string SocialSn { get; set; }

        [Required]
        public string Length { get; set; }

        [Required]
        public string Weight { get; set; }

        [Required]
        public string EyeColour { get; set; }
    }
}
