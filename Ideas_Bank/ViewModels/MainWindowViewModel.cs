using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ideas_Bank.Models;
using Ideas_Bank.Business_logic;

namespace Ideas_Bank.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private List<Idea> ideas;

        public List<Idea> Ideas
        {
            get { return ideas; }
            set 
            { 
                ideas = value;
                OnPropertyChanged("Ideas");
            }
        }

        public MainWindowViewModel()
        { 
            Ideas = Idea.Get_Ideas(); 
        }
        private void OnPropertyChanged(string PropertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}