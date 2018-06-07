using GameModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrapsGame.EF
{
    public class GameContext:DbContext
    {
        public GameContext():base("CrapsGameDB")
        {
            this.Configuration.LazyLoadingEnabled = true;
            this.Configuration.ProxyCreationEnabled = true;
            
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<DiceRoll> DiceRolls { get; set; }


    }
}
