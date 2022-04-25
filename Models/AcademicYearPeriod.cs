using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PARProject.Models;

public enum Name
{
    
} Semester
{
    FALL,
    SPRING,
}

public class AcademicYearPeriod
{
    public int Year { get; set; }
    public Semester Semester { get; set; }
   
}
