using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StreetWorkout.Data.Models;

namespace StreetWorkout.Data.ModelMaps
{
    public class EquipmentEntityTypeConfiguration : IEntityTypeConfiguration<Equipment>
    {
        public void Configure(EntityTypeBuilder<Equipment> builder)
        {
            builder.ToTable("Equipment");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.Property(x => x.Name)
                .HasColumnName(@"Name")
                .HasColumnType("nvarchar(40)")
                .IsRequired();

            builder
                .HasMany(x => x.Exercises)
                .WithMany(x => x.Equipment);

            builder.HasData(
                new Equipment
                {
                    Id = 1,
                    Name = "Dumbells"
                },
                new Equipment
                {
                    Id = 2,
                    Name = "Pull up bar"
                },
                new Equipment
                {
                    Id = 3,
                    Name = "Rings"
                },
                new Equipment
                {
                    Id = 4,
                    Name = "Training bands"
                });
        }
    }
}
