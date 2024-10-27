using MediatR;
using mediatR_code.Model;

namespace mediatR_code.Queries
{
    public class GetStudentByIdQueries : IRequest<StudentDetails>
    {
        public int Id { get; set; }
    }
}
