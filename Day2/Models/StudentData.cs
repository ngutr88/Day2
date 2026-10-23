namespace Day2.Models;

// Dữ liệu mẫu để học, chưa sử dụng database.
public static class StudentData
{
    public static List<Student> GetAll()
    {
        return new List<Student>
        {
            new Student { Id = 1, Name = "Nông văn Nguyên", Age = 19 },
            new Student { Id = 2, Name = "Đặng Hải Ahh", Age = 20 },
            new Student { Id = 3, Name = "Nịnh Thanh Khương", Age = 18 }
        };
    }
}
