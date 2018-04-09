using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Bot.Builder.Dialogs;

namespace Bot02.Models
{
    public class AddressKey : IAddress
    {
        public string BotId { get; set; }
        public string ChannelId { get; set; }
        public string ConversationId { get; set; }
        public string ServiceUrl { get; set; }
        public string UserId { get; set; }
    }
}