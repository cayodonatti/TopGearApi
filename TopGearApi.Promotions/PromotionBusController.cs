using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ServiceBus.Messaging;
using Newtonsoft.Json;

namespace TopGearApi.Promotions
{
    public static class PromotionBusController
    {
        private static string busAdress = ConfigurationManager.AppSettings["busConnection"];
        private static string queueName = ConfigurationManager.AppSettings["busQueueName"];
        private static QueueClient client = QueueClient.CreateFromConnectionString(busAdress, queueName);

        public static void PostPromotion(Promotion p)
        {
            var message = new BrokeredMessage(JsonConvert.SerializeObject(p));

            client.Send(message);
        }

        public static Promotion GetPromotion()
        {
            try
            {
                var prom = JsonConvert.DeserializeObject<Promotion>(client.Receive().GetBody<string>());
                return prom;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static void GetPromotionCallback()
        {
            client.OnMessage(message => {
                var promotion = JsonConvert.DeserializeObject<Promotion>(message.GetBody<string>());
            });
        }
    }
}
