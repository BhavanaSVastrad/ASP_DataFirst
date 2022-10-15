
using System.ComponentModel.DataAnnotations;



namespace ASP_First.Models
{
    public partial class Registration
    {
        [Key]
        
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter the username")]
        public string? Username { get; set; }
        [Required(ErrorMessage = "Enter the useremail")]
        public string? Useremail { get; set; }
        [Required(ErrorMessage = "Enter the password")]
        public string? Password { get; set; }
        [Required(ErrorMessage = "Enter the mobile number")]
        public string? Mobile { get; set; }
    }
}
