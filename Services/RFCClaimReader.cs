using Json.Net;
using Newtonsoft.Json;
using programmercalc.web.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace programmercalc.web.Services
{
    public static class RFCClaimReader
    {

        public static List<RFCClaim> GetClaims()
        {
            using (var fs = new StreamReader(@"Data\claims.json"))
            {
                var result = fs.ReadToEnd();
                    var list = JsonConvert.DeserializeObject <List<RFCClaim>>(result);
                return list;
            }
        }
    }
}
