using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ckoklg.Domain.Entities;

namespace Ckoklg.Data.Mappings
{
	public class ProfileMap : IEntityTypeConfiguration<Profile>
    {
        public void Configure(EntityTypeBuilder<Profile> builder)
        {
            builder.HasKey(key => key.Id);
        }
    }
}
