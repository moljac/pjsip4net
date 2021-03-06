using System.Collections.Generic;
using System.Net;

namespace pjsip4net.Core.Data
{
    public class UaConfig
    {
        private IList<string> _dnsServers = new List<string>();
        private IList<string> _outboundProxies = new List<string>();
        private IList<string> _stunServers = new List<string>();
        private IList<NetworkCredential> _credentials = new List<NetworkCredential>();
        public bool AutoAnswer { get; set; }
        public bool AutoConference { get; set; }
        public bool AutoRecord { get; set; }
        public uint MaxCalls { get; set; }
        public string StunDomain { get; set; }
        public string StunHost { get; set; }
        public bool ForceLooseRoute { get; set; }
        public bool NatInSdp { get; set; }
        public bool Require100Rel { get; set; }
        public SrtpRequirement UseSrtp { get; set; }
        /// <summary>
        /// Specify whether SRTP requires secure signaling to be used. This option is only used when use_srtp option above is non-zero.
        /// Valid values are: 0: SRTP does not require secure signaling 1: SRTP requires secure transport such as Tls 2: SRTP requires secure end-to-end transport (SIPS)
        /// </summary>
        public int SecureSignalling { get; set; }
        public uint ThreadCount { get; set; }
        public bool StunIgnoreFailure { get; set; }
        public string UserAgent { get; set; }
        public bool HangupForkedCall { get; set; }

        public IList<string> StunServers
        {
            get { return _stunServers; }
            protected set { _stunServers = value; }
        }

        public IList<string> DnsServers
        {
            get { return _dnsServers; }
            protected set { _dnsServers = value; }
        }

        public IList<string> OutboundProxies
        {
            get { return _outboundProxies; }
            protected set { _outboundProxies = value; }
        }

        public IList<NetworkCredential> Credentials
        {
            get { return _credentials; }
            protected set { _credentials = value; }
        }
    }
}
