﻿using LuisBot.Utilities;
using Microsoft.Bot.Connector;

namespace LuisBot.Translator
{
    public static class TranslationHandler
    {
        public static string DetectLanguage(Activity activity)
        {
            return DoLanguageDetection(activity.Text);
        }

        public static string TranslateTextToDefaultLanguage(Activity activity, string inputLanguage)
        {
            if (inputLanguage != StringConstants.DefaultLanguage)
            {
                return DoTranslation(activity.Text, inputLanguage, StringConstants.DefaultLanguage);
            }
            return activity.Text;
        }

        public static string TranslateText(string inputText, string inputLocale, string outputLocale)
        {
            return DoTranslation(inputText, inputLocale, outputLocale);
        }

        public static string DoTranslation(string inputText, string inputLocale, string outputLocale)
        {
            var translator = new Translator();
            var translation = translator.Translate(inputText, inputLocale, outputLocale);
            return translation;
        }

        public static string DoLanguageDetection(string input)
        {
            var translator = new Translator();
            return translator.Detect(input);
        }

    }
}