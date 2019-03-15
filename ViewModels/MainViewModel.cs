using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Velyka1.Models;

namespace Velyka1.ViewModels
{
    class MainViewModels : INotifyPropertyChanged
    {

        private DateTime? _birthday;


        private string _sunSign;
        private string _chineseSign;

        private string _age;

        private string _wishes;

        public DateTime? Birthday
        {
            get { return _birthday; }
            set
            {
                DateTime BirthdayTime = value ?? DateTime.Now;

                Person person = new Person(BirthdayTime);
               
                if (person.Age() < 135&&person.Age()>0)
                {
                    Procced(person);
                }
                else
                {
                    MessageBox.Show("error");
                }

                _birthday = value;
                NotifyPropertyChanged();


            }
        }

        async void InitFullStack(Person p)
        {

            await Task.Run(() => Age = p.Age().ToString());
        }

        public async void Procced(Person p)
        {
            await Task.Run(() => ProccedMethod(p));
        }

        void ProccedMethod(Person p)
        {
            SunSign = p.sunSign();
            ChineseSign = p.chineseSign();
            if (p.isBirthday())
            {
                Wishes = "Best wishes";
            }
            else
            {

                Wishes = "";

            }

            Age = p.Age().ToString();

        }

        public string SunSign
        {
            get { return _sunSign; }
            set
            {
                _sunSign = value;
                NotifyPropertyChanged();
            }
        }

        public string ChineseSign
        {
            get { return _chineseSign; }
            set
            {
                _chineseSign = value;
                NotifyPropertyChanged();
            }
        }

        public string Wishes
        {
            get { return _wishes; }
            set
            {
                _wishes = value;
                NotifyPropertyChanged();
            }
        }


        public string Age
        {
            get { return _age; }
            set
            {
                _age = value;
                NotifyPropertyChanged();
            }
        }











        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged(
            [CallerMemberName] String propertyName = "")
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
