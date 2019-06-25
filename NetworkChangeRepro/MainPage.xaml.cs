using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NetworkChangeRepro
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private void NetworkChange_NetworkAddressChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("changed");
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            try
            {
                NetworkChange.NetworkAddressChanged -= NetworkChange_NetworkAddressChanged;
                NetworkChange.NetworkAddressChanged += NetworkChange_NetworkAddressChanged;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
            }
        }
    }
}
