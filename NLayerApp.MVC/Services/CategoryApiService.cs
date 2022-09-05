using NLayerApp.Core.DTOs.CustomResponseDto;
using NLayerApp.Core.DTOs.EntityDtos;

namespace NLayerApp.MVC.Services
{
    public class CategoryApiService
    {
        private readonly HttpClient _httpClient;
        public CategoryApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<CategoryDto>> GetAllAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<List<CategoryDto>>>("Categories");

            return response.Data;
        }
    }
}
