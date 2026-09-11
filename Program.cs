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

for (int i = 0; i < 4; i++)
{
    if (students[i].Join(socialStudies))
        Console.WriteLine($"{students[i]} ska läsa {socialStudies}.");
    else
        Console.WriteLine($"{students[i]} kom inte in på {socialStudies}.");
}