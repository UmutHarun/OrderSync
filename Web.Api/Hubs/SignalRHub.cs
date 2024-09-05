using Microsoft.AspNetCore.SignalR;
using OrderSync.DataAccessLayer.Concrete;

namespace Web.Api.Hubs
{
    public class SignalRHub : Hub
    {
        OrderSyncDbContext context = new OrderSyncDbContext();

        public async Task SendCategoryCount()
        {
            var value = context.Categories.Count();
            await Clients.All.SendAsync("ReceiveCategoryCount", value);
        }
    }
}
