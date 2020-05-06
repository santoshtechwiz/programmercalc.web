using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using programmercalc.web.Models;
using programmercalc.web.Services;

namespace programmercalc.web.Hubs
{
    public class Encoderhub:Hub
    {
        public async Task convertToBase64(string message)
        {
            try
            {
                var result = message.ConvertoBase64();
                await Clients.All.SendAsync("ReceiveMessage64", result);
            }
            catch
            {
                await Clients.All.SendAsync("ReceiveMessage64", "Invalid input");
            }
        }
        
        public async Task toUString(string message)
        {
            try
            {
                var result = message.ConvertBase64ToString();
                await Clients.All.SendAsync("ReceiveMessage", result);
            }
            catch
            {
                await Clients.All.SendAsync("ReceiveMessage", "Invalid input");
            }
        }
        public async Task RSAGenerate(string message){
             try
            {
                var model=new RSAViewModel();
                model.PlainText=message;
                var result = RSAUtility.rsa2(model);
                await Clients.All.SendAsync("ReceiveMessage", result);
            }
            catch
            {
                await Clients.All.SendAsync("ReceiveMessage", "Invalid input");
            }
        }
    }
}