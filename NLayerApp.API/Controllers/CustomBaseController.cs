using Microsoft.AspNetCore.Mvc;
using NLayerApp.Core.DTOs.CustomResponseDto;

namespace NLayerApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomBaseController : ControllerBase
    {
        [NonAction]//Endpoint değil.
        public IActionResult CreateActionResult<T>(CustomResponseDto<T> responseDto)
        {
            if (responseDto.StatusCode == 204)
                return new ObjectResult(null)
                {
                    StatusCode = responseDto.StatusCode
                };

            return new ObjectResult(responseDto)
            {
                StatusCode = responseDto.StatusCode
            };
        }
    }
}
