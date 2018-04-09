using System;
using System.Threading.Tasks;
using LuisBot.Utilities;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using System.Diagnostics;
using LuisBot.Extensions;
using System.Configuration;

namespace LuisBot
{
    [Serializable]
    //[LuisModel(modelID: "8e6d7fad-8435-472d-b035-09b1914575dc", subscriptionKey: "0678e43ea4ad407d85875b34ca533864", domain: "westus.api.cognitive.microsoft.com")]
    public class ChatDialog : LuisDialog<object>
    {

        public ChatDialog() : base(new LuisService(new LuisModelAttribute(
           ConfigurationManager.AppSettings["LuisAppId"],
           ConfigurationManager.AppSettings["LuisAPIKey"],
           domain: ConfigurationManager.AppSettings["LuisAPIHostName"])))
        {
        }

        [LuisIntent("None")]
        public async Task None(IDialogContext context, LuisResult result)
        {

            var response = ChatResponse.None;

            await context.PostAsync(response.ToUserLocale(context));

            context.Wait(MessageReceived);

        }

        [LuisIntent("Greeting")]
        public async Task Greeting(IDialogContext context, LuisResult result)
        {

            var response = ChatResponse.Greeting;

            await context.PostAsync(response.ToUserLocale(context));

            context.Wait(MessageReceived);


        }

        [LuisIntent("Office")]
        public async Task Farewell(IDialogContext context, LuisResult result)
        {
            var response = ChatResponse.Office;

            await context.PostAsync(response.ToUserLocale(context));

            context.Wait(MessageReceived);


        }

        [LuisIntent("Gym")]
        public async Task SwimmingPool(IDialogContext context, LuisResult result)
        {
            var response = ChatResponse.Gym;

            await context.PostAsync(response.ToUserLocale(context));

            context.Wait(MessageReceived);
        }

        //[LuisIntent("busq_gim")]
        //public async Task Location(IDialogContext context, LuisResult result)
        //{
        //    var response = ChatResponse.Deporte;

        //    await context.PostAsync(response.ToUserLocale(context));

        //    context.Wait(MessageReceived);
        //}

    }
}