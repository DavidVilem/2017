using Bot02.Translator;
using Bot02.Utilities;
using Microsoft.Bot.Builder.Dialogs;


namespace Bot02.Extensions
{
    public static class StringExtensions
    {
        public static string ToUserLocale(this string text, IDialogContext context)
        {

            context.UserData.TryGetValue(StringConstants.UserLanguageKey, out string userLanguageCode);

            text = TranslationHandler.TranslateText(text, StringConstants.DefaultLanguage, userLanguageCode);

            return text;
        }
    }
}