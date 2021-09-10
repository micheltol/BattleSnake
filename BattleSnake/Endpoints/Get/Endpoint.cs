using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;

namespace BattleSnake.Endpoints.Get
{
    public class Get : BaseEndpoint.WithoutRequest
    .WithResponse<GetResponse>
    {

        [HttpGet("")]
        public override ActionResult<GetResponse> Handle()
        {
            return Ok(new GetResponse
            {
                apiversion = "1",
                author = "micheltol",
                color = "800000",
                head = "default",
                tail = "default",
                version = "0.0.1-alpha"
            });
        }
    }
}
