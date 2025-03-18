using System.ComponentModel.DataAnnotations;
using EduDriveInformationSystem.Domain.Models.Enums;

namespace EduDriveInformationSystem.Domain.Models.Entities
{
    public class UserModel
    {
        [Key]
        public Guid UserId { get; set; }
        [Required]
        public string UserFirstName { get; set; }
        [Required]
        public string UserLastName { get; set; }
        [Required]
        [EmailAddress]
        public string UserEmail { get; set; }
        [Required]
        [Phone]
        public string UserContactNumber{ get; set; }
        [Required]
        public string UserPassword {  get; set; }
        public UserRoles UserRole { get; set; }


    }
}
