using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StreetWorkout.Data.Models;

namespace StreetWorkout.Data.ModelMaps
{
    public class ProgramEntityTypeConfiguration : IEntityTypeConfiguration<Program>
    {
        public void Configure(EntityTypeBuilder<Program> builder)
        {
            builder.ToTable("Programs");
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

            builder.Property(x => x.Description)
                .HasColumnName("Description")
                .HasColumnType("nvarchar(400)")
                .IsRequired();

            builder.Property(x => x.Difficulty)
                .HasColumnName(@"Difficulty")
                .HasColumnType("smallint")
                .IsRequired();

            builder
                .HasMany(x => x.ProgramTrainings)
                .WithOne(x => x.Program)
                .HasForeignKey(x => x.TrainingId);

            builder.HasData(
                new Program
                {
                    Id = 1,
                    Name = "Begginers luck",
                    Description = "A program everyone should start with."
                });
        }
    }
}
