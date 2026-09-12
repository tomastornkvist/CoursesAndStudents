// Courses
Course programming = new("Programmering", 3);
Course socialStudies = new("Sociala studier", 3);
Course politics = new("Politik", 3);
Course society = new("Samhälle", 3);
Course biology = new("Biologi", 3);
Course technology = new("Teknik", 3);

Course[] courses = { programming, socialStudies, politics, society, biology, technology };

// Students
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

// Writes an underlined title preceeded by an empty row
void WriteTitle(string title)
{
    Console.WriteLine();
    Console.WriteLine(title);
    Console.WriteLine(new string('-', title.Length));
}

///////////////////////////////////////////
// Testing section begins here
///////////////////////////////////////////

WriteTitle($"Studenter försöker komma in på {socialStudies.Name}");
for (int i = 0; i < 4; i++)
    students[i].Join(socialStudies);

WriteTitle($"{biology.Name} tar emot studenter");
for (int i = students.Length - 1; i > 0; i -= 3)
    biology.Enroll(students[i]);

WriteTitle($"{frank} försöker komma in på alla kurser");
foreach (Course c in courses)
    frank.Join(c);

WriteTitle("Upprop för populerade kurser");
foreach (Course c in courses)
{
    if (c.StudentCount > 0)
        c.RollCall();
}

WriteTitle("Studenters scheman");
foreach (Student s in students)
{
    if (s.Courses.Count > 0)
        s.Schedule();
}

WriteTitle("Studenter försöker lämna kurser");
frans.Leave(technology);
frank.Leave(politics);
frank.Leave(socialStudies);

WriteTitle("Studenter blir borttagna från kurser");
socialStudies.Remove(uma);
socialStudies.Remove(frans);

WriteTitle($"{tuva} försöker komma in på {socialStudies.Name} igen");
tuva.Join(socialStudies);
socialStudies.RollCall();
tuva.Schedule();

WriteTitle($"{frank} försöker komma in på alla kurser igen");
foreach (Course c in courses)
    frank.Join(c);
foreach (Course c in courses)
    c.RollCall();
frank.Schedule();
