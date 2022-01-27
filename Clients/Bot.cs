using Ilmhub.Builder;
using Ilmhub.Data;
using Telegram.Bot.Extensions.Polling;

namespace Ilmhub.Clients;
public class Bot : BackgroundService
{
    private readonly TelegramBotClient _botClient;
    private readonly ILogger<Bot> _logger;
    private readonly BotDbContext _dbcontext;

    public Bot(TelegramBotClient client, ILogger<Bot> logger, Handlers handlers, BotDbContext dbContext)
    {
        _botClient = client;
        _logger = logger;
        _botClient.StartReceiving(new DefaultUpdateHandler(handlers.HandleUpdateAsync, handlers.HandleErrorAsync));
        _dbcontext = dbContext;
    }
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var me = await _botClient.GetMeAsync();
        _logger.LogInformation($"{me.Username} has connected successfully!");
    }
}