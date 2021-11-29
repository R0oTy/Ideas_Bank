using Ideas_Bank.Business_logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ideas_Bank.Models
{
    public class Idea : INotifyPropertyChanged
    {
        public int Id { get { return Id; } set { OnPropertyChanged("Id"); } }
        public string Description { get; set; }
        public string Caption { get; set; }
        public int Author { get; set; }
        public int Improvement { get; set; }
        public int Status { get; set; }
        public int Responsible { get; set; }
        public long InitBenefits { get; set; }
        public int History { get; set; }
        public int Effect { get; set; }
        public int Source { get; set; }
        public string Keywords { get; set; }
        public DateTime Creation_Date { get; set; }
        public DateTime Last_Date { get; set; }
        public DateTime Next_Date { get; set; }
        public static List<Idea> Get_Ideas() => Main.Run_Logic();
        private void OnPropertyChanged(string PropertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
