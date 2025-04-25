using DTO.Models.Categories;

namespace DTO.Response.Clients
{
    public class ClientCategoryStatisticsResponse
    {
        public List<CategoryStatisticModel> CategoriesStats { get; set; }
        public int CientId { get; set; }
    }
}
