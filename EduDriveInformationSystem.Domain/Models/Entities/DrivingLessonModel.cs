using System.ComponentModel.DataAnnotations;

namespace EduDriveInformationSystem.Domain.Models.Entities
{
    public class DrivingLessonModel
    {
        [Key]
        [Required]
        public int LessonId {  get; set; }
        public Guid InstructorId { get; set; } 

        public DateTime LessonDate { get; set; }  
        public TimeSpan LessonDuration { get; set; } 

        public string LessonType { get; set; } 

        public string LessonNotes { get; set; }  // Optional notes or feedback from the instructor

        public string LessonStatus { get; set; }  // Lesson status (e.g., "Completed", "Pending")
    }
}
