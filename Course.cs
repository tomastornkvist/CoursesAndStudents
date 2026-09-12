/// <summary>
/// Handles a course and all enrolled students.
/// </summary>
/// <param name="name">Name of the course</param>
/// <param name="maxSeats">Maximum number of allowed students</param>
class Course(string name, int maxSeats)
{
    public string Name { get; private set; } = name;
    public int MaxSeats { get; private set; } = maxSeats;
    public int StudentCount { get { return Students.Count; } }
    private List<Student> Students = new();

    /// <summary>
    /// Enrolls a student into the course and adds the course to his/her courses
    /// </summary>
    /// <param name="student">Student to be enrolled</param>
    /// <returns>true if the student is enrolled after the call, false if not</returns>
    public bool Enroll(Student student)
    {
        if (Students.Count >= MaxSeats)
        {
            Console.WriteLine($"Kursen är full. {student} kom inte in på {this}.");
            return false;
        }

        // If the student is already enrolled, enrollment is successful.
        if (Students.Exists(s => student.Name.Equals(s.Name)))
        {
            Console.WriteLine($"{student} är redan antagen till {this}.");
            return true;
        }

        Students.Add(student);
        student.Courses.Add(this);
        Console.WriteLine($"{student} ska läsa {this}.");
        return true;
    }

    /// <summary>
    /// Removes a student from the course
    /// </summary>
    /// <param name="student">Student to be removed</param>
    /// <returns>true if the student is removed from the course, false if the student wasn't enrolled to begin with</returns>
    public bool Remove(Student student)
    {
        bool ret = false;
        Student? s = Students.Find(s => s.Name.Equals(student.Name));
        Course? c = student.Courses.Find(c => c.Name.Equals(Name));

        if (s != null)
        {
            Students.Remove(s);
            ret = true;
        }

        if (c != null)
        {
            student.Courses.Remove(c);
            ret = true;
        }

        if (ret)
            Console.WriteLine($"{student} har tagits bort från {this}.");
        else
            Console.WriteLine($"{student} var inte antagen till {this}.");
        return ret;
    }

    /// <summary>
    /// Prints all the enrolled students in the course
    /// </summary>
    public void RollCall()
    {
        Console.WriteLine($"\nKursdeltagare i {Name}:");
        Students.ForEach(s => Console.WriteLine(s));
    }

    /// <summary>
    /// Returns information about the course
    /// </summary>
    /// <returns>Name (count/max platser)</returns>
    public override string ToString()
    {
        return $"{Name} ({Students.Count}/{MaxSeats} platser)";
    }
}
