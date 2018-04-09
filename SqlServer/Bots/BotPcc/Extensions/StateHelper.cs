using Microsoft.Bot.Builder.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LuisBot.Extensions
{
    public class StateHelper
    {
        public static void SetUserLanguageCode(IDialogContext context, string languageCode)
        {
            try
            {
                context.UserData.SetValue("LanguageCode", languageCode);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}