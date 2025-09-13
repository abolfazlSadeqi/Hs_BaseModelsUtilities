namespace Hs_BaseModelsUtilities.Enums.MESSAGING
{
    
    /// <summary>
    /// Message broker technologies.
    /// </summary>
    public enum MessageBrokerType
        {
            RabbitMQ = 1,
            Kafka = 2,
            AzureServiceBus = 3,
            AmazonSQS = 4,
            GooglePubSub = 5,
            ActiveMQ = 6,
            NATS = 7,
            RedisStreams = 8
        }
    }
