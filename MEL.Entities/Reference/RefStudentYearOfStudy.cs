﻿using MEL.Entities.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MEL.Entities.Reference
{
    public class RefStudentYearOfStudy
    {
        public RefStudentYearOfStudy()
        {
            this.Students = new HashSet<Student>();
        }

        [Key]
        [Required(ErrorMessage = "The {0} field is required.")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Year of Study Id")]
        [Column(Order = 0)]
        public int RefStudentYearOfStudyId { get; set; }

        [Required(ErrorMessage = "The {0} field is required.")]
        [MaxLength(25)]
        [Display(Name = "Year of Study Code")]
        [Column(Order = 1)]
        public string StudentYearOfStudyCode { get; set; }

        [Required(ErrorMessage = "The {0} field is required.")]
        [MaxLength(150)]
        [Display(Name = "Year of Study")]
        [Column(Order = 2)]
        public string StudentYearOfStudy { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
