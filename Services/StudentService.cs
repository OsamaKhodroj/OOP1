using OOP1.Domains;

namespace Services
{
    public class StudentService
    {
        private List<Student> _students;

        public StudentService()
        {
            if (_students == null)
            {
                _students = new List<Student>();
            }
        }

        public bool AddStudent(Student student)
        {
            bool isExist = false;
            foreach (var item in _students)
            {
                if (item.Id == student.Id || item.EmailAddress == student.EmailAddress)
                {
                    isExist = true;
                    break;
                }
            }

            if (!isExist)
            {
                _students.Add(student);
                return true;
            }
            else
            {
                Console.WriteLine($"Student {student.Name} already exist");
            }

            return false;
        }

        public void PrintAllStudent()
        {
            foreach (var student in _students)
            {
                Console.WriteLine($"Student Id {student.Id}");
                Console.WriteLine($"Student Name {student.Name}");
                Console.WriteLine($"Student Address {student.Address}");
                Console.WriteLine($"Student Email Address {student.EmailAddress}");
                Console.WriteLine($"Created Date {student.CreatedDateTime}");
                Console.WriteLine($"**********************************************************");
            }
        }

        public void SearchStudentById(int id)
        {
            foreach (var student in _students)
            {
                if (student.Id == id)
                {
                    Console.WriteLine($"Student Id {student.Id}");
                    Console.WriteLine($"Student Name {student.Name}");
                    Console.WriteLine($"Student Address {student.Address}");
                    Console.WriteLine($"Student Email Address {student.EmailAddress}");
                    Console.WriteLine($"Created Date {student.CreatedDateTime}");
                    Console.WriteLine($"**********************************************************");
                    break;
                }
            }
        }
    }
}
