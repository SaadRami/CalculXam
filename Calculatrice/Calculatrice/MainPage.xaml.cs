using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculatrice
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void onCalculatriceButtonClicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new Calculatrice());
        }
    }
}
