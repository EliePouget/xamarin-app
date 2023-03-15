using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace TP3_Fichier.Data
{
    public class Citation : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string _texte;

        public string Texte {
            get { return _texte; }
            set
            {
                if (value != _texte)
                {
                    _texte = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private string _auteur;
        public string Auteur {
            get { return _auteur; }
            set
            {
                if (value != _auteur)
                {
                    _auteur = value;
                    NotifyPropertyChanged();
                }
            }
        }

    }
}
