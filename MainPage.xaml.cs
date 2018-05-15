using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Recipe
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            int foodnum = new Random().Next(1, 6);
            Button button = sender as Button;
            if (foodnum == 1)
            {
                label.Text = "Todays Recipe is Sambhar rice and Egg fry";
            }
            else if (foodnum == 2)
            {
                label.Text = "Todays Recipe is Tamarind rice and beans";
            }
            else if (foodnum == 3)
            {
                label.Text = "Todays Recipe is Egg fried rice";
            }
            else if (foodnum == 4)
            {
                label.Text = "Todays Recipe is Ghee rice with potato fry";
            }
            else if (foodnum == 5)
            {
                label.Text = "Todays Recipe is Dosa with sambhar and chutney";
            }
        }
    }
}
