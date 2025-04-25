using AutoMapper;
using DTO.Models.Categories;
using DTO.Response.Clients;
using MediatR;
using Repository.Abstract;

namespace Core.Queries.Clients
{
    public record GetCategoriesStatisticByClientCommand(int ClientId) : IRequest<ClientCategoryStatisticsResponse>;
    internal class GetCategoriesStatisticByClientHandler: IRequestHandler<GetCategoriesStatisticByClientCommand, ClientCategoryStatisticsResponse>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;
        public GetCategoriesStatisticByClientHandler(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public async Task<ClientCategoryStatisticsResponse> Handle(GetCategoriesStatisticByClientCommand request, CancellationToken cancellationToken)
        {
            var clientsOrders = await _orderRepository.GetOrdersByCustomerId(request.ClientId);

            var statistic = clientsOrders
                .SelectMany(order => order.Products)
                .GroupBy(op => new
                {
                    op.Product.Category.Id,
                    op.Product.Category.CategoryName,
                })
                .Select(g => new CategoryStatisticModel
                {
                    Category = new CategoryModel
                    {
                        CetegoryId = g.Key.Id,
                        CategoryName = g.Key.CategoryName
                    },
                    OrderedProductsCount = g.Count()
                })
                .OrderByDescending(x => x.OrderedProductsCount)
                .ToList();

            return new ClientCategoryStatisticsResponse { CategoriesStats = statistic, CientId = request.ClientId };
        }
    }
}
