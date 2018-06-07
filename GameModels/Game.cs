using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace GameModels
{
    public class Game : INPC
    {

        private int _id;
        private int _name;
        private ObservableCollection<DiceRoll> _rollsInGame;
        private bool _firstToss;
        private int _point;

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
            set {
                if (_point == value) return;
                _point = value;
                NotifyPropertyChanged();
            }

        }
        public ObservableCollection<DiceRoll> RollsInGame
        {
            get { return _rollsInGame; }
            set
            {
                if (_rollsInGame == value) return;
                _rollsInGame = value;
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
        public void shoot()
        {
            var dice = new DiceRoll();
            var sum = dice.Sum();
            if (FirstToss)
            {
                if (sum == 7 || sum == 11)
                {
                    dice.GameState = GameStateEnum.Winner;

                }
                else if (sum == 2 || sum == 3 || sum == 12)
                {
                    dice.GameState = GameStateEnum.Craps;

                }
                else if (sum == 4 || sum == 5 || sum == 6 || sum == 7 || sum == 9 || sum == 10)
                {
                    Point = sum;
                    dice.GameState = GameStateEnum.SetPoint;

                }
            }
            else
            {
                if (sum == Point)
                {
                    dice.GameState = GameStateEnum.Winner;
                }
              else if (sum == 2 || sum == 3 || sum == 12)
                {
                    dice.GameState = GameStateEnum.Craps;

                }
                if (sum == 7 ||sum ==12)
                {
                    dice.GameState = GameStateEnum.Craps;
                }
                else if (sum == 4 || sum == 5 || sum == 6 || sum == 7 || sum == 9 || sum == 10)
                {
                    Point = sum;
                    dice.GameState = GameStateEnum.SetPoint;

                }
            }

        } 
    }
}
