using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using CharacterSheetApp.Models;

namespace CharacterSheetApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CharacterSheetApp.Models.Character", b =>
                {
                    b.Property<string>("Name");

                    b.Property<int>("Dexterity");

                    b.Property<int>("Intelligence");

                    b.Property<bool>("IsActive");

                    b.Property<int>("Level");

                    b.Property<int>("Strength");

                    b.HasKey("Name");

                    b.ToTable("Character");
                });
        }
    }
}
