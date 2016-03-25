using Twilio.Clients;
using Twilio.Creators;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Resources.IpMessaging.V1.Service.Channel;

namespace Twilio.Creators.IpMessaging.V1.Service.Channel {

    public class MessageCreator : Creator<MessageResource> {
        private string serviceSid;
        private string channelSid;
        private string body;
        private string from;
    
        /**
         * Construct a new MessageCreator
         * 
         * @param serviceSid The service_sid
         * @param channelSid The channel_sid
         * @param body The body
         */
        public MessageCreator(string serviceSid, string channelSid, string body) {
            this.serviceSid = serviceSid;
            this.channelSid = channelSid;
            this.body = body;
        }
    
        /**
         * The from
         * 
         * @param from The from
         * @return this
         */
        public MessageCreator setFrom(string from) {
            this.from = from;
            return this;
        }
    
        /**
         * Make the request to the Twilio API to perform the create
         * 
         * @param client TwilioRestClient with which to make the request
         * @return Created MessageResource
         */
        public MessageResource execute(TwilioRestClient client) {
            Request request = new Request(
                System.Net.Http.HttpMethod.Post,
                TwilioRestClient.Domains.IPMESSAGING,
                "/v1/Services/" + this.serviceSid + "/Channels/" + this.channelSid + "/Messages"
            );
            
            addPostParams(request);
            Response response = client.request(request);
            
            if (response == null) {
                throw new ApiConnectionException("MessageResource creation failed: Unable to connect to server");
            } else if (response.GetStatusCode() != TwilioRestClient.HTTP_STATUS_CODE_CREATED) {
                RestException restException = RestException.fromJson(response.GetContent());
                if (restException == null)
                    throw new ApiException("Server Error, no content");
                throw new ApiException(
                    restException.GetMessage(),
                    restException.GetCode(),
                    restException.GetMoreInfo(),
                    restException.GetStatus(),
                    null
                );
            }
            
            return MessageResource.fromJson(response.GetContent());
        }
    
        /**
         * Add the requested post parameters to the Request
         * 
         * @param request Request to add post params to
         */
        private void addPostParams(Request request) {
            if (body != null) {
                request.addPostParam("Body", body);
            }
            
            if (from != null) {
                request.addPostParam("From", from);
            }
        }
    }
}