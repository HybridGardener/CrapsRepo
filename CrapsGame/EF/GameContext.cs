using GameModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
namespace CrapsGame.EF
{
    public class GameContext : DbContext
    {
        public GameContext() : base("CrapsGameDB")
        {
            this.Configuration.ProxyCreationEnabled = true;
            this.Configuration.AutoDetectChangesEnabled = true;
            this.Configuration.LazyLoadingEnabled = true;
            this.Configuration.ValidateOnSaveEnabled = true;
        }
        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<DiceRoll> DiceRolls { get; set; }
        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
            //modelBuilder.Entity<Player>().HasKey(k => k.Id).Property(p => p.Name).IsRequired();
            //modelBuilder.Entity<Player>().HasMany(p => p.Games).WithRequired(p => p.Player);
            //modelBuilder.Entity<Player>().Map(m =>
            //{
            //    m.ToTable("Players");
            //});
            //modelBuilder.Entity<Game>().HasKey(p => p.Id).Property(p => p.Point).IsRequired();
            //modelBuilder.Entity<Game>().HasMany(p => p.DiceRolls).WithRequired(p=>p.Game);

            //modelBuilder.Entity<Game>().Map(m =>
            //{
            //    m.ToTable("Games");
            //});
            //modelBuilder.Entity<DiceRoll>().HasKey(p => p.Id).Property(p => p.GameState).IsRequired();
            //modelBuilder.Entity<DiceRoll>().Property(p => p.DieOne).IsRequired();
            //modelBuilder.Entity<DiceRoll>().Property(p => p.DieTwo).IsRequired();
            //modelBuilder.Entity<DiceRoll>().Map(m => { m.ToTable("DiceRolls"); });
            base.OnModelCreating(modelBuilder);


        }

    }
}