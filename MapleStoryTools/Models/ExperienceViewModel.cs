using System;
using System.ComponentModel.DataAnnotations;

namespace MapleStoryTools.Models
{
    public class ExperienceViewModel
    {
        [Required]
        [Display(Name = "起始經驗值")]
        public int StartExperience { get; set; }

        [Required]
        [Display(Name = "起始時間")]
        public DateTime StartTime { get; set; }

        [Required]
        [Display(Name = "結束經驗值")]
        public int EndExperience { get; set; }

        [Required]
        [Display(Name = "結束時間")]
        public DateTime EndTime { get; set; }

        public int ExperienceGained { get; set; }
        public double Minutes { get; set; }
        public double ExperiencePerMinute { get; set; }
    }
}
