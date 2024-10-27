using MediatR;
using mediatR_code.Model;

namespace mediatR_code.Commands
{
    public class CreateStudentCommands : IRequest<StudentDetails>
    {
        public string StudentName { get; set; }
        public string StudentEmail { get; set; }
        public string StudentAddress { get; set; }
        public int StudentAge { get; set; }

        public CreateStudentCommands(string studentName, string studentEmail, string studentAddress, int studentAge)
        {
            StudentName = studentName;
            StudentEmail = studentEmail;
            StudentAddress = studentAddress;
            StudentAge = studentAge;
        }
    }
}
