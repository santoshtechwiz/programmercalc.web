using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace programmercalc.web.Models
{
    public partial class RFCClaim
    {
        [JsonProperty("Claim Name")]
        public string ClaimName { get; set; }
        [JsonProperty("Claim Description")]
        public string ClaimDescription { get; set; }
        //[JsonProperty("Change Controller")]
        //public ChangeController ChangeController { get; set; }


        [JsonProperty("Reference")]
        public string Reference { get; set; }
    }

    public enum ChangeController { Etsi, Iesg, OpenIdFoundationArtifactBindingWorkingGroup };

}
