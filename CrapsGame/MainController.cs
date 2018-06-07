using CrapsGame.EF;
using GameModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrapsGame
{
    public class MainController:INPC
    {
        private Player _selectedPlayer;
        private Game _currentGame;
        private ObservableCollection<Player> _players;

        public MainController()
        {
            LoadUi();
        }

        private void LoadUi()
        {
            var people = new List<Player>();
            var games = new List<Game>();

            using (var ctx = new GameContext())
            {
                people = ctx.Players.ToList();
                games = ctx.Games.ToList();


            }
        }

        public Player SelectedPlayer
        {
            get { return _selectedPlayer; }
            set {
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

        public ObservableCollection<Player> Players
        {
            get { return _players; }
            set { if (_players == value) return;
                _players = value;
                NotifyPropertyChanged();
            }
        }
    }
}
