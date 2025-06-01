﻿namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string FirstMidName { get; set; }
        public string LastName { get; set; }

        public DateTime EnrollmentDate { get; set; } = DateTime.Now;

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
