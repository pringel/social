﻿using System;
using mobSocial.WebApi.Configuration.Mvc.Models;

namespace mobSocial.WebApi.Models.Conversation
{
    public class ConversationReplyModel : RootModel
    {
        public string ReplyText { get; set; }

        public int UserId { get; set; }

        public DateTime DateCreatedUtc { get; set; }

        public DateTime DateCreatedLocal { get; set; }
    }
}