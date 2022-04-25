namespace domain.Models;

public class Instructor
{
    public int InstructorId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<Course> Courses {get; set;} 
}