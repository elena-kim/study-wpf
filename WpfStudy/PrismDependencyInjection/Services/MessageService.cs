namespace PrismDependencyInjection.Services
{
    public class MessageService : IMessageService
    {
        public string GetMessage(string str)
        {
            return str switch
            {
                "1" => "Hello",
                "2" => "안녕하세요",
                _ => string.Empty,
            };
        }
    }
}
