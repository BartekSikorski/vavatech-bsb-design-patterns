// Zasada pojedynczej odpowiedzialności (Single-Responsibility Principle) - SRP

// Każda klasa powinna być odpowiedzialna za jedną konkretną rzecz.
// Klasa powinna mieć tylko jeden powód do zmiany.


public class CourseEnrolment
{
    public void EnrollInCourse(Student student, Course course)
    {
        // Enroll the student in a course
        // Perform validation and save to DB
        Console.WriteLine("Enrolling to the course");
    }
}
