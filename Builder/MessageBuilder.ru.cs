
namespace Ilmhub.Builder;
public partial class MessageBuilder
{
    
    public static ReplyKeyboardMarkup menurus()
        => new ReplyKeyboardMarkup(new List<List<KeyboardButton>>()
                        {
                            new List<KeyboardButton>()
                            {
                                new KeyboardButton("Наши филиалы📍."){ },
                                new KeyboardButton("Наши контакты 📞📞"){   }
                            },
                            
                            new List<KeyboardButton>()
                            {
                                new KeyboardButton("Наши курсы 📚 "){ },
                                new KeyboardButton("Настройки ⚙️"){ }

                            }
                        })
        {
            ResizeKeyboard =true,
            OneTimeKeyboard = true
        };
    
    public static InlineKeyboardMarkup Courseru()
        {
            var keyboard = new InlineKeyboardMarkup
            (
                new InlineKeyboardButton[][]
                {

                    new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData ("Онлайн курсы","onru"),

                        InlineKeyboardButton.WithCallbackData("Офлайн курсы", "ofru"),
                    },

                    new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData("Главное меню 🔰", "menuru"),
                    },
                }
            );

            return keyboard;
        }
    public static ReplyKeyboardMarkup phoneru()
        {
            KeyboardButton phone=new KeyboardButton("Отправить контакты.");
            phone.RequestContact=true;
            ReplyKeyboardMarkup ans=new ReplyKeyboardMarkup(phone);
            ans.ResizeKeyboard=true;
            ans.OneTimeKeyboard=true;
            return ans;
        }
    
    public static InlineKeyboardMarkup conatctru(){ 
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

                        InlineKeyboardButton.WithCallbackData("Главное меню 🔰","menuru"),
                    },
                }
            );
            return keyboard; 
        }

        internal static IReplyMarkup OfflineCourseru()
        {
            
            var keyboard = new InlineKeyboardMarkup
            (
                new InlineKeyboardButton[][]
                {

                    new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData ("Mobile(Flutter)","mfltru"),

                        InlineKeyboardButton.WithCallbackData("Robotexnika(Ardunio). ", "ardru"),
                    },

                    new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData ("Python(Kids)","pykru"),

                        InlineKeyboardButton.WithCallbackData("Backend(.Net) ", "bntru"),
                    },

                    new InlineKeyboardButton[] {
                        InlineKeyboardButton.WithCallbackData ("Foundation (C++)","fc+ru"),

                        InlineKeyboardButton.WithCallbackData("Frontend", "frontru"),
                    },

                    new InlineKeyboardButton[] {
                        InlineKeyboardButton.WithCallbackData ("Scratch","scrru"),

                        InlineKeyboardButton.WithCallbackData("Главное меню 🔰","menuru"),
                    },
                }
            );

            return keyboard;
        }

        internal static IReplyMarkup OnlineCourseru()
        {
            var keyboard = new InlineKeyboardMarkup
            (
                new InlineKeyboardButton[][]
                {

                    new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData ("Flutter","flutru"),

                        InlineKeyboardButton.WithCallbackData("ReactJs. ", "rjsru"),
                    },

                    new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData ("Python","pyru"),

                        InlineKeyboardButton.WithCallbackData(".Net ", "ntru"),
                    },

                    new InlineKeyboardButton[] {
                        InlineKeyboardButton.WithCallbackData ("Robotic","rbru"),

                        InlineKeyboardButton.WithCallbackData("Главное меню 🔰","menuru"),
                    },
                }
            );

            return keyboard;
        }
    
        public static InlineKeyboardMarkup bosru()
        {
            InlineKeyboardButton bos = new InlineKeyboardButton("Главное меню 🔰");
            bos.CallbackData = "menuru";
            InlineKeyboardMarkup ret = new InlineKeyboardMarkup(bos);
            return ret;
        }

        public static InlineKeyboardMarkup bos2ru()
        {
            var keyboard = new InlineKeyboardMarkup
            (
                new InlineKeyboardButton[][]
                {

                    new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData("Главное меню 🔰", "menuru"),
                        InlineKeyboardButton.WithCallbackData ("Онлайн курсы","onru"),
                    },
                    new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData ("Подписаться на курс","Kryru"),
                    },
                }
            );
            return keyboard;
        }

        public static InlineKeyboardMarkup bos3ru(string course)
        {
            
            var keyboard = new InlineKeyboardMarkup
            (
                new InlineKeyboardButton[][]
                {

                    new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData("Главное меню 🔰", "menuru"),
                        InlineKeyboardButton.WithCallbackData ("Офлайн курсы","ofru"),
                    },
                    new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData ("Подписаться на курс",course),
                        
                    },
                }
            );
            return keyboard;
        }

    public static InlineKeyboardMarkup Greeting2ru()
        {
            var keyboard = new InlineKeyboardMarkup
            (
                new InlineKeyboardButton[][]
                {

                    new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData ("Изменить язык 🔄🔁","changelangru"),

                        InlineKeyboardButton.WithCallbackData("Изменить контакты 🔄🔁", "changephoneru"),
                    },
                    new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData("Главное меню 🔰", "menuru"),
                    },
                }
            );
            return keyboard;
        }
}




