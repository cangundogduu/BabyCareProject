using BabyCareProject.Dtos.ProductDtos;

namespace BabyCareProject.Services.ProductServices
{
    public interface IProductService
    {
        Task<List<ResultProductDto>> GetAlllAsync();
        Task<UpdateProductDto> GetByIdAsync(string id);

        Task CreateAsync(CreateProductDto createProductDto);
        Task UpdateAsync(UpdateProductDto updateProductDto);
        Task DeleteAsync(string id);
    }
}
