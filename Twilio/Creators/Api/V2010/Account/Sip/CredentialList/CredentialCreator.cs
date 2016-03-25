using Twilio.Clients;
using Twilio.Creators;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Resources.Api.V2010.Account.Sip.CredentialList;

namespace Twilio.Creators.Api.V2010.Account.Sip.CredentialList {

    public class CredentialCreator : Creator<CredentialResource> {
        private string accountSid;
        private string credentialListSid;
        private string username;
        private string password;
    
        /**
         * Construct a new CredentialCreator
         * 
         * @param accountSid The account_sid
         * @param credentialListSid The credential_list_sid
         * @param username The username
         * @param password The password
         */
        public CredentialCreator(string accountSid, string credentialListSid, string username, string password) {
            this.accountSid = accountSid;
            this.credentialListSid = credentialListSid;
            this.username = username;
            this.password = password;
        }
    
        /**
         * Make the request to the Twilio API to perform the create
         * 
         * @param client TwilioRestClient with which to make the request
         * @return Created CredentialResource
         */
        public CredentialResource execute(TwilioRestClient client) {
            Request request = new Request(
                System.Net.Http.HttpMethod.Post,
                TwilioRestClient.Domains.API,
                "/2010-04-01/Accounts/" + this.accountSid + "/SIP/CredentialLists/" + this.credentialListSid + "/Credentials.json"
            );
            
            addPostParams(request);
            Response response = client.request(request);
            
            if (response == null) {
                throw new ApiConnectionException("CredentialResource creation failed: Unable to connect to server");
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
            
            return CredentialResource.fromJson(response.GetContent());
        }
    
        /**
         * Add the requested post parameters to the Request
         * 
         * @param request Request to add post params to
         */
        private void addPostParams(Request request) {
            if (username != null) {
                request.addPostParam("Username", username);
            }
            
            if (password != null) {
                request.addPostParam("Password", password);
            }
        }
    }
}