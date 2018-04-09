using System;
using System.Configuration;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using Microsoft.Bot.Connector;

namespace Bot01.Dialogs
{
    [Serializable]
    public class RootDialog : LuisDialog<object>
    {
        public RootDialog() : base(new LuisService(new LuisModelAttribute(
            ConfigurationManager.AppSettings["LuisAppId"],
            ConfigurationManager.AppSettings["LuisAPIKey"],
            domain: ConfigurationManager.AppSettings["LuisAPIHostName"])))
        {
        }

        [LuisIntent("None")]
        public async Task NoneIntent(IDialogContext context, LuisResult result)
        {
            var response = Respuesta.None;

            await context.PostAsync(response);
            //await this.ShowLuisResult(context, result);
        }

        // Go to https://luis.ai and create a new intent, then train/publish your luis app.
        // Finally replace "Gretting" with the name of your newly created intent in the following handler
        [LuisIntent("busq_usu")]
        public async Task GreetingIntent(IDialogContext context, LuisResult result)
        {
            var response = Respuesta.Usuario;

            await context.PostAsync(response);
        }

        [LuisIntent("busq_ofi")]
        public async Task CancelIntent(IDialogContext context, LuisResult result)
        {
            var response = Respuesta.Empleo;

            await context.PostAsync(response);
        }

        [LuisIntent("busq_gim")]
        public async Task HelpIntent(IDialogContext context, LuisResult result)
        {
            var response = Respuesta.Deporte;

            await context.PostAsync(response);
        }

        //private async Task ShowLuisResult(IDialogContext context, LuisResult result) 
        //{
        //    await context.PostAsync($"You have reached {result.Intents[0].Intent}. You said: {result.Query}");
        //    context.Wait(MessageReceived);
        //}

    }
}