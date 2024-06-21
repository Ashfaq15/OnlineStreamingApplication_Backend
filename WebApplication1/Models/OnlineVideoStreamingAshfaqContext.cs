using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models;

public partial class OnlineVideoStreamingAshfaqContext : DbContext
{
    public OnlineVideoStreamingAshfaqContext()
    {
    }

    public OnlineVideoStreamingAshfaqContext(DbContextOptions<OnlineVideoStreamingAshfaqContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<BobVideosDatum> BobVideosData { get; set; }

    public virtual DbSet<Comment> Comments { get; set; }

    public virtual DbSet<Favourite> Favourites { get; set; }

    public virtual DbSet<History> Histories { get; set; }

    public virtual DbSet<Like> Likes { get; set; }

    public virtual DbSet<Rating> Ratings { get; set; }

    public virtual DbSet<UsersDatum> UsersData { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=tcp:ashfaqhussainserver.database.windows.net,1433;Initial Catalog=onlineVideoStreaming(Ashfaq);Persist Security Info=False;User ID=ashfaq;Password=Rain@asaa4;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Admin__3214EC27B2F3FFB0");

            entity.ToTable("Admin");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AdminEmail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("adminEmail");
            entity.Property(e => e.AdminName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("adminName");
            entity.Property(e => e.AdminPassword)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("adminPassword");
        });

        modelBuilder.Entity<BobVideosDatum>(entity =>
        {
            entity.HasKey(e => e.VideoId).HasName("PK__bobVideo__14B0F5B6FCA2242B");

            entity.ToTable("bobVideosData");

            entity.Property(e => e.VideoId).HasColumnName("videoId");
            entity.Property(e => e.VideoName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("videoName");
            entity.Property(e => e.VideoUrl)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("videoUrl");
        });

        modelBuilder.Entity<Comment>(entity =>
        {
            entity.HasKey(e => e.CommentId).HasName("PK__Comments__CDDE919D43C1FA5B");

            entity.Property(e => e.CommentId).HasColumnName("commentId");
            entity.Property(e => e.CommentName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("commentName");
            entity.Property(e => e.UserId).HasColumnName("userId");
            entity.Property(e => e.UserName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("userName");
            entity.Property(e => e.VideoId).HasColumnName("videoId");
            entity.Property(e => e.VideoUrl)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("videoUrl");
        });

        modelBuilder.Entity<Favourite>(entity =>
        {
            entity.HasKey(e => e.FavouriteId).HasName("PK__Favourit__5E2DB43C08BFB0EC");

            entity.ToTable("Favourite");

            entity.Property(e => e.FavouriteId).HasColumnName("favouriteId");
            entity.Property(e => e.UserId).HasColumnName("userId");
            entity.Property(e => e.UserName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("userName");
            entity.Property(e => e.VideoId).HasColumnName("videoId");
            entity.Property(e => e.VideoName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("videoName");
            entity.Property(e => e.VideoUrl)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("videoUrl");
        });

        modelBuilder.Entity<History>(entity =>
        {
            entity.HasKey(e => e.HistoryId).HasName("PK__history__19BDBDD349EC3F75");

            entity.ToTable("history");

            entity.Property(e => e.HistoryId).HasColumnName("historyId");
            entity.Property(e => e.UserId).HasColumnName("userId");
            entity.Property(e => e.UserName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("userName");
            entity.Property(e => e.VideoId).HasColumnName("videoId");
            entity.Property(e => e.VideoName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("videoName");
            entity.Property(e => e.VideoUrl)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("videoUrl");
        });

        modelBuilder.Entity<Like>(entity =>
        {
            entity.HasKey(e => e.LikeId).HasName("PK__likes__4FC592DB0D76AB5D");

            entity.ToTable("likes");

            entity.Property(e => e.LikeId).HasColumnName("likeId");
            entity.Property(e => e.UserId).HasColumnName("userId");
            entity.Property(e => e.UserName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("userName");
            entity.Property(e => e.VideoId).HasColumnName("videoId");
            entity.Property(e => e.VideoName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("videoName");
            entity.Property(e => e.VideoUrl)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("videoUrl");
        });

        modelBuilder.Entity<Rating>(entity =>
        {
            entity.HasKey(e => e.RatingId).HasName("PK__Rating__2D290CA90DAA9B8B");

            entity.ToTable("Rating");

            entity.Property(e => e.RatingId).HasColumnName("ratingId");
            entity.Property(e => e.RatingNumber).HasColumnName("ratingNumber");
            entity.Property(e => e.UserId).HasColumnName("userId");
            entity.Property(e => e.UserName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("userName");
            entity.Property(e => e.VideoId).HasColumnName("videoId");
            entity.Property(e => e.VideoName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("videoName");
            entity.Property(e => e.VideoUrl)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("videoUrl");
        });

        modelBuilder.Entity<UsersDatum>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__UsersDat__CB9A1CFF1A2CEFFC");

            entity.HasIndex(e => e.UserEmail, "UQ__UsersDat__D54ADF557E9E0B98").IsUnique();

            entity.Property(e => e.UserId).HasColumnName("userId");
            entity.Property(e => e.UserEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("userEmail");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("userName");
            entity.Property(e => e.UserPassword)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("userPassword");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
