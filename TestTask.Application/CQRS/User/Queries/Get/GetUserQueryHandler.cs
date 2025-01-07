using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Application.Interfaces;
using TestTask.Domain.Models.User.Get;

namespace TestTask.Application.CQRS.User.Queries.Get
{
    public class GetUserQueryHandler : IRequestHandler<GetUserQuery, List<GetResponse>>
    {
        private readonly IUserService _service;
        public GetUserQueryHandler(IUserService service)
            => _service = service;

        public async Task<List<GetResponse>> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            var result = await _service.Get(request.Request);

            return result;
        }
    }
}
