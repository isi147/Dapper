using static System.Formats.Asn1.AsnWriter;
using System.Text.RegularExpressions;

namespace ConsoleApp35;

public class StudentGroups
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string GroupName { get; set; }

    public override string ToString()
    {
        return $"FirstName: {FirstName} - LastName: {LastName} - GroupName: {GroupName}\n";
    }
}
