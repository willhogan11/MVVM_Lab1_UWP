using System;
using MVVM_Lab1_UWP.Data;

namespace MVVM_Lab1_UWP.ViewModels
{
    public class PersonViewModel : NotificationBase<Person>
    {
        public PersonViewModel(Person person = null) : base(person) { }
        public String Name
        {
            get { return This.Name; }
            set { SetProperty(This.Name, value, () => This.Name = value); }
        }
        public int Age
        {
            get { return This.Age; }
            set { SetProperty(This.Age, value, () => This.Age = value); }
        }
        public String Address
        {
            get { return This.Address; }
            set { SetProperty(This.Address, value, () => This.Address = value); }
        }
    }
}
