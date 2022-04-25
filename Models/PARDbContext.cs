using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace PARProject.Models
{
	public class PARDbContext : DbContext
	{
		public PARDbContext (DbContextOptions<PARDbContext> options)
			: base(options)
		{
		}
        public DbSet<AcademicYearPeriod> AcademicYearPeriods {get; set;}
        public DbSet<Assessment> Assessments {get; set; }
        public DbSet<Course> Courses {get; set; }
        public DbSet<CourseCoordinator> CourseCoordinators {get; set; }
        public DbSet <CourseLearningOutcome> CourseLearningOutcomes {get; set; }
        public DbSet <Instructor> Instructors {get; set; }
        public DbSet <Measure> Measures {get; set; }
        public DbSet <Privilege> Privileges {get; set; }
        public DbSet <Profile> Profiles {get; set; }
        public DbSet <Rating> Ratings {get; set; }
        public DbSet <Role> Roles {get; set; }
        public DbSet <StudentOutcome> StudentOutcomes {get; set; }
        public DbSet <User> Users {get; set; }
	}
}