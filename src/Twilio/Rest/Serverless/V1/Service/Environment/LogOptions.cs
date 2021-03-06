/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Serverless.V1.Service.Environment
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// Retrieve a list of all Logs.
    /// </summary>
    public class ReadLogOptions : ReadOptions<LogResource>
    {
        /// <summary>
        /// Service Sid.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Environment Sid.
        /// </summary>
        public string PathEnvironmentSid { get; }
        /// <summary>
        /// Function Sid.
        /// </summary>
        public string FunctionSid { get; set; }

        /// <summary>
        /// Construct a new ReadLogOptions
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathEnvironmentSid"> Environment Sid. </param>
        public ReadLogOptions(string pathServiceSid, string pathEnvironmentSid)
        {
            PathServiceSid = pathServiceSid;
            PathEnvironmentSid = pathEnvironmentSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FunctionSid != null)
            {
                p.Add(new KeyValuePair<string, string>("FunctionSid", FunctionSid.ToString()));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// Retrieve a specific Log.
    /// </summary>
    public class FetchLogOptions : IOptions<LogResource>
    {
        /// <summary>
        /// Service Sid.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Environment Sid.
        /// </summary>
        public string PathEnvironmentSid { get; }
        /// <summary>
        /// Log Sid.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchLogOptions
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathEnvironmentSid"> Environment Sid. </param>
        /// <param name="pathSid"> Log Sid. </param>
        public FetchLogOptions(string pathServiceSid, string pathEnvironmentSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathEnvironmentSid = pathEnvironmentSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

}