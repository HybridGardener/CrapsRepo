using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CrapsGame.Models
{
    public class Player : INPC
    {
        private int _id;
        private int _name;
        private ObservableCollection<Game> _gamesPlayed;

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

        public int Name
        {
            get { return _name; }
            set
            {
                if (_name == value) return;
                _name = value;
                NotifyPropertyChanged();
            }
        }

        public virtual ObservableCollection<Game> GamesPlayed
        {
            get { return _gamesPlayed; }

            set
            {
                _gamesPlayed = value;
                NotifyPropertyChanged();
            }

        }

    }
}
