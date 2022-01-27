global using Telegram.Bot.Types.ReplyMarkups;
using Ilmhub.Data;
using Ilmhub.Services;

namespace Ilmhub.Builder
{
    public partial class MessageBuilder
    {
        private readonly ILogger<Handlers> _logger;
        private readonly IStorageService _service;
        private readonly BotDbContext _db;
        private readonly ITelegramBotClient _client;
        private readonly Update _update;
        private readonly Message _message;

        public MessageBuilder(ILogger<Handlers> logger,BotDbContext dbcontext,
    IStorageService storage,ITelegramBotClient client,Update update,Message message)
    {
        _logger = logger;
        _service=storage;
        _db=dbcontext;
        _client=client;
        _update=update;
        _message=message;
    }

        public static InlineKeyboardMarkup Greeting()
        {
            InlineKeyboardButton Button = new InlineKeyboardButton("O'zbek Tili 🇺🇿 🇺🇿");
            InlineKeyboardButton Button2 = new InlineKeyboardButton("Русский Язык 🇷🇺 🇷🇺");
            Button.CallbackData = "oz";
            Button2.CallbackData = "rus";
            InlineKeyboardButton[] buttons = new InlineKeyboardButton[] { Button, Button2 };
            InlineKeyboardMarkup inline = new InlineKeyboardMarkup(buttons);
            return inline;
        }

        public static InlineKeyboardMarkup Change()
        {
            InlineKeyboardButton Button = new InlineKeyboardButton("O'zbek Tili 🇺🇿 🇺🇿");
            InlineKeyboardButton Button2 = new InlineKeyboardButton("Русский Язык 🇷🇺 🇷🇺");
            Button.CallbackData = "ozbek";
            Button2.CallbackData = "ruskiy";
            InlineKeyboardButton[] buttons = new InlineKeyboardButton[] { Button, Button2 };
            InlineKeyboardMarkup inline = new InlineKeyboardMarkup(buttons);
            return inline;
        }

        public static InlineKeyboardMarkup Greeting2()
        {
            var keyboard = new InlineKeyboardMarkup
            (
                new InlineKeyboardButton[][]
                {

                    new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData ("Tilni O'zgartirish🔄🔁","changelang"),

                        InlineKeyboardButton.WithCallbackData("Telefon Raqamni o'zgartirish 🔄🔁", "changephone"),
                    },
                    new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData("Bosh menyu 🔰", "menu"),
                    },
                }
            );
            return keyboard;

        }

        public static ReplyKeyboardMarkup menu()
            => new ReplyKeyboardMarkup(new List<List<KeyboardButton>>()
                            {
                            new List<KeyboardButton>()
                            {
                                new KeyboardButton("Bizning Filiallarimiz  📍"){ },
                                new KeyboardButton("Bizning kontaklarimiz📞📞"){   }
                            },

                            new List<KeyboardButton>()
                            {
                                new KeyboardButton("Bizning Kurslarimiz.📚 "){ },
                                new KeyboardButton("Sozlamalar ⚙️"){ }

                            }
                            })
            {
                ResizeKeyboard = true,
                OneTimeKeyboard = true
            };

        public static InlineKeyboardMarkup Course()
        {
            var keyboard = new InlineKeyboardMarkup
            (
                new InlineKeyboardButton[][]
                {

                    new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData ("Onlayn Kurslar","on"),

                        InlineKeyboardButton.WithCallbackData("OffLine Kurslar. ", "of"),
                    },

                    new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData("Bosh menyu 🔰", "menu"),
                    },
                }
            );

            return keyboard;
        }

        internal static IReplyMarkup OnlineCourse()
        {
            var keyboard = new InlineKeyboardMarkup
            (
                new InlineKeyboardButton[][]
                {

                    new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData ("Flutter","flut"),

                        InlineKeyboardButton.WithCallbackData("ReactJs. ", "rjs"),
                    },

                    new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData ("Python","py"),

                        InlineKeyboardButton.WithCallbackData(".Net ", "nt"),
                    },

                    new InlineKeyboardButton[] {
                        InlineKeyboardButton.WithCallbackData ("Robotic","rb"),

                        InlineKeyboardButton.WithCallbackData("Bosh menyu 🔰", "menu"),
                    },
                }
            );

            return keyboard;
        }

        public static InlineKeyboardMarkup conatct()
        {
            var keyboard = new InlineKeyboardMarkup
            (
                new InlineKeyboardButton[][]
                {

                    new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithUrl("GitHub. ", "https://github.com/ilmhub-uz"),

                        InlineKeyboardButton.WithUrl("Instagram. ", "https://www.instagram.com/ilmhubuz/"),
                    },

                    new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithUrl("YouTube. ", "https://www.youtube.com/channel/UCExbuFxW_p3VQq573KWS6UQ"),
                        InlineKeyboardButton.WithUrl($"Telegram.", "https://t.me/ilmhubuz"),
                    },

                    new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData("Bosh menyu 🔰", "menu"),
                    },
                }
            );

            return keyboard;

        }

        internal static IReplyMarkup OfflineCourse()
        {
            var keyboard = new InlineKeyboardMarkup
            (
                new InlineKeyboardButton[][]
                {

                    new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData ("Mobile(Flutter)","mflt"),

                        InlineKeyboardButton.WithCallbackData("Robotexnika(Ardunio). ", "ard"),
                    },

                    new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData ("Python(Kids)","pyk"),

                        InlineKeyboardButton.WithCallbackData("Backend(.Net) ", "bnt"),
                    },

                    new InlineKeyboardButton[] {
                        InlineKeyboardButton.WithCallbackData ("Foundation (C++)","fc+"),

                        InlineKeyboardButton.WithCallbackData("Frontend", "front"),
                    },

                    new InlineKeyboardButton[] {
                        InlineKeyboardButton.WithCallbackData ("Scratch","scr"),

                        InlineKeyboardButton.WithCallbackData("Bosh menyu 🔰", "menu"),
                    },
                }
            );

            return keyboard;
        }

        public static ReplyKeyboardMarkup phone()
        {
            KeyboardButton phone = new KeyboardButton("Share Contact");
            phone.RequestContact = true;
            ReplyKeyboardMarkup ans = new ReplyKeyboardMarkup(phone);
            ans.ResizeKeyboard = true;
            ans.OneTimeKeyboard = true;
            return ans;
        }
        public static InlineKeyboardMarkup bos()
        {
            InlineKeyboardButton bos = new InlineKeyboardButton("Bosh menyu 🔰");
            bos.CallbackData = "menu";
            InlineKeyboardMarkup ret = new InlineKeyboardMarkup(bos);
            return ret;
        }

        public static InlineKeyboardMarkup bos2()
        {
            var keyboard = new InlineKeyboardMarkup
            (
                new InlineKeyboardButton[][]
                {

                    new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData("Bosh menyu 🔰", "menu"),
                        InlineKeyboardButton.WithCallbackData ("Onlayn Kurslar","on"),
                    },
                    new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData ("Kursga Yozilish","Kry"),
                    },
                }
            );
            return keyboard;
        }

        public static InlineKeyboardMarkup bos3()
        {
            var keyboard = new InlineKeyboardMarkup
            (
                new InlineKeyboardButton[][]
                {

                    new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData("Bosh menyu 🔰", "menu"),
                        InlineKeyboardButton.WithCallbackData ("Oflayn Kurslar","of"),
                    },
                    new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData ("Kursga Yozilish","Kry"),
                    },
                }
            );
            return keyboard;
        }

    }
}