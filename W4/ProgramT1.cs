// creating two objects
Student s1 = new Student();
s1.name = "Saphal";
s1.age = 22;
s1.course = "Computer Science";

Student s2 = new Student();
s2.name = "Ram";
s2.age = 21;
s2.course = "Software Engineering";

// displaying values
Console.WriteLine("Student 1");
Console.WriteLine(s1.name);
Console.WriteLine(s1.age);
Console.WriteLine(s1.course);

Console.WriteLine("Student 2");
Console.WriteLine(s2.name);
Console.WriteLine(s2.age);
Console.WriteLine(s2.course);

// printing static field
Console.WriteLine("College: " + Student.collegeName);
