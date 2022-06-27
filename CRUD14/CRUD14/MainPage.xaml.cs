using CRUD14.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CRUD14
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            StudentService service = new StudentService();
            List<Student> people = new List<Student>();

            people.Add(new Student { FullName = txtFullName.Text, DateOfBirthday = txtDateOfBirthday.Text, Sex = txtSex.Text });

            //service.Create(new Person { LastName = txtLastName.Text, FirstName = txtName.Text });

            service.CreateRange(people);
        }
        private void Button_Clicked_1(object sender, EventArgs e)
        {
            StudentService service = new StudentService();
            lvPeople.ItemsSource = service.Get();
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            StudentService service = new StudentService();
            lvPeople.ItemsSource = service.GetByText(txtFilter.Text.Trim());
        }
    }
}