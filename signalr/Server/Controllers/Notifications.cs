using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using signalr.Server.Models;

namespace signalr.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Notifications : ControllerBase
    {
        private readonly IHubContext<NotificationHub> _hubContext;

        public Notifications(IHubContext<NotificationHub> hubContext) 
        {
            _hubContext = hubContext;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] SimpleTitleString simpleTitleString)
        {
            await _hubContext.Clients.All.SendAsync("notification", $"{DateTime.Now} : {simpleTitleString.Title}");
            return Ok("Notification has been sent successfully!");
        }
    }
}
