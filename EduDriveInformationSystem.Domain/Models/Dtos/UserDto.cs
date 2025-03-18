using EduDriveInformationSystem.Domain.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace EduDriveInformationSystem.Domain.Models.Dtos
{
    public class UserDto
    {
        public Guid UserId { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserEmail { get; set; }
        public string UserContactNumber { get; set; }
        public UserRoles UserRole { get; set; }

    }
}
