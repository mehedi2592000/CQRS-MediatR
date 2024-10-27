using MediatR;
using mediatR_code.Model;

namespace mediatR_code.Queries
{
    public class GetStudentQueries: IRequest<List<StudentDetails>>
    {
    }
}
