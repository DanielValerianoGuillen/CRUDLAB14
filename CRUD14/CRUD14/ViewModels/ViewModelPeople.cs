using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CRUD14.ViewModels
{
    public class ViewModelPeople : BaseViewModel
    {
        private string color;
        public string Color
        {
            get { return this.color; }
            set { SetValue(ref this.color, value); }
        }
        private string filter;
        public string Filter
        {
            get { return this.filter; }
            set { SetValue(ref this.filter, value); }
        }
        private List<Student> people;
        public List<Student> People
        {
            get { return this.people; }
            set { SetValue(ref this.people, value); }
        }
        public ICommand SearchCommand { get; set; }
        public ViewModelPeople()
        {
            SearchCommand = new Command(() =>
            {
                StudentService service = new StudentService();
                People = service.GetByText(Filter);
                if (People.Count > 3)
                    Color = "Red";
                else
                    Color = "Blue";
            });
        }
    }
}
