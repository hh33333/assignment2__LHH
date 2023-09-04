﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace assignment.Model
{
    class TifFileInfo : INotifyPropertyChanged
    {
        public string[] filePath;
        public TiffBitmapDecoder imageFile;
        private int imageNumSave;

        public int imageNum
        {
            get { return imageNumSave; }

            set
            {
                if (imageNumSave != value)
                {
                    imageNumSave = value;
                    OnPropertyChanged("imageNum");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
