using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LuisBot.Translator;
using LuisBot.Utilities;
using Microsoft.Bot.Builder.Dialogs;

namespace LuisBot.Extensions
{
    public static class StringExtensions
    {
        public static string ToUserLocale(this string text, IDialogContext context)
        {
            var userLanguajeCode = StringConstants.UserLanguageKey;
            context.UserData.TryGetValue<string>(StringConstants.UserLanguageKey, out userLanguajeCode);
            //context.UserData.TryGetValue<string>(StringConstants.UserLanguageKey, out string userLanguageCode);

            text = TranslationHandler.TranslateText(text, StringConstants.DefaultLanguage, userLanguajeCode);

            return text;
        }
    }
}