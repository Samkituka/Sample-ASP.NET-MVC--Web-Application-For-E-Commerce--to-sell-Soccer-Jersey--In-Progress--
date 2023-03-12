﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SoccerJerseyPass.Data;

#nullable disable

namespace SoccerJerseyPass.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CoachSoccer_Jersey", b =>
                {
                    b.Property<int>("CoachId")
                        .HasColumnType("int");

                    b.Property<int>("coachesId")
                        .HasColumnType("int");

                    b.HasKey("CoachId", "coachesId");

                    b.HasIndex("coachesId");

                    b.ToTable("CoachSoccer_Jersey");
                });

            modelBuilder.Entity("LeagueSoccer_Jersey", b =>
                {
                    b.Property<int>("LeagueId")
                        .HasColumnType("int");

                    b.Property<int>("leaguesId")
                        .HasColumnType("int");

                    b.HasKey("LeagueId", "leaguesId");

                    b.HasIndex("leaguesId");

                    b.ToTable("LeagueSoccer_Jersey");
                });

            modelBuilder.Entity("SoccerJerseyPass.Models.Coach", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePictureURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Coaches");
                });

            modelBuilder.Entity("SoccerJerseyPass.Models.League", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Leagues");
                });

            modelBuilder.Entity("SoccerJerseyPass.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePictureURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("SoccerJerseyPass.Models.Player_Jersey", b =>
                {
                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int>("Soccer_JerseyId")
                        .HasColumnType("int");

                    b.HasKey("PlayerId", "Soccer_JerseyId");

                    b.HasIndex("Soccer_JerseyId");

                    b.ToTable("Player_Jerseys");
                });

            modelBuilder.Entity("SoccerJerseyPass.Models.Soccer_Jersey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Club")
                        .HasColumnType("int");

                    b.Property<int>("CoachId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LeagueId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sleeve")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Soccer_Jerseys");
                });

            modelBuilder.Entity("CoachSoccer_Jersey", b =>
                {
                    b.HasOne("SoccerJerseyPass.Models.Soccer_Jersey", null)
                        .WithMany()
                        .HasForeignKey("CoachId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SoccerJerseyPass.Models.Coach", null)
                        .WithMany()
                        .HasForeignKey("coachesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LeagueSoccer_Jersey", b =>
                {
                    b.HasOne("SoccerJerseyPass.Models.Soccer_Jersey", null)
                        .WithMany()
                        .HasForeignKey("LeagueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SoccerJerseyPass.Models.League", null)
                        .WithMany()
                        .HasForeignKey("leaguesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SoccerJerseyPass.Models.Player_Jersey", b =>
                {
                    b.HasOne("SoccerJerseyPass.Models.Player", "player")
                        .WithMany("player_Jersey")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SoccerJerseyPass.Models.Soccer_Jersey", "soccerjersey")
                        .WithMany("PlayerJersey")
                        .HasForeignKey("Soccer_JerseyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("player");

                    b.Navigation("soccerjersey");
                });

            modelBuilder.Entity("SoccerJerseyPass.Models.Player", b =>
                {
                    b.Navigation("player_Jersey");
                });

            modelBuilder.Entity("SoccerJerseyPass.Models.Soccer_Jersey", b =>
                {
                    b.Navigation("PlayerJersey");
                });
#pragma warning restore 612, 618
        }
    }
}