using CrapsGame;
using GameModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GameModels
{
    public class Player :INPC
    {
        public Player()
        {
            Games = new ObservableListSource<Game>();
        }

        private int _id;
        private string _name;
        private ObservableListSource<Game> _games;
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

        public string Name
        {
            get { return _name; }
            set
            {
                if (_name == value) return;
                _name = value;
                NotifyPropertyChanged();
            }
        }

       
        public ObservableListSource<Game> Games
        {
            get => _games;
            set
            {
                if (_games == value) return;
                _games = value;
                NotifyPropertyChanged();
            }
        }


    }
}
