using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinMenu1_github
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async private void btnRegister_Clicked(object sender, EventArgs e)
        {
            if (rePassword.IsVisible == false) 
            {
                await btnLogin.FadeTo(0, 500);
                await btnRegister.FadeTo(0, 500);
                await rePassword.FadeTo(0, 0); 
                rePassword.IsVisible = true;
                await rePassword.FadeTo(1, 500);
                btnLogin.Text = "REGISTER";
                await btnLogin.FadeTo(1, 500);
                btnRegister.Text = "LOGIN";
                await btnRegister.FadeTo(1, 500);
            }
            else
            {
                await btnLogin.FadeTo(0, 500);
                await btnRegister.FadeTo(0, 500);
                await rePassword.FadeTo(0, 500);
                rePassword.IsVisible = false;
                btnLogin.Text = "LOGIN";
                await btnLogin.FadeTo(1, 500);
                btnRegister.Text = "REGISTER";
                await btnRegister.FadeTo(1, 500);
            }
            //await image.FadeTo(1, 4000);
        }

    }
}
