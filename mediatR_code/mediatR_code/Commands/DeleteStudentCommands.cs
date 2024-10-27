using MediatR;

namespace mediatR_code.Commands
{
    public class DeleteStudentCommands : IRequest<int>
    {
        public int Id { get; set; }
    }
}
