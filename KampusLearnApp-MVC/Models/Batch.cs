using System;
using System.ComponentModel.DataAnnotations;

namespace KampusLearnApp_MVC.Models
{
    public class Batch
    {
        [Key]
        public int BatchNo { get; set; }
        public string BatchName  { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int TrainerId { get; set; }
        public Trainer Trainer { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
