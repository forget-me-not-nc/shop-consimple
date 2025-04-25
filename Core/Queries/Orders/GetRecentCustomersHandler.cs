using AutoMapper;
using DTO.Requests.Orders;
using DTO.Response.Orders;
using MediatR;
using Repository.Abstract;

namespace Core.Queries.Orders
{
    public record GetRecentCustomersCommand(GetRecentCustomersRequest Request): IRequest<GetRecentCustomersResponse>;
    internal class GetRecentCustomersHandler : IRequestHandler<GetRecentCustomersCommand, GetRecentCustomersResponse>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public GetRecentCustomersHandler(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public async Task<GetRecentCustomersResponse> Handle(GetRecentCustomersCommand request, CancellationToken cancellationToken)
        {
            var recentOrders = await _orderRepository.GetRecentCusomersPaginatedAsync(request.Request.DaysThreshold, request.Request.PageNumber, request.Request.PageSize);
            return new GetRecentCustomersResponse(recentOrders, request.Request.PageNumber, request.Request.PageSize, recentOrders.TotalPages, recentOrders.ItemsCount);
        }
    }
}
