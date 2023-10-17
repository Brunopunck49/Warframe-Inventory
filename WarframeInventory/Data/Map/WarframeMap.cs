using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WarframeInventory.Models;

namespace WarframeInventory.Data.Map
{
    public class WarframeMap : IEntityTypeConfiguration<WarframeModel>
    {
        public void Configure(EntityTypeBuilder<WarframeModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Status).IsRequired();
        }
    }
}
