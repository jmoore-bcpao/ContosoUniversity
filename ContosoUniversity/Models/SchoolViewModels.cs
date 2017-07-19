using System;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class SchoolViewModels
    {
        public class EnrollmentDateGroup
        {
            [DataType(DataType.Date)]
            public DateTime? EnrollmentDate { get; set; }

            public int StudentCount { get; set; }
        }
    }
}
