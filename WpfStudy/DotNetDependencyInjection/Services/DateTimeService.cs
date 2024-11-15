namespace DotNetDependencyInjection.Services
{
    public class DateTimeService : IDateTimeService
    {
        public string GetDateTimeString()
        {
            return DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        }
    }
}
