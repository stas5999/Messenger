using System;
using System.Collections.Generic;
using System.Text;

namespace Messanger.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public User()
        {
            Conversations = new HashSet<UserConversation>();
        }
        public virtual ICollection<UserConversation> Conversations { get; set; }
    }
}
