﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CleanArchitecture.Core.Entities
{
    public class Course
    {
        public Course()
        {
            this.Students = new HashSet<Student>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        public int Credits { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}