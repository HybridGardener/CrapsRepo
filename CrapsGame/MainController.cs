using CrapsGame.EF;
using GameModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrapsGame
{
    public class MainController : INPC
    {

        private Player _selectedPlayer;
        private Game _currentGame;
        private ObservableListSource<Player> _players;
        private Player _newPlayer;
        private string _gameState;
        private int _wins;
        private int _losses;
        public static readonly Random numberGenerator = new Random();

        public MainController()
        {

            this.NewPlayer = new Player();
            Players = new ObservableListSource<Player>();
            GameState = "New Game!";
            LoadPlayers();
            if (!Players.Any())
            {
                SelectedPlayer = NewPlayer;
            }
            else
            {
                var x = Players.FirstOrDefault();
                SetSelectedPlayer(x);
            }
            this.CurrentGame = new Game();
        }
        public void LoadPlayers()
        {
            using (var ctx = new GameContext())
            {
                var players = ctx.Players.ToList();
                if (!players.Any()) return;
                var pBL = new ObservableListSource<Player>();

                foreach (Player player in players)
                {
                    ctx.Entry(player).Collection(p => p.Games).Load();
                    foreach (var roll in player.Games)
                    {
                        ctx.Entry(roll).Collection(p => p.DiceRolls).Load();
                    }
                    var gBL = new ObservableListSource<Game>();
                    pBL.Add(player);
                    Players = pBL;
                }
            }
        }
        public string GameState
        {
            get => _gameState;
            set
            {
                if (_gameState == value) return;
                _gameState = value;
                NotifyPropertyChanged();
            }
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
        public ObservableListSource<Player> Players
        {
            get { return _players; }
            set
            {
                if (_players == value) return;
                _players = value;
                NotifyPropertyChanged();
            }
        }
        public int Wins
        {
            get => _wins;
            set
            {
                if (_wins == value) return;
                _wins = value;
                NotifyPropertyChanged();
            }
        }
        public int Losses
        {
            get => _losses;
            set
            {
                if (_losses == value) return;
                _losses = value;
                NotifyPropertyChanged();
            }
        }
        internal void CreateNewUser()
        {
            using (var ctx = new GameContext())
            {
                if (NewPlayer.Id == 0)
                {

                    ctx.Players.Add(NewPlayer);
                    ctx.SaveChanges();
                    Players.Add(NewPlayer);
                }
                else
                {
                    var player = ctx.Players.FirstOrDefault(p => p.Id == NewPlayer.Id);
                    if (player == null) return;
                    player.Name = NewPlayer.Name;
                    ctx.SaveChanges();

                }

                NewPlayer = new Player();

            }
        }
    
        internal void SetSelectedGame(object value)
        {
            var Game = (value as Game);
            if (Game == null) return;
            CurrentGame = Game;



        }
        internal void DeletePlayer()
        {

            using (var ctx = new GameContext())
            {
                var x = ctx.Players.ToList().FirstOrDefault(p => p.Id == SelectedPlayer.Id);
                if (x == null) return;
                foreach (var g in x.Games.ToList())
                {
                    foreach (var dr in g.DiceRolls.ToList())
                    {
                        ctx.DiceRolls.Remove(dr);
                    }
                    ctx.Games.Remove(g);
                }
                ctx.Players.Remove(x);
                Players.Remove(x);
                ctx.SaveChanges();
                SelectedPlayer = Players.FirstOrDefault();
            }

        }
        internal void ClearPlayerGames()
        {
            using (var ctx = new GameContext())
            {
                var x = ctx.Players.ToList().FirstOrDefault(p => p.Id == SelectedPlayer.Id);
                ctx.Entry(x).Collection(p => p.Games).Load();

                if (x == null) return;
                foreach (var g in x.Games.ToList())
                {
                    ctx.Entry(g).Collection(p => p.DiceRolls).Load();
                    ctx.Games.Remove(g);
                }
                ctx.SaveChanges();
            }
        }
        internal void EditPlayer()
        {

            using (var ctx = new GameContext())
            {
                var x = ctx.Players.ToList().FirstOrDefault(p => p.Id == SelectedPlayer.Id);
                if (x == null) return;
                NewPlayer = x;

            }
        }
        internal void SetSelectedPlayer(object obj)
        {
            var player = (obj as Player);
            if (player == null) return;
            if (SelectedPlayer != null && SelectedPlayer.Id == player.Id) return;
            SelectedPlayer = player;
            SetSelectedGame(new Game() { Player = player });
        }
        internal void Shoot()
        {
            var rollInProgress = new DiceRoll() { Game = CurrentGame };
            rollInProgress.DieOne = numberGenerator.Next(1, 6);
            rollInProgress.DieTwo = numberGenerator.Next(1, 6);
            var sum = rollInProgress.Sum();
            if (CurrentGame.FirstToss)
            {
                if (sum == 7 || sum == 11)
                {
                    rollInProgress.GameState = GameStateEnum.Winner;

                }
                else if (sum == 2 || sum == 3 || sum == 12)
                {
                    rollInProgress.GameState = GameStateEnum.Craps;

                }
                else if (sum == 4 || sum == 5 || sum == 6 || sum == 8 || sum == 9 || sum == 10)
                {
                    CurrentGame.Point = sum;
                    rollInProgress.GameState = GameStateEnum.SetPoint;
                }
            }
            else
            {
                if (sum == CurrentGame.Point)
                {
                    rollInProgress.GameState = GameStateEnum.Winner;
                }
                else if (sum == 2 || sum == 3 || sum == 12)
                {
                    rollInProgress.GameState = GameStateEnum.Craps;

                }
                else if (sum == 4 || sum == 5 || sum == 6 || sum == 8 || sum == 9 || sum == 10)
                {
                    CurrentGame.Point = sum;
                    rollInProgress.GameState = GameStateEnum.SetPoint;
                }
                else if (sum == 7 || sum == 11)
                {
                    rollInProgress.GameState = GameStateEnum.Craps;
                }
            }
            CurrentGame.RollInProgress = rollInProgress;
            switch (CurrentGame.RollInProgress.GameState)
            {
                case GameStateEnum.Craps:
                    GameState = "Craps";
                    CurrentGame.Point = 0;
                    break;
                case GameStateEnum.SetPoint:
                    GameState = "New Point Set";
                    return;
                case GameStateEnum.Winner:
                    GameState = $"{SelectedPlayer.Name} has won!";
                    CurrentGame.Point = 0;
                    break;
            }
            EFSave(rollInProgress);
            
        }
        private void EFSave(DiceRoll rollInProgress)
        {
            using (var ctx = new GameContext())
            {
                var existingPlayer = ctx.Players.Where(p => p.Id == SelectedPlayer.Id).FirstOrDefault();
                if (existingPlayer == null)
                {
                    ctx.Players.Add(SelectedPlayer);
                    ctx.SaveChanges();
                }
                else
                {
                    var existingGame = existingPlayer.Games.Where(p => p.Id == CurrentGame.Id).FirstOrDefault();

                    if (existingGame == null)
                    {
                        CurrentGame.Player = existingPlayer;
                        ctx.Games.Add(CurrentGame);
                        ctx.DiceRolls.Add(rollInProgress);
                        ctx.SaveChanges();
                    }
                    else
                    {
                        existingGame.Player = existingPlayer;
                        ctx.DiceRolls.Add(rollInProgress);
                        ctx.SaveChanges();

                    }
                }


            }
        }

    }
}

