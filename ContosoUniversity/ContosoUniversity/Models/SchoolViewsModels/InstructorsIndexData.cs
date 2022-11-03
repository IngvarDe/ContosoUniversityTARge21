﻿using System.Collections.Generic;

namespace ContosoUniversity.Models.SchoolViewsModels
{
    public class InstructorsIndexData
    {
        public IEnumerable<Instructor> Instructors { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Enrollment> Enrollments { get; set; }

    }
}
