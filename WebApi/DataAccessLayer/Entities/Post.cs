using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace WebApi.DataAccessLayer.Entities
{
	public class Post
	{
		public Guid Id { get; set; }
		public string Title { get; set; }
		public string Content { get; set; }
   
    }

	public class TestEntityConfiguration : IEntityTypeConfiguration<Post>
	{
		public void Configure(EntityTypeBuilder<Post> builder)
		{
			builder.Property(it => it.Title)
				.HasMaxLength(100)
				.IsRequired();
			
			builder.Property(it => it.Content)
				.HasMaxLength(100)
				.IsRequired();
		}
	}
}
