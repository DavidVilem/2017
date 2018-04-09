using System;
using System.Threading.Tasks;
using LuisBot.Utilities;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using System.Diagnostics;
using LuisBot.Extensions;
using System.Configuration;
using Microsoft.Bot.Connector;
using System.Collections.Generic;

namespace LuisBot.Dialogs
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
        [LuisIntent("Public")]
        public async Task Public(IDialogContext context, LuisResult result)
        {

            var response = ChatResponse.Public;

            await context.PostAsync(response.ToUserLocale(context));

            context.Wait(MessageReceived);

            var reply = context.MakeMessage();
            reply.Attachments.Add(GetCard());
            await Task.Delay(2000);
            await context.PostAsync(reply);

        }

        [LuisIntent("Office")]
        public async Task Office(IDialogContext context, LuisResult result)
        {
            var response = ChatResponse.Office;

            await context.PostAsync(response.ToUserLocale(context));

            context.Wait(MessageReceived);


        }

        [LuisIntent("None")]
        public async Task None(IDialogContext context, LuisResult result)
        {

            var response = ChatResponse.None;

            await context.PostAsync(response.ToUserLocale(context));

            context.Wait(MessageReceived);

        }

        [LuisIntent("News")]
        public async Task News(IDialogContext context, LuisResult result)
        {
            var response = ChatResponse.News;

            await context.PostAsync(response.ToUserLocale(context));

            context.Wait(MessageReceived);


        }

        [LuisIntent("Meetings")]
        public async Task Meetings(IDialogContext context, LuisResult result)
        {

            var response = ChatResponse.Meetings;

            await context.PostAsync(response.ToUserLocale(context));

            context.Wait(MessageReceived);


        }


        [LuisIntent("Parking")]
        public async Task Parking(IDialogContext context, LuisResult result)
        {

            var response = ChatResponse.Parking;

            await context.PostAsync(response.ToUserLocale(context));

            context.Wait(MessageReceived);


        }

        [LuisIntent("Gym")]
        public async Task Gym(IDialogContext context, LuisResult result)
        {
            var response = ChatResponse.Gym;

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

        [LuisIntent("Deposit")]
        public async Task Deposit(IDialogContext context, LuisResult result)
        {

            var response = ChatResponse.Deposit;

            await context.PostAsync(response.ToUserLocale(context));

            context.Wait(MessageReceived);


        }

        [LuisIntent("Areas")]
        public async Task Areas(IDialogContext context, LuisResult result)
        {

            var response = ChatResponse.Areas;

            await context.PostAsync(response.ToUserLocale(context));

            context.Wait(MessageReceived);


        }

        [LuisIntent("Administration")]
        public async Task Administration(IDialogContext context, LuisResult result)
        {

            var response = ChatResponse.Administration;

            await context.PostAsync(response.ToUserLocale(context));

            context.Wait(MessageReceived);


        }

        [LuisIntent("Mascots")]
        public async Task Mascots(IDialogContext context, LuisResult result)
        {

            var response = ChatResponse.Mascots;

            await context.PostAsync(response.ToUserLocale(context));

            context.Wait(MessageReceived);

            var reply = context.MakeMessage();
            reply.Attachments.Add(GetCard());
            await Task.Delay(2000);
            await context.PostAsync(reply);


        }
        [LuisIntent("Creator")]
        public async Task Creator(IDialogContext context, LuisResult result)
        {

            var response = ChatResponse.Creator;

            await context.PostAsync(response.ToUserLocale(context));

            context.Wait(MessageReceived);

        }
        [LuisIntent("Name")]
        public async Task Name(IDialogContext context, LuisResult result)
        {

            var response = ChatResponse.Name;

            await context.PostAsync(response.ToUserLocale(context));

            context.Wait(MessageReceived);

        }

        private Attachment GetCard()
        {
            var card = new HeroCard
            {
                Title = "Manuales de convivencia",
                Buttons = new List<CardAction>
                {
                    new CardAction(type: ActionTypes.OpenUrl, title:"Ir a la web", value:"https://www.facebook.com/profile.php?id=100014109790057")
                }
            };
            return card.ToAttachment();
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