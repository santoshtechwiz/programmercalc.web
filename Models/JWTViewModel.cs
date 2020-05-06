namespace programmercalc.web.Models
{
    public class JWTViewModel
    {
        

        public string Payload { get; set; }
        public string JWTString { get; set; }
        public string Decoded { get; set; }
        public string Header { get; internal set; }
    }
}