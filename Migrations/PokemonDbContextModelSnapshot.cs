﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using kwFinalProject.models;

namespace kwFinalProject.Migrations
{
    [DbContext(typeof(PokemonDbContext))]
    partial class PokemonDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("kwFinalProject.models.User", b =>
                {
                    b.Property<int>("userID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("attack")
                        .HasColumnType("INTEGER");

                    b.Property<int>("defense")
                        .HasColumnType("INTEGER");

                    b.Property<string>("pokeName")
                        .HasColumnType("TEXT");

                    b.Property<int>("spAttack")
                        .HasColumnType("INTEGER");

                    b.Property<int>("spDefense")
                        .HasColumnType("INTEGER");

                    b.Property<int>("speed")
                        .HasColumnType("INTEGER");

                    b.HasKey("userID");

                    b.ToTable("Pokemons");
                });
#pragma warning restore 612, 618
        }
    }
}
