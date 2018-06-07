using System;

namespace CrapsGame.Models
{
    public class DiceRoll : INPC
    {
        private static readonly Random randomNumberGenerator = new Random();
        private int _id;
        private int _dieOne;
        private int _dieTwo;
        private GameStateEnum _gameState;

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id == value) return;
                _id = value;
                NotifyPropertyChanged();

            }
        }

        public int DieOne
        {
            get {return _dieOne; }
            set {
                if (_dieOne == value) return;
                _dieOne = value;
                NotifyPropertyChanged();
            }
            
        }

        public int DieTwo
        {
            get { return _dieTwo; }
            set
            {
                if (_dieTwo == value) return;
                _dieTwo = value;
                NotifyPropertyChanged();
            }

        }

        public GameStateEnum GameState
        {
            get { return _gameState; }
            set
            {
                if (_gameState == value) return;
                _gameState = value;
                NotifyPropertyChanged();
            }

        }

        public int Roll()
        {
           DieOne= randomNumberGenerator.Next(1, 6);
           DieTwo =randomNumberGenerator.Next(1, 6);
           var sum = DieOne + DieTwo;
           return sum;

        }

       
    }
}