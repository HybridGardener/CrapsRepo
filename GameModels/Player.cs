using GameModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameModels
{
    public class Player : INPC
    {
        private int _id;
        private int _name;

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

    }
}
