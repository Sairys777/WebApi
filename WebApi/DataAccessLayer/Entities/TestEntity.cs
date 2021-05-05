using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace WebApi.DataAccessLayer.Entities
{
	public class TestEntity
	{
		public Guid Id { get; set; }

		public string Descrpition { get; set; }
	}

	public class TestEntityConfiguration : IEntityTypeConfiguration<TestEntity>
	{
		public void Configure(EntityTypeBuilder<TestEntity> builder)
		{
			builder.Property(it => it.Descrpition)
				.HasMaxLength(100)
				.IsRequired();
		}
	}
}
