using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Profound.Views
{
    public partial class LogIn : ContentPage
    {
        public LogIn()
        {
            InitializeComponent();

            entry_studentNumber.Focused += (s, e) => lbl_studentNumber.TextColor = Color.FromHex("#ED4264");
            entry_studentNumber.Unfocused += (s, e) => lbl_studentNumber.TextColor = Color.FromHex("#333333");
            entry_studentNumber.Completed += (s, e) => entry_password.Focus();

            entry_password.Focused += (s, e) => lbl_password.TextColor = Color.FromHex("#ED4264");
            entry_password.Unfocused += (s, e) => lbl_password.TextColor = Color.FromHex("#333333");
        }
    }
}
