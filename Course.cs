class Course(string name, int maxSeats)
{
    public string Name { get; private set; } = name;
    public int MaxSeats { get; private set; } = maxSeats;
    private List<Student> Students = new();

    public bool Enroll(Student student)
    {
        if (Students.Count >= MaxSeats)
            return false;

        Students.Add(student);
        return true;
    }

    public bool Remove(Student student)
    {
        return Students.Remove(student);
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
