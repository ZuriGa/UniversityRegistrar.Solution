namespace UniversityRegistrar.Models
{
  public class CourseDepartment
  {
    public int CourseDepartmentId { get; set; }
    public int CourseId { get; set; }
    public int DepartmentId { get; set; }
    public Department Department { get; set; }
  }
}