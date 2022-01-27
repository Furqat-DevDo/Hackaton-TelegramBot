global using Telegram.Bot.Exceptions;
global using Telegram.Bot.Types;
global using Telegram.Bot.Types.Enums;
using Ilmhub.Data;
using Ilmhub.Services;

namespace Ilmhub.Builder;
public partial class Handlers
{
    private readonly ILogger<Handlers> _logger;
    private readonly IStorageService _service;
    private readonly BotDbContext _db;

    public Handlers(ILogger<Handlers> logger,BotDbContext dbcontext,IStorageService storage)
    {
        _logger = logger;
        _service=storage;
        _db=dbcontext;
    }
    public Task HandleErrorAsync(ITelegramBotClient client, Exception exception, CancellationToken ctoken)
    {
        var errorMessage = exception switch
        {
            ApiRequestException => $"Error occured with Telegram Client: {exception.Message}",
            _ => exception.Message
        };

        _logger.LogCritical(errorMessage);

        return Task.CompletedTask;
    }
    public async Task HandleUpdateAsync(ITelegramBotClient client, Update update, CancellationToken ctoken)
    {
        var handler = update.Type switch
        {
            UpdateType.Message => BotOnMessageReceived(client, update.Message),
            UpdateType.EditedMessage => BotOnMessageEdited(client, update.EditedMessage),
            UpdateType.CallbackQuery => BotOnCallbackQueryReceived(client, update.CallbackQuery),
            UpdateType.InlineQuery => BotOnInlineQueryReceived(client, update.InlineQuery),
            UpdateType.ChosenInlineResult => BotOnChosenInlineResultReceived(client, update.ChosenInlineResult),
            _ => UnknownUpdateHandlerAsync(client, update)
        };



        try
        {
            await handler;
        }
        catch (Exception e)
        {
            _logger.LogWarning(e.Message);
        }

    }

    private async Task BotMessageReceived(ITelegramBotClient client, Message message)
    {
        throw new NotImplementedException();
    }

    private async Task UnknownUpdateHandlerAsync(ITelegramBotClient client, Update update)
    {
        throw new NotImplementedException();
    }

    private async Task BotOnChosenInlineResultReceived(ITelegramBotClient client, ChosenInlineResult chosenInlineResult)
    {
        throw new NotImplementedException();
    }

    private async Task BotOnInlineQueryReceived(ITelegramBotClient client, InlineQuery inlineQuery)
    {
        throw new NotImplementedException();
    }
    private async Task BotOnMessageEdited(ITelegramBotClient client, Message editedMessage)
    {
        throw new NotImplementedException();
    }

}
