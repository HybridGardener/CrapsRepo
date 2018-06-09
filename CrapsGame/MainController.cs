using CrapsGame.EF;
using GameModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrapsGame
{
    public class MainController : INPC
    {

        private Player _selectedPlayer;
        private Game _currentGame;
        private BindingList<Player> _players;
        private Player _newPlayer;
        public MainController()
        {
            this.CurrentGame = new Game();
            this.NewPlayer = new Player();
            Players = new BindingList<Player>();
            LoadUi();
            SelectedPlayer = Players.FirstOrDefault();
        }
        public Player NewPlayer
        {
            get { return _newPlayer; }
            set
            {
                if (_newPlayer == value) return;
                _newPlayer = value;
                NotifyPropertyChanged();
            }
        }
        public Player SelectedPlayer
        {
            get { return _selectedPlayer; }
            set
            {
                if (_selectedPlayer == value) return;
                _selectedPlayer = value;
                NotifyPropertyChanged();
            }
        }
        public Game CurrentGame
        {
            get { return _currentGame; }
            set
            {
                if (_currentGame == value) return;
                _currentGame = value;
                NotifyPropertyChanged();
            }
        }
        public BindingList<Player> Players
        {
            get { return _players; }
            set
            {
                if (_players == value) return;
                _players = value;
                NotifyPropertyChanged();
            }
        }
        internal async void CreateNewUser()
        {
            using (var ctx = new GameContext())
            {
                ctx.Players.Add(NewPlayer);
                await ctx.SaveChangesAsync();
            }
            Players.Add(NewPlayer);
            SelectedPlayer = new Player()
            {
                Id = NewPlayer.Id,
                Games = NewPlayer.Games,
                Name = NewPlayer.Name
            };

            NewPlayer = new Player();
        }
        private void LoadUi()
        {
            var people = new List<Player>();
            var games = new List<Game>();

            using (var ctx = new GameContext())
            {
                people = ctx.Players.ToList();

                foreach (var player in people)
                {
                    ctx.Entry(player).Collection(p => p.Games).Load();
                    Players.Add(player);
                }

            }
        }

        public  async void SaveGame(Game currentGame)
        {
            using (var ctx = new GameContext())
            {
               
                ctx.Games.Add(currentGame);
                await ctx.SaveChangesAsync();
            }
        }

        internal void SetSelectedGame(object value)
        {
            var Game = (value as Game);
            CurrentGame = Game;

        }

    }
}
