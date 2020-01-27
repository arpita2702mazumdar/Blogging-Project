using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloggingAPI.Model
{
    public class BlogContext: DbContext
    {
        private string _connectionString;
        public BlogContext(string connectionString)
        {
            _connectionString = connectionString;
        }
        public BlogContext(DbContextOptions<BlogContext> options)
            : base(options)
        {
        }
        public DbSet<Blogmodel> blogs { get; set; }
        public DbSet<Comments> comments { get; set; }
        public DbSet<UserDetails> userDetails { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./blog.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Comments
            modelBuilder.Entity<Comments>(entity =>
            {
                entity.Property(e => e.id).HasColumnName("id");

                entity.Property(e => e.userId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.commentContent)
                    .HasMaxLength(20)
                    .IsUnicode(false);
                entity.Property(e => e.blogId).HasColumnName("blogId");
                entity.HasOne(d => d.blogs)
                    .WithMany(p => p.comments)
                    .HasForeignKey(d => d.blogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Comments__BlogId__01142BA1");
            });
            #endregion
            #region Blogs
            modelBuilder.Entity<Blogmodel>(entity =>
            {
                entity.Property(e => e.id).HasColumnName("id");

                entity.Property(e => e.userId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.blogContent)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });
            #endregion
            #region Blogs
            modelBuilder.Entity<UserDetails>(entity =>
            {
                entity.Property(e => e.id).HasColumnName("id");

                entity.Property(e => e.username)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.password)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });
            #endregion
        }
    }
}
