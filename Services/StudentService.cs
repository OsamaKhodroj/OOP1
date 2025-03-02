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
                Console.WriteLine($"Student Id {item.Id}");
                Console.WriteLine($"Student Name {item.Name}");
                Console.WriteLine($"Student Address {item.Address}");
                Console.WriteLine($"Student Email Address {item.EmailAddress}");
                Console.WriteLine($"Created Date {item.CreatedDateTime}");
                Console.WriteLine($"**********************************************************");
            }
        }
    }
}
