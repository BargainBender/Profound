using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Profound
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            entry_studentNumber.Focused += (s,e) => lbl_studentNumber.TextColor = Color.FromHex("#ED4264");
            entry_studentNumber.Unfocused += (s,e) => lbl_studentNumber.TextColor = Color.FromHex("#333333");
            entry_studentNumber.Completed += (s,e) => entry_password.Focus();

            entry_password.Focused += (s, e) => lbl_password.TextColor = Color.FromHex("#ED4264");
            entry_password.Unfocused += (s, e) => lbl_password.TextColor = Color.FromHex("#333333");

        }

    }
}
