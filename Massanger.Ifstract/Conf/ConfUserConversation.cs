using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Messanger.Domain;

namespace Messanger.Ifstract.Conf
{
    public class ConfUserConversation : IEntityTypeConfiguration<UserConversation>
    {
        public void Configure(EntityTypeBuilder<UserConversation> builder)
        {
            builder.HasKey(q => new { q.UserId, q.ConversationId });

            builder.HasOne(q => q.User)
                .WithMany(q => q.Conversations)
                .HasForeignKey(q => q.UserId);
            builder.HasOne(q => q.Conversatin)
                .WithMany(q => q.Users)
                .HasForeignKey(q => q.ConversationId);
        }

    }
}
