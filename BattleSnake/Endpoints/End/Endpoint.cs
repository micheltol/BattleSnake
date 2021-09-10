using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;

namespace BattleSnake.Endpoints.End
{
    public class Start : BaseEndpoint.WithoutRequest.WithoutResponse
    {
        [HttpPost("/End")]
        public override ActionResult Handle()
        {
            return Ok();
        }
    }
}
