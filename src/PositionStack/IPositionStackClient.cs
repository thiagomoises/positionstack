using PositionStack.Model;
using Refit;

namespace PositionStack
{
    public interface IPositionStackClient
    {
        [Get("/v1/forward")]
        Task<IApiResponse<PositionStackResponse>> SearchAsync([Query] string query,
                                           [Query] string? country = null,
                                           [Query] string? region = null,
                                           [Query] string? language = null,
                                           [Query] string? country_module = null,
                                           [Query] string? sun_module = null,
                                           [Query] string? timezone_module = null,
                                           [Query] string? bbox_module = null,
                                           [Query] string? limit = null,
                                           [Query] string? fields = null,
                                           [Query] string? output = null,
                                           [Query] string? callback = null);
    }
}