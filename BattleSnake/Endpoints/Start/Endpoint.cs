using Ardalis.ApiEndpoints;
using BattleSnake.Models;
using Microsoft.AspNetCore.Mvc;

namespace BattleSnake.Endpoints.Start
{
    public class Start : BaseEndpoint.WithRequest<Request>.WithoutResponse
    {
        [HttpPost("/Start")]
        public override ActionResult Handle(Request request)
        {
            return Ok();
        }
    }
}
