using Dapper;
using System.Data.SqlClient;

namespace ConsoleApp35
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var concentionString = "Data Source=STHQ0116-01;Initial Catalog=Library;User ID=admin;Password=admin;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;";

            using SqlConnection connection = new SqlConnection(concentionString);


            //var sql = "INSERT INTO Students (FirstName, LastName, Score, GroupId) VALUES ('Heyder','Heyderli',7,1)";
            //var sqlSelect = "SELECT*FROM Students";

            //connection.Execute(sql);



            //var sql = "INSERT INTO Students (FirstName, LastName, Score, GroupId) VALUES (@FirstName, @LastName, @Score, @GroupId)";

            //var parameters = new
            //{
            //    FirstName = "Ilkin",
            //    LastName = "Ilkinli",
            //    Score = 12,
            //    GroupId = 2
            //};

            //connection.Execute(sql,parameters);





            //var sql = "SELECT*FROM Students WHERE Id = 1";

            //var student = connection.QueryFirst<Student>(sql);

            //Console.WriteLine(student);




            //var sql = "SELECT*FROM Students";

            //var students = connection.Query<Student>(sql).ToList();

            //students.ForEach(student => { Console.WriteLine(student); });



            //var sql = "SELECT*FROM StudentsGroups";

            //var students = connection.Query<StudentGroups>(sql).ToList();

            //students.ForEach(student => { Console.WriteLine(student); });


            //Console.WriteLine("Hello, World!");




            var sql = "SELECT Teachers.FirstName,Teachers.LastName,Departments.[Name]as DepartmentName\r\nFROM Teachers\r\nINNER JOIN Departments ON Teachers.Id_Dep = Departments.Id";


            var teachers = connection.Query<Teacher>(sql).ToList();
            teachers.ForEach(student => { Console.WriteLine(student); });
            

        }
    }
}
