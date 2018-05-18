/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Preview.DeployedDevices.Fleet 
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// Fetch information about a specific Device in the Fleet.
    /// </summary>
    public class FetchDeviceOptions : IOptions<DeviceResource> 
    {
        /// <summary>
        /// The fleet_sid
        /// </summary>
        public string PathFleetSid { get; }
        /// <summary>
        /// A string that uniquely identifies the Device.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchDeviceOptions
        /// </summary>
        /// <param name="pathFleetSid"> The fleet_sid </param>
        /// <param name="pathSid"> A string that uniquely identifies the Device. </param>
        public FetchDeviceOptions(string pathFleetSid, string pathSid)
        {
            PathFleetSid = pathFleetSid;
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

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// Delete a specific Device from the Fleet, also removing it from associated Deployments.
    /// </summary>
    public class DeleteDeviceOptions : IOptions<DeviceResource> 
    {
        /// <summary>
        /// The fleet_sid
        /// </summary>
        public string PathFleetSid { get; }
        /// <summary>
        /// A string that uniquely identifies the Device.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteDeviceOptions
        /// </summary>
        /// <param name="pathFleetSid"> The fleet_sid </param>
        /// <param name="pathSid"> A string that uniquely identifies the Device. </param>
        public DeleteDeviceOptions(string pathFleetSid, string pathSid)
        {
            PathFleetSid = pathFleetSid;
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

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// Create a new Device in the Fleet, optionally giving it a unique name, friendly name, and assigning to a Deployment
    /// and/or human identity.
    /// </summary>
    public class CreateDeviceOptions : IOptions<DeviceResource> 
    {
        /// <summary>
        /// The fleet_sid
        /// </summary>
        public string PathFleetSid { get; }
        /// <summary>
        /// A unique, addressable name of this Device.
        /// </summary>
        public string UniqueName { get; set; }
        /// <summary>
        /// A human readable description for this Device.
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// An identifier of the Device user.
        /// </summary>
        public string Identity { get; set; }
        /// <summary>
        /// The unique SID of the Deployment group.
        /// </summary>
        public string DeploymentSid { get; set; }
        /// <summary>
        /// The enabled
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Construct a new CreateDeviceOptions
        /// </summary>
        /// <param name="pathFleetSid"> The fleet_sid </param>
        public CreateDeviceOptions(string pathFleetSid)
        {
            PathFleetSid = pathFleetSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (Identity != null)
            {
                p.Add(new KeyValuePair<string, string>("Identity", Identity));
            }

            if (DeploymentSid != null)
            {
                p.Add(new KeyValuePair<string, string>("DeploymentSid", DeploymentSid.ToString()));
            }

            if (Enabled != null)
            {
                p.Add(new KeyValuePair<string, string>("Enabled", Enabled.Value.ToString().ToLower()));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// Retrieve a list of all Devices belonging to the Fleet.
    /// </summary>
    public class ReadDeviceOptions : ReadOptions<DeviceResource> 
    {
        /// <summary>
        /// The fleet_sid
        /// </summary>
        public string PathFleetSid { get; }
        /// <summary>
        /// Find all Devices grouped under the specified Deployment.
        /// </summary>
        public string DeploymentSid { get; set; }

        /// <summary>
        /// Construct a new ReadDeviceOptions
        /// </summary>
        /// <param name="pathFleetSid"> The fleet_sid </param>
        public ReadDeviceOptions(string pathFleetSid)
        {
            PathFleetSid = pathFleetSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (DeploymentSid != null)
            {
                p.Add(new KeyValuePair<string, string>("DeploymentSid", DeploymentSid.ToString()));
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
    /// Update the given properties of a specific Device in the Fleet, giving it a friendly name, assigning to a Deployment,
    /// or a human identity.
    /// </summary>
    public class UpdateDeviceOptions : IOptions<DeviceResource> 
    {
        /// <summary>
        /// The fleet_sid
        /// </summary>
        public string PathFleetSid { get; }
        /// <summary>
        /// A string that uniquely identifies the Device.
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// A human readable description for this Device.
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// An identifier of the Device user.
        /// </summary>
        public string Identity { get; set; }
        /// <summary>
        /// The unique SID of the Deployment group.
        /// </summary>
        public string DeploymentSid { get; set; }
        /// <summary>
        /// The enabled
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Construct a new UpdateDeviceOptions
        /// </summary>
        /// <param name="pathFleetSid"> The fleet_sid </param>
        /// <param name="pathSid"> A string that uniquely identifies the Device. </param>
        public UpdateDeviceOptions(string pathFleetSid, string pathSid)
        {
            PathFleetSid = pathFleetSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (Identity != null)
            {
                p.Add(new KeyValuePair<string, string>("Identity", Identity));
            }

            if (DeploymentSid != null)
            {
                p.Add(new KeyValuePair<string, string>("DeploymentSid", DeploymentSid.ToString()));
            }

            if (Enabled != null)
            {
                p.Add(new KeyValuePair<string, string>("Enabled", Enabled.Value.ToString().ToLower()));
            }

            return p;
        }
    }

}