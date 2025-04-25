using DTO.Models.Clients;

namespace DTO.Response.Clients
{
    public class GetClientsWithBirthdayReponse
    {
        public GetClientsWithBirthdayReponse(List<ClientBirthdayModel> clients, DateTime requestedDate)
        {
            Clients = clients;
            RequestedDate = requestedDate;
        }

        public List<ClientBirthdayModel> Clients { get; set; }
        public DateTime RequestedDate { get; set; }
    }
}
