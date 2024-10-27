using MediatR;
using mediatR_code.Model;
using mediatR_code.Queries;
using mediatR_code.Repositories;

namespace mediatR_code.Handlers
{
    public class GetStudentHandaler : IRequestHandler<GetStudentQueries, List<StudentDetails>>
    {
        private readonly IStudentRepository _studentRepository;

        public GetStudentHandaler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<List<StudentDetails>> Handle(GetStudentQueries query, CancellationToken cancellationToken)
        {
            return await _studentRepository.GetStudentListAsync();
        }
    }
}
