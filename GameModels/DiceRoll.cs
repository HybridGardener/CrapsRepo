﻿namespace GameModels
{
    public class DiceRoll : INPC
    {
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

        public int Sum()
        {

            return DieOne + DieTwo;
        }
    }
}