/// <summary>
/// Represents a student who wants to join/leave different courses
/// </summary>
/// <param name="name">Name of the student, must be unique</param>
class Student(string name)
{
    public string Name = name;
    public List<Course> Courses = new();

    /// <summary>
    /// Tries to enroll a student into a course
    /// </summary>
    /// <param name="course">Course to enroll into</param>
    /// <returns>true if the student is/gets enrolled, false if not</returns>
    public bool Join(Course course)
    {
        return course.Enroll(this);
    }

    /// <summary>
    /// Tries to remove a student from a course
    /// </summary>
    /// <param name="course">Course to leave</param>
    /// <returns>true if the student is removed, false if the student wasn't enrolled to begin with</returns>
    public bool Leave(Course course)
    {
        return course.Remove(this);
    }

    /// <summary>
    /// Prints the students course schedule
    /// </summary>
    public void Schedule()
    {
        Console.WriteLine($"\nSchema för {Name}:");
        Courses.ForEach(c => Console.WriteLine(c.Name));
    }

    /// <summary>
    /// Returns the students name
    /// </summary>
    /// <returns>Name</returns>
    public override string ToString()
    {
        return Name;
    }
}
