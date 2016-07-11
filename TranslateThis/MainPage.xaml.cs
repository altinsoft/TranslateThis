using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TranslateThis
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void TranslateButton_OnClicked(object sender, EventArgs e)
        {
            TranslateService service = new TranslateService();
            var translatedText = await service.TranslateString(FromEntry.Text, "de");
            TranslatedText.Text = translatedText;
        }
    }
}
