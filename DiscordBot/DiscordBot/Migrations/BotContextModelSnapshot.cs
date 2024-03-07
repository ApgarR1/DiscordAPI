﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DiscordBot.Migrations
{
    [DbContext(typeof(BotContext))]
    partial class BotContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("Profile", b =>
                {
                    b.Property<string>("ProfileID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Backpack")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("BackpackSpace")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("DiscordID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Experience")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Level")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Money")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserListID")
                        .HasColumnType("TEXT");

                    b.HasKey("ProfileID");

                    b.HasIndex("UserListID");

                    b.ToTable("Profile");
                });

            modelBuilder.Entity("UserList", b =>
                {
                    b.Property<string>("UserListID")
                        .HasColumnType("TEXT");

                    b.HasKey("UserListID");

                    b.ToTable("UserList");
                });

            modelBuilder.Entity("Profile", b =>
                {
                    b.HasOne("UserList", "UserList")
                        .WithMany("Users")
                        .HasForeignKey("UserListID");

                    b.Navigation("UserList");
                });

            modelBuilder.Entity("UserList", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
