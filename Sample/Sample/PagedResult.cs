using System;
using static Sample.Pages.FetchData;

namespace Sample
{
    public class PagedResult
    {
        public int NumberOfPages => (int)Math.Ceiling((decimal)TotalRecords / RecordPerPage);
        public int RecordPerPage { get; set; }
        public int TotalRecords { get; set; }
        public WeatherForecast[] ResultSet { get; set; } = Array.Empty<WeatherForecast>();
    }
}
