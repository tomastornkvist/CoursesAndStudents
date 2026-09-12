class Student(string name)
{
    public string Name = name;
    public List<Course> Courses = new();

    public bool Join(Course course)
    {
        return course.Enroll(this);
    }

    public bool Leave(Course course)
    {
        return course.Remove(this);
    }

    public void Schedule()
    {
        Console.WriteLine($"\nSchema för {Name}:");
        Courses.ForEach(c => Console.WriteLine(c.Name));
    }

    public override string ToString()
    {
        return Name;
    }
}
