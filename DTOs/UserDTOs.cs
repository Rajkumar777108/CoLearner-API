using System.ComponentModel.DataAnnotations;

namespace CoLearner.API.DTOs
{
    public class UserDTOs
    {
        [Required]
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }  

        [Required]
        [StringLength(8,MinimumLength=4, ErrorMessage="Please Specify Password between 4 to 8 charectors")]
        public string Password { get; set; }
    }
}