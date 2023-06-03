
using TevhidGundemiMobile.Model;
using TevhidGundemiMobile.Utils;

namespace TevhidGundemiMobile;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();//https://aka.ms/campus.jpg
        NewsReceiver nw = new NewsReceiver();
        listViewNews.ItemsSource = nw.GetNews();
    }
}

