using System.Threading.Tasks;
using CRM.Protobuf.Person.V1;
using CRM.Protobuf.Personal.V1;
using MediatR;

namespace CRM.Personal.GraphType
{
    public class Mutation
    {
        private readonly IMediator _mediator;
        public Mutation(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<PersonDto> CreateNewPerson(CreatePersonRequest personInput)
        {
            throw new System.NotImplementedException();
        }
    }
}