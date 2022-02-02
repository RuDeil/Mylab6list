using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace Mylab6list
{ 
public class Phone
{
    public string Title { get; set; }
    public string ImagePath { get; set; }
    public string Company { get; set; }
    public int Price { get; set; }

}

public partial class MainPage : ContentPage
{

    public ObservableCollection<Phone> Phones { get; set; }
    public MainPage()
    {

        InitializeComponent();
        Phones = new ObservableCollection<Phone>
            {
                 new Phone {Title="RealMeXT", Company="RealMe", Price=20000, ImagePath="RealMeXT.jpg" },
                 new Phone {Title="Huawei", Company="Huawei", Price=35000, ImagePath="Huawai.jpg" },
                 new Phone {Title="HP Elite z3", Company="HP", Price=42000, ImagePath="HP.jpg"  },
                 new Phone {Title="LG G 6", Company="LG", Price=42000, ImagePath="lg.jpg"  },
                 new Phone {Title="iPhone 7", Company="Apple", Price=52000, ImagePath="iphone.jpg" }


            };
        this.BindingContext = this;
    }
    public async void OnItemTapped(object sender, ItemTappedEventArgs e)
    {
            if (e.Item is Phone selectedPhone)
            {
                await DisplayAlert("Выбранная модель", $"{selectedPhone.Company} - {selectedPhone.Title}", "OK");
            }
        }
    private void AddItem(object sender, EventArgs e)
    {
        Phones.Add(new Phone { Title = "Huawei P10", Company = "Huawei", Price = 35000, ImagePath = "lg.jpg" });
    }
    // удаление выделенного объекта
    private void RemoveItem(object sender, EventArgs e)
    {
            if (phonesList.SelectedItem is Phone phone)
            {
                Phones.Remove(phone);
                phonesList.SelectedItem = null;
            }
        }
}


}
