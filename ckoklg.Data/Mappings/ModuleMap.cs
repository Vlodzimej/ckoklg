using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ckoklg.Domain.Entities;

namespace Ckoklg.Data.Mappings
{
	public class ModuleMap : IEntityTypeConfiguration<Module>
    {
        public void Configure(EntityTypeBuilder<Module> builder)
        {
            builder.HasKey(key => key.Id);
        }
    }
}
