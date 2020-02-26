using System;
using System.Collections.Generic;
using System.Text;

namespace Messanger.Domain
{
    public class UserConversation
    {
        public int UserId { set; get; }
        public User User { get; set; }
        public int ConversationId { get; set; }
        public Conversation Conversatin { get; set; }
        public UserConversation()
        {
            Messages = new HashSet<Message>();
        }

        public virtual ICollection<Message> Messages { get; set; }
    }
}
