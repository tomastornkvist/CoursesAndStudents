class Student(string name)
{
    public string Name = name;
    private List<Course> Courses = new();

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
        Courses.ForEach(c => Console.WriteLine(c.Name));
    }

    public override string ToString()
    {
        return Name;
    }
}
