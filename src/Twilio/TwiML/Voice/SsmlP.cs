/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System.IO;
using System.Text;
using System.Xml.Linq;

namespace Twilio.TwiML.Voice 
{

    /// <summary>
    /// Adding a Pause Between Paragraphs in Say
    /// </summary>
    public class SsmlP : TwiML 
    {
        /// <summary>
        /// Words to speak
        /// </summary>
        public string Words { get; set; }

        /// <summary>
        /// Create a new SsmlP
        /// </summary>
        /// <param name="words"> Words to speak, the body of the TwiML Element. </param>
        public SsmlP(string words = null) : base("p")
        {
            this.Words = words;
        }

        /// <summary>
        /// Return the body of the TwiML tag
        /// </summary>
        protected override string GetElementBody()
        {
            return this.Words != null ? this.Words : string.Empty;
        }

        /// <summary>
        /// Append a child TwiML element to this element returning this element to allow chaining.
        /// </summary>
        /// <param name="childElem"> Child TwiML element to add </param>
        public new SsmlP Append(TwiML childElem)
        {
            return (SsmlP) base.Append(childElem);
        }

        /// <summary>
        /// Add freeform key-value attributes to the generated xml
        /// </summary>
        /// <param name="key"> Option key </param>
        /// <param name="value"> Option value </param>
        public new SsmlP SetOption(string key, object value)
        {
            return (SsmlP) base.SetOption(key, value);
        }
    }

}