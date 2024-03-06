using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Shark
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private MainPageTimer mainPageTimer;
        public MainPage()
        {
            InitializeComponent();

            mainPageTimer = new MainPageTimer();
            BindingContext = mainPageTimer;
        }
        private void Button_ClickedStart(object sender, EventArgs e)
        {
            mainPageTimer.StartTimer();
        }
        private void Button_ClickedStop(object sender, EventArgs e)
        {
            mainPageTimer.StopTimer();
        }
        private void Button_ClickedReset(object sender, EventArgs e)
        {
            mainPageTimer.ResetTimer();
        }


    }
    
}
