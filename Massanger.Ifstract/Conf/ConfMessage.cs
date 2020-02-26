using Messanger.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Messanger.Ifstract.Conf
{
    public class ConfMessage : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.HasKey(q => q.Id);
            builder.HasOne(q => q.UserConversation)
                .WithMany(q => q.Messages)
                .HasForeignKey(q => new { q.UserId, q.ConversationId });
        }
    }
}
