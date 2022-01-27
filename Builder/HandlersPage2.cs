using Ilmhub.Clients;
namespace Ilmhub.Builder;
public partial class Handlers
{
    private async Task BotOnMessageReceived(ITelegramBotClient client, Message message)
    {


        switch (message.Text)
        {
            case "/start":
                await client.SendTextMessageAsync(
                    chatId: message.Chat.Id,
                    parseMode: ParseMode.Markdown,
                    text: "ltimos Aloqa uchun Kontaktingizni jo'nating.\n" +
                    "Пожалуйста отправьте свои контакты\n  ",
                    replyMarkup: MessageBuilder.phone());

                break;

            case "Sozlamalar ⚙️":
                await client.SendTextMessageAsync(
                chatId: message.Chat.Id,
                parseMode: ParseMode.Markdown,
                text: "Iltimos kerakli Menyuni tanlang✅",
                replyMarkup: MessageBuilder.Greeting2());

                break;

            case "Bizning kontaklarimiz📞📞":
                using (var stream = System.IO.File.OpenRead(@"C:\Users\Hp\Ilmhub\Images\contactus.png"))
                {
                    await client.SendPhotoAsync(
                        chatId: message.Chat.Id,
                        photo: stream,
                        caption: $"Lunacharskiy fililai : + 998 94 671 50 60",
                        replyMarkup: MessageBuilder.conatct(),
                        disableNotification: false,
                        parseMode: ParseMode.Html
                    );
                }
                break;

            case "Bizning Filiallarimiz  📍":
                await client.SendTextMessageAsync(
                    chatId: message.Chat.Id,
                    parseMode: ParseMode.Markdown,
                    text: "Lunacharskiy filiali\nIsh Vaqti :7/24\nTel: + 998 94 671 50 60"
                );
                await client.SendLocationAsync(
                chatId: message.Chat.Id,
                latitude: 41.337596,
                longitude: 69.355991,
                replyMarkup: MessageBuilder.bos()
                );
                break;

            case "Bizning Kurslarimiz.📚":
                using (var stream = System.IO.File.OpenRead(@"C:\Users\Hp\Ilmhub\Images\ilmhublogo.png"))
                {
                    await client.SendPhotoAsync(
                        chatId: message.Chat.Id,
                        photo: stream,
                        caption: "",
                        replyMarkup: MessageBuilder.Course(),
                        disableNotification: true
                    );
                }
                break;

            case "Настройки ⚙️":
                await client.SendTextMessageAsync(
                chatId: message.Chat.Id,
                parseMode: ParseMode.Markdown,
                text: "Пожалуйста выберите нужную опцию из меню.✅",
                replyMarkup: MessageBuilder.Greeting2ru());

                break;

            case "Наши контакты 📞📞":
                using (var stream = System.IO.File.OpenRead(@"C:\Users\Hp\Ilmhub\Images\contactus.png"))
                {
                    await client.SendPhotoAsync(
                        chatId: message.Chat.Id,
                        photo: stream,
                        caption: $"Филиал в Луначарский : + 998 94 671 50 60",
                        replyMarkup: MessageBuilder.conatctru(),
                        disableNotification: false,
                        parseMode: ParseMode.Html
                    );
                }
                break;

            case "Наши филиалы📍.":
                await client.SendTextMessageAsync(
                    chatId: message.Chat.Id,
                    parseMode: ParseMode.Markdown,
                    text: "Филиал в Луначарский.\nВремя работы :7/24\nТелефон: + 998 94 671 50 60"
                );
                await client.SendLocationAsync(
                chatId: message.Chat.Id,
                latitude: 41.337596,
                longitude: 69.355991,
                replyMarkup: MessageBuilder.bosru()
                );
                break;

            case "Наши курсы 📚":
                using (var stream = System.IO.File.OpenRead(@"C:\Users\Hp\Ilmhub\Images\ilmhublogo.png"))
                {
                    await client.SendPhotoAsync(
                        chatId: message.Chat.Id,
                        photo: stream,
                        caption: "",
                        replyMarkup: MessageBuilder.Courseru(),
                        disableNotification: true
                    );
                }
                break;
        }

        var user = new Student();
        if (message.Contact != null && await _service.ExistsAsync(message.Chat.Id))
        {   
            var user2=await _service.GetstudentAsync(message.Chat.Id);
            if(user2.SelectedLanguage=="O'zbek"){
            await client.SendTextMessageAsync(
                    chatId: message.Chat.Id,
                    parseMode: ParseMode.Markdown,
                    text: "ltimos O'z tilingizni tanlang.\n" +
                    "Пожалуйста выберите свой язык.\n  ",
                    replyMarkup: MessageBuilder.Greeting2());
            }
            if(user2.SelectedLanguage=="Русский"){
            await client.SendTextMessageAsync(
                    chatId: message.Chat.Id,
                    parseMode: ParseMode.Markdown,
                    text: "ltimos O'z tilingizni tanlang.\n" +
                    "Пожалуйста выберите свой язык.\n  ",
                    replyMarkup: MessageBuilder.Greeting2ru());
            }
        }
        if(message.Contact != null&& !await _service.ExistsAsync(message.Chat.Id))
        {
            user.ChatId = message.Chat.Id;
            user.PhoneNumber = message.Contact.PhoneNumber;
            user.Fullname = message.Contact.FirstName;
            user.Studentname = message.Contact.LastName;
            ;

            if (!(await _service.InsertstudentAsync(user)).IsSuccess)
            {
                throw new Exception($"Could not add a new user to DB. CHAT ID: {user.ChatId}");
            }
            
                await client.SendTextMessageAsync(
                    chatId: message.Chat.Id,
                    parseMode: ParseMode.Markdown,
                    text: "ltimos O'z tilingizni tanlang.\n" +
                    "Пожалуйста выберите свой язык.\n  ",
                    replyMarkup: MessageBuilder.Greeting());
            
        }
        
    }  
}

