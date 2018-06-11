using CrapsGame;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GameModels
{
    public class Game : INPC
    {

        private int _id;

        private bool _firstToss;
        private int _point;
        private DiceRoll _rollInProgress;
        private Player _player;
        private int _playerId;
        private ObservableListSource<DiceRoll> _diceRolls;


        public Game()
        {
            DiceRolls = new ObservableListSource<DiceRoll>();
            RollInProgress = new DiceRoll();
            FirstToss = true;
           
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
       
        public Player Player
        {
            get => _player;
            set
            {
                if (_player == value) return;
                _player = value;
                NotifyPropertyChanged();
            }
        }
        public int PlayerId
        {
            get => _playerId;
            set
            {
                if (_playerId == value) return;
                _playerId = value;
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

          public ObservableListSource<DiceRoll> DiceRolls
        {
            get { return _diceRolls; }
            set
            {
                if (_diceRolls == value) return;
                _diceRolls = value;
                NotifyPropertyChanged();
            }
        }
      

    }
}
