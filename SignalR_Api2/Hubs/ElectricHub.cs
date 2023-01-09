using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR_Api2.Hubs
{
    public class ElectricHub : Hub
    {
        private readonly ElectricService _service;

        public ElectricHub(ElectricService service)
        {
            _service = service;
        }

        public async Task GetElectricList()
        {
            await Clients.All.SendAsync("ReceiveElectricList",_service.GetElectricChartList());
        }
    }
}
