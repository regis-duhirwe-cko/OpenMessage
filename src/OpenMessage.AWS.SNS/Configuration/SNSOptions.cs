using System;
using Amazon.SimpleNotificationService;

namespace OpenMessage.AWS.SNS.Configuration
{
    /// <summary>
    /// Configuration options for dispatchers
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SNSOptions<T>
    {
        /// <summary>
        /// The url to use for authentication
        /// </summary>
        public string ServiceURL { get; set; }

        /// <summary>
        /// The region endpoint to use
        /// </summary>
        public string RegionEndpoint { get; set; }

        /// <summary>
        /// The topic ARN to send to
        /// </summary>
        public string TopicArn { get; set; }

        /// <summary>
        /// Allow the configuration of the raw AWS SNS Dispatcher Config during initialization of the dispatcher.
        /// </summary>
        public Action<AmazonSimpleNotificationServiceConfig> AwsDispatcherConfiguration { get; set; }
    }
}