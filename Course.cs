class Course(string name, int maxSeats)
{
    public string Name { get; private set; } = name;
    public int MaxSeats { get; private set; } = maxSeats;
    public int StudentCount { get { return Students.Count; } }
    private List<Student> Students = new();

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

    public void RollCall()
    {
        Console.WriteLine($"\nKursdeltagare i {Name}:");
        Students.ForEach(s => Console.WriteLine(s));
    }

    public override string ToString()
    {
        return $"{Name} ({Students.Count}/{MaxSeats} platser)";
    }
}
