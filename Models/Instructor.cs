using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace PARProject.Model;
public class Instructor
{
    public int InstructorId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<Course> Courses {get; set;} 
}