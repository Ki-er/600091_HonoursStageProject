﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FeedbackToolDissertation.Data.FeedbackToolDissertation
{
    public class FeedbacktooldissertationContext : DbContext
    {

        public FeedbacktooldissertationContext(DbContextOptions<FeedbacktooldissertationContext> options)
            : base(options)
        { }

        public virtual DbSet<Acw> Acw { get; set; }
        public virtual DbSet<Criteria> Criteria { get; set; }
        public virtual DbSet<Feedback> Feedback { get; set; }
        public virtual DbSet<Modules> Modules { get; set; }
        public virtual DbSet<Sections> Sections { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            modelBuilder.Entity<Acw>(entity =>
            {
                entity.ToTable("ACW");

                entity.Property(e => e.AcwName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.ModuleName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Criteria>(entity =>
            {
                entity.Property(e => e.Acwname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("ACWName")
                    .IsFixedLength();

                entity.Property(e => e.Criteria1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Criteria")
                    .IsFixedLength();

                entity.Property(e => e.ModuleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.SectionName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.Property(e => e.Acwname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("ACWName")
                    .IsFixedLength();

                entity.Property(e => e.Criteria)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Feedback1)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("Feedback")
                    .IsFixedLength();

                entity.Property(e => e.ModuleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.SectionName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Modules>(entity =>
            {
                entity.Property(e => e.ModuleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Sections>(entity =>
            {
                entity.Property(e => e.Acwname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("ACWName")
                    .IsFixedLength();

                entity.Property(e => e.ModuleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.SectionName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

        }

    }
}