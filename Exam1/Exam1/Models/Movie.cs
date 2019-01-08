using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Exam1.Models
{
    public class Movie
    {
        [Key]
        public string Id { get; set; }
        public int Ratio { get; set; }
    }
}
