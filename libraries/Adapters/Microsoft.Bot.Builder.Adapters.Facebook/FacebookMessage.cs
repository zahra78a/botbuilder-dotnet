﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Microsoft.Bot.Builder.Adapters.Facebook.FacebookEvents;

namespace Microsoft.Bot.Builder.Adapters.Facebook
{
    /// <summary>
    /// Represents the messaging structure.
    /// </summary>
    public class FacebookMessage
    {
        public FacebookMessage(string recipientId, Message message, string messagingtype, string tag = null, string notificationType = null, string personalId = null, string senderAction = null, string senderId = null)
        {
            Recipient.Id = recipientId;
            Message = message;
            MessagingType = messagingtype;
            Tag = tag;
            NotificationType = notificationType;
            PersonaId = personalId;
            SenderAction = senderAction;
            Sender.Id = senderId;
        }

        /// <summary>
        /// Gets or sets the ID of the recipient.
        /// </summary>
        /// <value>The ID of the recipient.</value>
        public FacebookBotUser Recipient { get; set; } = new FacebookBotUser();

        /// <summary>
        /// Gets or sets the ID of the sender.
        /// </summary>
        /// <value>The ID of the sender.</value>
        public FacebookBotUser Sender { get; set; } = new FacebookBotUser();

        /// <summary>
        /// Gets or sets the message to be sent.
        /// </summary>
        /// <value>The message.</value>
        public Message Message { get; set; }

        /// <summary>
        /// Gets or sets the messaging type.
        /// </summary>
        /// <value>The messaging type.</value>
        public string MessagingType { get; set; }

        /// <summary>
        /// Gets or sets a tag to the message.
        /// </summary>
        /// <value>The tag.</value>
        public string Tag { get; set; }

        /// <summary>
        /// Gets or sets the notification type.
        /// </summary>
        /// <value>The notification type.</value>
        public string NotificationType { get; set; }

        /// <summary>
        /// Gets or sets the persona ID.
        /// </summary>
        /// <value>The persona ID.</value>
        public string PersonaId { get; set; }

        /// <summary>
        /// Gets or sets the sender action.
        /// </summary>
        /// <value>The sender action.</value>
        public string SenderAction { get; set; }

        public int TimeStamp { get; set; }

        public bool Standby { get; set; }
    }
}
