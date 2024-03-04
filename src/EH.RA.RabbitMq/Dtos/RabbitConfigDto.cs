namespace EH.RA.RabbitMq.Dtos
{
    public class RabbitConfigDto
    {
        // <summary>
        // 
        // </summary>
        public string ConnectionName { get; set;}

        public string Exchange { get; set; }

        public string ExchangeType { get; set; }

        public string HostName { get; set; }

        public string Password { get; set; }

        public int Port { get; set; }

        public string UserName { get; set; }

        public string VirtualHost { get; set; }

        public string QueuePrefix { get; set; }
        public string QueueSuffix { get; set; }

        public string UseSsl { get; set; }
        public string ErrorExchange { get; set; }
    }
}