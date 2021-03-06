﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using MEL.Entities.Reference;

namespace MEL.Entities.Programs
{
    public class Program : BaseEntity
    {
        public Program()
        {
            this.Groups = new HashSet<Group>();
            this.ProgramAssessments = new HashSet<ProgramAssessment>();
        }

        [Key]
        [Required(ErrorMessage = "The {0} field is required.")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Program")]
        [Column(Order = 0)]
        public int ProgramId { get; set; }

        [Required(ErrorMessage = "The {0} field is required.")]
        [MaxLength(150)]
        [Display(Name = "Program")]
        [Column(Order = 1)]
        public string ProgramName { get; set; }

        [Display(Name = "Program Type")]
        [Column(Order = 2)]
        public int? RefProgramTypeId { get; set; }

        [MaxLength(255)]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Description")]
        [Column(Order = 3)]
        public string Description { get; set; }
        
        [Display(Name = "Duration")]
        [Column(Order = 4)]
        public int? Max { get; set; }

        [Display(Name = "Min Attendance")]
        [Column(Order = 5)]
        public int? Min { get; set; }

        [Display(Name = "Attendance unit")]
        [Column(Order = 6)]
        public int? RefAttendanceUnitId { get; set; }

        [Display(Name = "Has Assessment?")]
        [Column(Order = 7)]
        public bool HasAssessment { get; set; } = false;

        [Display(Name = "Display as Marks?")]
        [Column(Order = 8)]
        public bool DisplayMarks { get; set; } = false;

        [Display(Name = "Organization Type")]
        [Column(Order = 9)]
        public int? RefOrganizationTypeId { get; set; }

        // Navigation properties
        [ForeignKey("RefProgramTypeId")]
        [Display(Name = "Program Type")]
        public virtual RefProgramType ProgramTypes { get; set; }

        [ForeignKey("RefAttendanceUnitId")]
        [Display(Name = "Attendance unit")]
        public virtual RefAttendanceUnit AttendanceUnits { get; set; }

        [ForeignKey("RefOrganizationTypeId")]
        [Display(Name = "Organization Type")]
        public virtual RefOrganizationType OrganizationTypes { get; set; }

        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<ProgramAssessment> ProgramAssessments { get; set; }
    }
}
