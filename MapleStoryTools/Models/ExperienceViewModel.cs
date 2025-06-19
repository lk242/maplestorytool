using System;
using System.ComponentModel.DataAnnotations;

namespace MapleStoryTools.Models
{
    public class ExperienceViewModel
    {
        [Required]
        [Display(Name = "Start Experience")]
        public int StartExperience { get; set; }

        [Required]
        [Display(Name = "Start Time")]
        public DateTime StartTime { get; set; }

        [Required]
        [Display(Name = "End Experience")]
        public int EndExperience { get; set; }

        [Required]
        [Display(Name = "End Time")]
        public DateTime EndTime { get; set; }

        public int ExperienceGained { get; set; }
        public double Minutes { get; set; }
        public double ExperiencePerMinute { get; set; }
    }
}
