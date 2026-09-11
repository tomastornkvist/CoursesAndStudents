class Course(string name, int maxSeats)
{
    public string Name { get; private set; } = name;
    public int MaxSeats { get; private set; } = maxSeats;
    private List<Student> Students = new();

    public bool Enroll(Student student)
    {
        if (Students.Count >= MaxSeats)
        {
            Console.WriteLine("Kursen är full");
            return false;
        }

        // If the student is already enrolled, enrollment is successful.
        if (Students.Exists(s => student.Name.Equals(s.Name)))
            return true;

        Students.Add(student);
        student.Courses.Add(this);
        return true;
    }

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

        return ret;
    }

    public void RollCall()
    {
        Students.ForEach(s => Console.WriteLine(s));
    }

    public override string ToString()
    {
        return $"{Name} ({Students.Count}/{MaxSeats} platser)";
    }
}
