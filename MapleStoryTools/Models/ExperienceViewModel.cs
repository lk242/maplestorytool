using System;
using System.ComponentModel.DataAnnotations;

namespace MapleStoryTools.Models
{
    public class ExperienceViewModel
    {
        [Required]
        [Display(Name = "�_�l�g���")]
        public int StartExperience { get; set; }

        [Required]
        [Display(Name = "�_�l�ɶ�")]
        public DateTime StartTime { get; set; }

        [Required]
        [Display(Name = "�����g���")]
        public int EndExperience { get; set; }

        [Required]
        [Display(Name = "�����ɶ�")]
        public DateTime EndTime { get; set; }

        public int ExperienceGained { get; set; }
        public double Minutes { get; set; }
        public double ExperiencePerMinute { get; set; }
    }
}
