namespace Ilmhub.Builder;
public partial class Handlers
{
    private async Task BotOnCallbackQueryReceived(ITelegramBotClient client, CallbackQuery callbackQuery)
    {
        var user = await _service.GetstudentAsync(callbackQuery.From.Id);
        switch (callbackQuery.Data)
        {
            case "oz":
                
                await client.SendTextMessageAsync(
                    chatId: callbackQuery.From.Id,
                    parseMode: ParseMode.Markdown,
                    text: "Iltimos o'zingizga kerakli Menyuni tanlang✅.",
                    replyMarkup: MessageBuilder.menu());
                user.SelectedLanguage = "O'zbek";
                await _service.UpdatestudentAsync(user);
                break;

            case "rus":
            
                await client.SendTextMessageAsync(
                    chatId: callbackQuery.From.Id,
                    parseMode: ParseMode.Markdown,
                    text: "Пожалуйста выберите нужную опцию из меню✅.",
                    replyMarkup: MessageBuilder.menurus()); 
                user.SelectedLanguage = "Русский";
                await _service.UpdatestudentAsync(user);
                break;
            case "ozbek":

                user.SelectedLanguage = "O'zbek";
                await _service.UpdatestudentAsync(user);
                await client.SendTextMessageAsync(
                    chatId: callbackQuery.From.Id,
                    parseMode: ParseMode.Markdown,
                    text: "Iltimos o'zingizga kerakli Menyuni tanlang✅.",
                    replyMarkup: MessageBuilder.menu());
                break;

            case "ruskiy":
                
                user.SelectedLanguage = "Русский";
                await _service.UpdatestudentAsync(user);
                await client.SendTextMessageAsync(
                    chatId: callbackQuery.From.Id,
                    parseMode: ParseMode.Markdown,
                    text: "Пожалуйста выберите нужную опцию из меню✅.",
                    replyMarkup: MessageBuilder.menurus());
                break;

            case "menu":

                await client.SendTextMessageAsync(
                    chatId: callbackQuery.From.Id,
                    parseMode: ParseMode.Markdown,
                    text: "Iltimos o'zingizga kerakli Menyuni tanlang✅.",
                    replyMarkup: MessageBuilder.menu());
                break;

            case "menuru":
                await client.SendTextMessageAsync(
                    chatId: callbackQuery.From.Id,
                    parseMode: ParseMode.Markdown,
                    text: "Пожалуйста выберите нужную опцию из меню✅.",
                    replyMarkup: MessageBuilder.menurus());
                break;

            case "changelang":
                await client.SendTextMessageAsync(
                    chatId: callbackQuery.From.Id,
                    parseMode: ParseMode.Markdown,
                    text: "Iltimos Kerakli Tilni Tanlang.",
                    replyMarkup: MessageBuilder.Change());

                break;

            case "changephone":
                await client.SendTextMessageAsync(
                    chatId: callbackQuery.From.Id,
                    parseMode: ParseMode.Markdown,
                    text: "Iltimos Aloqa uchun Malumotlaringizni jo'nating.",
                    replyMarkup: MessageBuilder.phone());
                break;

            case "on":
                await client.SendTextMessageAsync(
                    chatId: callbackQuery.From.Id,
                    parseMode: ParseMode.Markdown,
                    text: "O'zingizni Qiziqtirgan Kurslar Haqida bilib oling.",
                    replyMarkup: MessageBuilder.OnlineCourse());
                break;

            case "of":
                await client.SendTextMessageAsync(
                    chatId: callbackQuery.From.Id,
                    parseMode: ParseMode.Markdown,
                    text: "O'zingizni Qiziqtirgan Kurslar Haqida bilib oling.",
                    replyMarkup: MessageBuilder.OfflineCourse());
                break;

            case "flut":
                using (var stream = System.IO.File.OpenRead(@"C:\Users\Hp\Ilmhub\Images\flutter.png"))
                {
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo: stream,
                        caption: $"Mentor:  \nKurs Davomiyligi:  \nTexnologiyalar: ",
                        replyMarkup: MessageBuilder.bos2(),
                        disableNotification: false,
                        parseMode: ParseMode.Html
                    );
                }
                break;

            case "rjs":
                using (var stream = System.IO.File.OpenRead(@"C:\Users\Hp\Ilmhub\Images\React.png"))
                {
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo: stream,
                        caption: $"Mentor:  \nKurs Davomiyligi:  \nTexnologiyalar: ",
                        replyMarkup: MessageBuilder.bos2(),
                        disableNotification: false,
                        parseMode: ParseMode.Html
                    );
                }
                break;

            case "py":
                using (var stream = System.IO.File.OpenRead(@"C:\Users\Hp\Ilmhub\Images\Python.png"))
                {
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo: stream,
                        caption: $"Mentor:  \nKurs Davomiyligi:  \nTexnologiyalar: ",
                        replyMarkup: MessageBuilder.bos2(),
                        disableNotification: false,
                        parseMode: ParseMode.Html
                    );
                }
                break;

            case "nt":
                using (var stream = System.IO.File.OpenRead(@"C:\Users\Hp\Ilmhub\Images\NET MVC.png"))
                {
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo: stream,
                        caption: $"Mentor:  \nKurs Davomiyligi:  \nTexnologiyalar: ",
                        replyMarkup: MessageBuilder.bos2(),
                        disableNotification: false,
                        parseMode: ParseMode.Html
                    );
                }
                break;

            case "rb":
                using (var stream = System.IO.File.OpenRead(@"C:\Users\Hp\Ilmhub\Images\Arduino.png"))
                {
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo: stream,
                        caption: $"Mentor:  \nKurs Davomiyligi:  \nTexnologiyalar: ",
                        replyMarkup: MessageBuilder.bos2(),
                        disableNotification: false,
                        parseMode: ParseMode.Html
                    );
                }
                break;

            case "mflt":
                using (var stream = System.IO.File.OpenRead(@"C:\Users\Hp\Ilmhub\Images\flutter.png"))
                {
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo: stream,
                        caption: $"Mentor:  \nKurs Davomiyligi:  \nTexnologiyalar: ",
                        replyMarkup: MessageBuilder.bos3(),
                        disableNotification: false,
                        parseMode: ParseMode.Html
                    );
                }
                break;

            case "ard":
                using (var stream = System.IO.File.OpenRead(@"C:\Users\Hp\Ilmhub\Images\Arduino.png"))
                {
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo: stream,
                        caption: $"Mentor:  \nKurs Davomiyligi:  \nTexnologiyalar: ",
                        replyMarkup: MessageBuilder.bos3(),
                        disableNotification: false,
                        parseMode: ParseMode.Html
                    );
                }
                break;

            case "pyk":
                using (var stream = System.IO.File.OpenRead(@"C:\Users\Hp\Ilmhub\Images\Python.png"))
                {
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo: stream,
                        caption: $"Mentor:  \nKurs Davomiyligi:  \nTexnologiyalar: ",
                        replyMarkup: MessageBuilder.bos3(),
                        disableNotification: false,
                        parseMode: ParseMode.Html
                    );
                }
                break;

            case "bnt":
                using (var stream = System.IO.File.OpenRead(@"C:\Users\Hp\Ilmhub\Images\backend.png"))
                {
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo: stream,
                        caption: $"Mentor:  \nKurs Davomiyligi:  \nTexnologiyalar: ",
                        replyMarkup: MessageBuilder.bos3(),
                        disableNotification: false,
                        parseMode: ParseMode.Html
                    );
                }
                break;

            case "fc+":
                using (var stream = System.IO.File.OpenRead(@"C:\Users\Hp\Ilmhub\Images\C++.png"))
                {
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo: stream,
                        caption: $"Mentor:  \nKurs Davomiyligi:  \nTexnologiyalar: ",
                        replyMarkup: MessageBuilder.bos3(),
                        disableNotification: false,
                        parseMode: ParseMode.Html
                    );
                }
                break;

            case "front":
                using (var stream = System.IO.File.OpenRead(@"C:\Users\Hp\Ilmhub\Images\Frontend.png"))
                {
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo: stream,
                        caption: $"Mentor:  \nKurs Davomiyligi:  \nTexnologiyalar: ",
                        replyMarkup: MessageBuilder.bos3(),
                        disableNotification: false,
                        parseMode: ParseMode.Html
                    );
                }
                break;

            case "scr":
                using (var stream = System.IO.File.OpenRead(@"C:\Users\Hp\Ilmhub\Images\Scratch.png"))
                {
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo: stream,
                        caption: $"Mentor:  \nKurs Davomiyligi:  \nTexnologiyalar: ",
                        replyMarkup: MessageBuilder.bos3(),
                        disableNotification: false,
                        parseMode: ParseMode.Html
                    );
                }
                break;

            case "changelangru":
                await client.SendTextMessageAsync(
                    chatId: callbackQuery.From.Id,
                    parseMode: ParseMode.Markdown,
                    text: "Iltimos Kerakli Tilni Tanlang.",
                    replyMarkup: MessageBuilder.Change());

                break;

            case "changephoneru":
                await client.SendTextMessageAsync(
                    chatId: callbackQuery.From.Id,
                    parseMode: ParseMode.Markdown,
                    text: "Iltimos Aloqa uchun Malumotlaringizni jo'nating.",
                    replyMarkup: MessageBuilder.phoneru());
                break;

            case "onru":
                await client.SendTextMessageAsync(
                    chatId: callbackQuery.From.Id,
                    parseMode: ParseMode.Markdown,
                    text: "Узнайте о курсах, которые вас интересуют.",
                    replyMarkup: MessageBuilder.OnlineCourseru());
                break;

            case "ofru":
                await client.SendTextMessageAsync(
                    chatId: callbackQuery.From.Id,
                    parseMode: ParseMode.Markdown,
                    text: "Узнайте о курсах, которые вас интересуют.",
                    replyMarkup: MessageBuilder.OfflineCourseru());
                break;

            case "flutru":
                using (var stream = System.IO.File.OpenRead(@"C:\Users\Hp\Ilmhub\Images\flutter.png"))
                {
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo: stream,
                        caption: $"Менторы:  \nПродолжительность курса :  \nТехнологии обучения : ",
                        replyMarkup: MessageBuilder.bos2ru(),
                        disableNotification: false,
                        parseMode: ParseMode.Html
                    );
                }
                break;

            case "rjsru":
                using (var stream = System.IO.File.OpenRead(@"C:\Users\Hp\Ilmhub\Images\React.png"))
                {
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo: stream,
                        caption: $"Менторы:  \nПродолжительность курса :  \nТехнологии обучения : ",
                        replyMarkup: MessageBuilder.bos2ru(),
                        disableNotification: false,
                        parseMode: ParseMode.Html
                    );
                }
                break;

            case "pyru":
                using (var stream = System.IO.File.OpenRead(@"C:\Users\Hp\Ilmhub\Images\Python.png"))
                {
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo: stream,
                        caption: $"Менторы:  \nПродолжительность курса :  \nТехнологии обучения : ",
                        replyMarkup: MessageBuilder.bos2ru(),
                        disableNotification: false,
                        parseMode: ParseMode.Html
                    );
                }
                break;

            case "ntru":
                using (var stream = System.IO.File.OpenRead(@"C:\Users\Hp\Ilmhub\Images\NET MVC.png"))
                {
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo: stream,
                        caption: $"Менторы:  \nПродолжительность курса :  \nТехнологии обучения : ",
                        replyMarkup: MessageBuilder.bos2ru(),
                        disableNotification: false,
                        parseMode: ParseMode.Html
                    );
                }
                break;

            case "rbru":
                using (var stream = System.IO.File.OpenRead(@"C:\Users\Hp\Ilmhub\Images\Arduino.png"))
                {
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo: stream,
                        caption: $"Менторы:  \nПродолжительность курса :  \nТехнологии обучения : ",
                        replyMarkup: MessageBuilder.bos2ru(),
                        disableNotification: false,
                        parseMode: ParseMode.Html
                    );
                }
                break;

            case "mfltru":
                using (var stream = System.IO.File.OpenRead(@"C:\Users\Hp\Ilmhub\Images\flutter.png"))
                {
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo: stream,
                        caption: $"Менторы:  \nПродолжительность курса :  \nТехнологии обучения : ",
                        replyMarkup: MessageBuilder.bos3ru("Flutter"),
                        disableNotification: false,
                        parseMode: ParseMode.Html
                    );
                }
                break;

            case "ardru":
                using (var stream = System.IO.File.OpenRead(@"C:\Users\Hp\Ilmhub\Images\Arduino.png"))
                {
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo: stream,
                        caption: $"Менторы:  \nПродолжительность курса :  \nТехнологии обучения : ",
                        replyMarkup: MessageBuilder.bos3ru("Ardunio"),
                        disableNotification: false,
                        parseMode: ParseMode.Html
                    );
                }
                break;

            case "pykru":
                using (var stream = System.IO.File.OpenRead(@"C:\Users\Hp\Ilmhub\Images\Python.png"))
                {
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo: stream,
                        caption: $"Менторы:  \nПродолжительность курса :  \nТехнологии обучения : ",
                        replyMarkup: MessageBuilder.bos3ru("Python Kids"),
                        disableNotification: false,
                        parseMode: ParseMode.Html
                    );
                }
                break;

            case "bntru":
                using (var stream = System.IO.File.OpenRead(@"C:\Users\Hp\Ilmhub\Images\backend.png"))
                {
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo: stream,
                        caption: $"Менторы:  \nПродолжительность курса :  \nТехнологии обучения : ",
                        replyMarkup: MessageBuilder.bos3ru("Backend"),
                        disableNotification: false,
                        parseMode: ParseMode.Html
                    );
                }
                break;

            case "fc+ru":
                using (var stream = System.IO.File.OpenRead(@"C:\Users\Hp\Ilmhub\Images\C++.png"))
                {
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo: stream,
                        caption: $"Менторы:  \nПродолжительность курса :  \nТехнологии обучения : ",
                        replyMarkup: MessageBuilder.bos3ru("C++"),
                        disableNotification: false,
                        parseMode: ParseMode.Html
                    );
                }
                break;

            case "frontru":
                using (var stream = System.IO.File.OpenRead(@"C:\Users\Hp\Ilmhub\Images\Frontend.png"))
                {
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo: stream,
                        caption: $"Менторы:  \nПродолжительность курса :  \nТехнологии обучения : ",
                        replyMarkup: MessageBuilder.bos3ru("Frontend"),
                        disableNotification: false,
                        parseMode: ParseMode.Html
                    );
                }
                break;

            case "scrru":
                using (var stream = System.IO.File.OpenRead(@"C:\Users\Hp\Ilmhub\Images\Scratch.png"))
                {
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo: stream,
                        caption: $"Менторы:  \nПродолжительность курса :  \nТехнологии обучения : ",
                        replyMarkup: MessageBuilder.bos3ru("Scratch"),
                        disableNotification: false,
                        parseMode: ParseMode.Html
                    );
                }
                break;
        }

    }
}