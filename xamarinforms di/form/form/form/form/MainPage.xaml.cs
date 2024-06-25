using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace form_cv
{
    public partial class MainPage : ContentPage
    {
        private int hobbyCount = 1;

        public MainPage()
        {
            InitializeComponent();
        }

        private void AddHobbyButtonClicked(object sender, EventArgs e)
        {
            hobbyCount++;
            var newHobbyEntry = new Entry { Placeholder = $"Hobby {hobbyCount}", x:Name = $"hobbyEntry{hobbyCount}" };
            hobbiesLayout.Children.Add(newHobbyEntry);
        }

        private async void SubmitButtonClicked(object sender, EventArgs e)
        {
            string name = nameEntry.Text;
            int age = int.Parse(ageEntry.Text);
            string occupation = occupationEntry.Text;
            string country = countryEntry.Text;
            string email = emailEntry.Text;

            CVModel cv = new CVModel()
            {
                Nombre = name,
                Edad = age,
                Ocupacion = occupation,
                Pais = country,
                Email = email
            };

            await Navigation.PushAsync(new CVPage(cv));
        }
    }
}