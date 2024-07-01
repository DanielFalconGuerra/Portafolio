namespace Portafolio.Models.APIFutbol
{
    public class APIFutbol
    {

    }

    public class Totals
    {
        public int players { get; set; }
        public int teams { get; set; }
        public int stadiums { get; set; }
        public int matches { get; set; }
        public int statistics { get; set; }
        public int total { get; set; }
    }

    public class ResponseTotals
    {
        public string message { get; set; }
        public Totals total { get; set; }
        public int statusCode { get; set; }
    }
}
