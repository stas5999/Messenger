using System;
using System.Collections.Generic;
using System.Text;

namespace Messanger.Domain
{
    public class Message
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public UserConversation UserConversation { get; set; }

        public int UserId { get; set; }
        public int ConversationId { get; set; }
    }
}
