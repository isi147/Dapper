namespace ConsoleApp35;

public class Teacher
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string DepartmentName { get; set; }

    public override string ToString()
    {
        return $"FirstName: {FirstName} - LastName: {LastName} - DepartmentName: {DepartmentName}\n";
    }
}
