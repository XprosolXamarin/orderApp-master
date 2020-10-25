using orderApp.Models;
using orderApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace orderApp.View_Models
{
    class DashboardViewModel
    {
        public ObservableCollection<CategoriesModel> Categories { get; set; } = new ObservableCollection<CategoriesModel>();
        public ObservableCollection<LatestItemsModel> LatestItems { get; set; } = new ObservableCollection<LatestItemsModel>();

        public DashboardViewModel()
        {
            Categories.Add(new CategoriesModel
            {
                ImageUrl = "watch.png",
                categoryName = "Watch"
            });
            Categories.Add(new CategoriesModel
            {
                ImageUrl = "Shoes.png",
                categoryName = "Shoes"
            });
            Categories.Add(new CategoriesModel
            {
                ImageUrl = "Computer.png",
                categoryName = "Computer"
            });
            Categories.Add(new CategoriesModel
            {
                ImageUrl = "Shampoo.png",
                categoryName = "Shampoo"
            });
            Categories.Add(new CategoriesModel
            {
                ImageUrl = "Shirt.png",
                categoryName = "Shirt"
            });
            

            LatestItems.Add(new LatestItemsModel
            {
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcTaTr5QFYJ7hKGMSc44LmtHPm5QvNdPz00Nhw&usqp=CAU",
                Name = "Watches",
                Rating = "4.8",
                Price = "Rs/-200",
                Descrption = "Men Watches"

            });
            LatestItems.Add(new LatestItemsModel
            {
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQBtRAWt-FetGkt-YXmDdXwf2kzmJ1cjIdeWw&usqp=CAU",
                Name = "Watches",
                Rating = "4.8",
                Price = "Rs/-200",
                Descrption = "Men Watches"

            });
            LatestItems.Add(new LatestItemsModel
            {
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQ4VSFw47YTIWdUqLXM_w8i9nmVfRKaf_IlXg&usqp=CAU",
                Name = "Watches",
                Rating = "4.8",
                Price = "Rs/-200",
                Descrption = "Men Watches"

            });
        }
        public Command ViewCartCommand
        {
            get
            {
                return new Command(() =>
                {
                    Application.Current.MainPage = new NavigationPage(new CartPage());

                });
            }
        }
    }
}
