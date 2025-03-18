using System.ComponentModel.DataAnnotations;
using EduDriveInformationSystem.Domain.Models.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EduDriveInformationSystem.Domain.Models.Entities
{
    public class ClientModel
    {
        [Key]
        [Required]
        public Guid ClientId { get; set; }
        [Required]
        public string ClientFirstName {  get; set; }
        [Required]
        public string ClientLastName { get; set; }
        [Required]
        public string ClientGender { get; set; }
        [Required]
        public string ClientIDNumber{ get; set; }
        [Required]
        public string ClientAddress { get; set; }
        [Required]
        public string ClientCity { get; set; }
        [Required]
        public string ClientEmailAddress {  get; set; }
        [Required]
        public string ClientPhoneNumber {  get; set; }
        [Required]
        public string ClientEmergencyContact {  get; set; }
        [Required]
        public ClientStatus ClientStatus { get; set; }

    }

}
