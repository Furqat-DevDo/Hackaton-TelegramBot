global using Telegram.Bot;
using Ilmhub;
using Ilmhub.Builder;
using Ilmhub.Clients;
using Ilmhub.Data;
using Ilmhub.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<TelegramBotClient>(b => new TelegramBotClient(builder.Configuration.GetSection("Bot:Token").Value));
builder.Services.AddHostedService<Bot>();
builder.Services.AddTransient<Handlers>();
builder.Services.AddTransient<IStorageService, DbStorageService>();
builder.Services.AddDbContext<BotDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("BotConnection"));
            }, ServiceLifetime.Singleton);

var app = builder.Build();

app.Run();
