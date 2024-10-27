using MediatR;
using mediatR_code.Commands;
using mediatR_code.Model;
using mediatR_code.Repositories;

namespace mediatR_code.Handlers
{
    public class CreateStudentHandaler: IRequestHandler<CreateStudentCommands, StudentDetails>
    {
        private readonly IStudentRepository _studentRepository;

        public CreateStudentHandaler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public async Task<StudentDetails> Handle(CreateStudentCommands command, CancellationToken cancellationToken)
        {
            var studentDetails = new StudentDetails()
            {
                StudentName = command.StudentName,
                StudentEmail = command.StudentEmail,
                StudentAddress = command.StudentAddress,
                StudentAge = command.StudentAge
            };

            return await _studentRepository.AddStudentAsync(studentDetails);
        }
    }
}
