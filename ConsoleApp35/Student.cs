namespace ConsoleApp35;

public class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public float Score { get; set; }
    public int GroupId { get; set; }


    public override string ToString()
    {
        return $"ID: {Id}\nFirstName: {FirstName}\nLastName: {LastName}\nScore: {Score}\nGroup ID: {GroupId}";
    }
}
