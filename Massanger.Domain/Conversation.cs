using System;
using System.Collections.Generic;
using System.Text;

namespace Messanger.Domain
{
    public class Conversation
    {
        public int Id { get; set; }
        public Conversation()
        {
            Users = new HashSet<UserConversation>();
        }
        public virtual ICollection<UserConversation> Users { get; set; }
    }
}
