using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SinglePage.ORM.Data
{
    public partial class SinglePageContext : DbContext
    {
        public SinglePageContext()
        {
        }

        public SinglePageContext(DbContextOptions<SinglePageContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AboutUs> AboutUs { get; set; }
        public virtual DbSet<Contacts> Contacts { get; set; }
        public virtual DbSet<References> References { get; set; }
        public virtual DbSet<Reviews> Reviews { get; set; }
        public virtual DbSet<Services> Services { get; set; }
        public virtual DbSet<Teams> Teams { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<WhatWeDo> WhatWeDo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-DIIFQHQ\\SQLEXPRESS;Database=SinglePage;Integrated Security=True;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AboutUs>(entity =>
            {
                entity.Property(e => e.AboutUsId).HasColumnName("AboutUsID");

                entity.Property(e => e.AboutUsDescription).HasMaxLength(500);

                entity.Property(e => e.AboutUsPhoto).HasMaxLength(500);

                entity.Property(e => e.AboutUsTitle).HasMaxLength(50);
            });

            modelBuilder.Entity<Contacts>(entity =>
            {
                entity.HasKey(e => e.ContactId);

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.ContactEmail).HasMaxLength(50);

                entity.Property(e => e.ContactMessage).HasMaxLength(500);

                entity.Property(e => e.ContactName).HasMaxLength(50);

                entity.Property(e => e.ContactPhone).HasMaxLength(50);

                entity.Property(e => e.ContactSurName).HasMaxLength(50);
            });

            modelBuilder.Entity<References>(entity =>
            {
                entity.HasKey(e => e.ReferenceId);

                entity.Property(e => e.ReferenceId).HasColumnName("ReferenceID");

                entity.Property(e => e.ReferenceCategory).HasMaxLength(50);

                entity.Property(e => e.ReferenceLink).HasMaxLength(50);

                entity.Property(e => e.ReferencePhoto).HasMaxLength(500);

                entity.Property(e => e.ReferenceTitle).HasMaxLength(50);
            });

            modelBuilder.Entity<Reviews>(entity =>
            {
                entity.HasKey(e => e.ReviewId);

                entity.Property(e => e.ReviewId).HasColumnName("ReviewID");

                entity.Property(e => e.Review).HasMaxLength(500);

                entity.Property(e => e.ReviewName).HasMaxLength(50);

                entity.Property(e => e.ReviewSurName).HasMaxLength(50);
            });

            modelBuilder.Entity<Services>(entity =>
            {
                entity.Property(e => e.ServicesId).HasColumnName("ServicesID");

                entity.Property(e => e.ServicesDescription).HasMaxLength(500);

                entity.Property(e => e.ServicesPhoto).HasMaxLength(500);

                entity.Property(e => e.ServicesTitle).HasMaxLength(50);
            });

            modelBuilder.Entity<Teams>(entity =>
            {
                entity.HasKey(e => e.TeamId);

                entity.Property(e => e.TeamId).HasColumnName("TeamID");

                entity.Property(e => e.AboutTeamMember).HasMaxLength(150);

                entity.Property(e => e.TeamFacebookLink).HasMaxLength(500);

                entity.Property(e => e.TeamLinkedInLink).HasMaxLength(500);

                entity.Property(e => e.TeamMemberName).HasMaxLength(50);

                entity.Property(e => e.TeamMemberSurName).HasMaxLength(50);

                entity.Property(e => e.TeamPhoto).HasMaxLength(500);

                entity.Property(e => e.TeamTitle).HasMaxLength(50);

                entity.Property(e => e.TeamTwitterLink).HasMaxLength(500);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.Surname).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<WhatWeDo>(entity =>
            {
                entity.Property(e => e.WhatWeDoId).HasColumnName("WhatWeDoID");

                entity.Property(e => e.WhatWeDoDescription).HasMaxLength(500);

                entity.Property(e => e.WhatWeDoLink).HasMaxLength(500);

                entity.Property(e => e.WhatWeDoTitle).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
