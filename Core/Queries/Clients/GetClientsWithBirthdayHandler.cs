using AutoMapper;
using DTO.Models.Clients;
using DTO.Response.Clients;
using MediatR;
using Repository.Abstract;

namespace Core.Queries.Clients
{
    public record GetClientsWithBirthdaysCommand(DateTime Date): IRequest<GetClientsWithBirthdayReponse>;
    internal class GetClientsWithBirthdayHandler : IRequestHandler<GetClientsWithBirthdaysCommand, GetClientsWithBirthdayReponse>
    {
        private readonly IClientRepository _clientRepository;
        private readonly IMapper _mapper;

        public GetClientsWithBirthdayHandler(IClientRepository clientRepository, IMapper mapper)
        {
            _clientRepository = clientRepository;
            _mapper = mapper;
        }

        public async Task<GetClientsWithBirthdayReponse> Handle(GetClientsWithBirthdaysCommand request, CancellationToken cancellationToken)
        {
            var clients = await _clientRepository.GetClientsWithBirthdaysAsync(request.Date);
            var mappedData = _mapper.Map<List<ClientBirthdayModel>>(clients);

            return new GetClientsWithBirthdayReponse(mappedData, request.Date);
        }
    }
}
