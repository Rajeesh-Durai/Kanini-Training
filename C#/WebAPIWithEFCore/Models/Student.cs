﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPIWithEFCore.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudId { get; set; }
        public string Name { get; set; }=string.Empty;
        public string City { get; set; }=string.Empty;
        public int Pin { get; set; }
    }
}
