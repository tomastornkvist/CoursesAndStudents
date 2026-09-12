Course programming = new("Programmering", 3);
Course socialStudies = new("Sociala studier", 3);
Course politics = new("Politik", 3);
Course society = new("Samhälle", 3);
Course biology = new("Biologi", 3);
Course technology = new("Teknik", 3);

Course[] courses = { programming, socialStudies, politics, society, biology, technology };

Student frans = new("Frans");
Student karla = new("Karla");
Student tuva = new("Tuva");
Student fatimah = new("Fatimah");
Student uma = new("Uma");
Student frank = new("Frank");
Student mans = new("Måns");
Student tomas = new("Tomas");
Student peter = new("Peter");
Student sara = new("Sara");
Student willow = new("Willow");
Student tereza = new("Tereza");
Student sandra = new("Sandra");
Student mathilda = new("Mathilda");

Student[] students = { frans, karla, tuva, fatimah, uma, frank, mans, tomas, peter, sara, willow, tereza, sandra, mathilda };

void WriteTitle(string title)
{
    Console.WriteLine();
    Console.WriteLine(title);
    Console.WriteLine(new string('-', title.Length));
}

WriteTitle($"Studenter försöker komma in på {socialStudies.Name}");
for (int i = 0; i < 4; i++)
{
    if (students[i].Join(socialStudies))
        Console.WriteLine($"{students[i]} ska läsa {socialStudies}.");
    else
        Console.WriteLine($"{students[i]} kom inte in på {socialStudies}.");
}

WriteTitle($"{biology.Name} tar emot studenter");
for (int i = students.Length - 1; i > 0; i -= 3)
{
    if (biology.Enroll(students[i]))
        Console.WriteLine($"{students[i]} ska läsa {biology}.");
    else
        Console.WriteLine($"{students[i]} kom inte in på {biology}.");
}

WriteTitle($"{frank} försöker komma in på alla kurser");
foreach (Course c in courses)
{
    if (frank.Join(c))
        Console.WriteLine($"{frank} ska läsa {c}.");
    else
        Console.WriteLine($"{frank} kom inte in på {c}.");
}

foreach (Course c in courses)
{
    if (c.StudentCount > 0)
        c.RollCall();
}

foreach (Student s in students)
{
    if (s.Courses.Count > 0)
        s.Schedule();
}
