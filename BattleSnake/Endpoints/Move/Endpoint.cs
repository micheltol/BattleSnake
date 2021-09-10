using Ardalis.ApiEndpoints;
using BattleSnake.Models;
using Microsoft.AspNetCore.Mvc;

namespace BattleSnake.Endpoints.MOve
{
    public class Move : BaseEndpoint.WithRequest<Request>.WithResponse<MoveResponse>
    {
        [HttpPost("/Move")]
        public override ActionResult<MoveResponse> Handle(Request request)
        {
            return Ok(new MoveResponse
            {
                move = "up",
                shout = "GoGo.. ohh no C#"
            });
        }
    }
}
