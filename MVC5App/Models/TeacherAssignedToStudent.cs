using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC5App.Models
{
    public class TeacherAssignedToStudent
    {
        [Key]
        public int Id { get; set; }
        public int StudentId { get; set; }

        public int TeacherId { get; set; }
    }
}