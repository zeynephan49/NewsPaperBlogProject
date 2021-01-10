using NewspaperBlogProject.EntityLayer.Entities.Concrete;
using NewspaperBlogProject.MapLayer.Maping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperBlogProject.DataAccessLayer.Context
{
    class ProjectContext : DbContext  
    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString = @"Server=DESKTOP-C5K6QDU;Database=NewspaperBlogProject;Integrated Security=True;";
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Like> Likes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new AppUserMap());
            modelBuilder.Configurations.Add(new PostMap());
            modelBuilder.Configurations.Add(new CommentMap());
            modelBuilder.Configurations.Add(new LikeMap());

            modelBuilder.Properties<DateTime>().Configure(x => x.HasColumnType("datetime2"));
            base.OnModelCreating(modelBuilder);


        }

    }
}
