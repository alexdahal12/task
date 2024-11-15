﻿// <auto-generated />
using JobCandidatesApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JobCandidatesApi.Migrations
{
    [DbContext(typeof(JobCandidatesContext))]
    [Migration("20241108141526_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("JobCandidatesApi.Models.Candidate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("GitHub")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LinkedIn")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TextComment")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Timeinterval")
                        .HasColumnType("INTEGER");

                    b.Property<string>("firstname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("lastname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Candidates");
                });
#pragma warning restore 612, 618
        }
    }
}
