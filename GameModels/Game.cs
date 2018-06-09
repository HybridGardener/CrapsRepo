using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GameModels
{
    public class Game : INPC
    {
        public static readonly Random numberGenerator = new Random();

        private int _id;
        private BindingList<DiceRoll> _rollsInGame;
        private bool _firstToss;
        private int _point;
        private DiceRoll _rollInProgress;



        public Game()
        {
            RollsInGame = new BindingList<DiceRoll>();
            RollInProgress = new DiceRoll();

        }

        public int Id
        {
            get { return _id; }
            set
            {
                if (_id == value) return;
                _id = value;
                NotifyPropertyChanged();
            }
        }
        public int Point
        {
            get { return _point; }
            set
            {
                if (_point == value) return;
                _point = value;
                NotifyPropertyChanged();
            }

        }


        public virtual BindingList<DiceRoll> RollsInGame
        {
            get { return _rollsInGame; }
            set
            {
                if (_rollsInGame == value) return;
                _rollsInGame = value;
                NotifyPropertyChanged();
            }
        }

        [NotMapped]
        public DiceRoll RollInProgress
        {
            get => _rollInProgress;
            set
            {
                if (_rollInProgress == value) return;
                _rollInProgress = value;
                NotifyPropertyChanged();
            }
        }

        public bool FirstToss
        {
            get
            {
                return _firstToss;
            }
            set
            {
                _firstToss = value;
                NotifyPropertyChanged();
            }

        }
        public void Shoot()
        {
            RollInProgress = new DiceRoll();
            RollInProgress.DieOne = numberGenerator.Next(1, 6);
            RollInProgress.DieTwo = numberGenerator.Next(1, 6);
            var sum = RollInProgress.Sum();
            if (FirstToss)
            {
                if (sum == 7 || sum == 11)
                {
                    RollInProgress.GameState = GameStateEnum.Winner;

                }
                else if (sum == 2 || sum == 3 || sum == 12)
                {
                    RollInProgress.GameState = GameStateEnum.Craps;

                }
                else if (sum == 4 || sum == 5 || sum == 6 || sum == 8 || sum == 9 || sum == 10)
                {
                    Point = sum;
                    RollInProgress.GameState = GameStateEnum.SetPoint;

                }
            }
            else
            {
                if (sum == Point)
                {
                    RollInProgress.GameState = GameStateEnum.Winner;
                }
                else if (sum == 2 || sum == 3 || sum == 12)
                {
                    RollInProgress.GameState = GameStateEnum.Craps;

                }
                if (sum == 7 || sum == 12)
                {
                    RollInProgress.GameState = GameStateEnum.Craps;
                }
                else if (sum == 4 || sum == 5 || sum == 6 || sum == 8 || sum == 9 || sum == 10)
                {
                    Point = sum;
                    RollInProgress.GameState = GameStateEnum.SetPoint;

                }
            }
            RollsInGame.Add(RollInProgress);

        }

    }
}
