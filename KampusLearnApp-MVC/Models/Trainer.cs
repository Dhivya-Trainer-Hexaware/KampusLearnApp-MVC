using System.ComponentModel.DataAnnotations;

namespace KampusLearnApp_MVC.Models
{
    public class Trainer
    {
        public int TrainerId { get; set; }
        [Required(ErrorMessage ="Name can't be empty")]
        public string TrainerName { get; set; }
        [Required]
        public string Skills { get; set; }
        [Required]
        public int YearsOfExperience { get; set; }
        [Required]
        public long Contact { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
