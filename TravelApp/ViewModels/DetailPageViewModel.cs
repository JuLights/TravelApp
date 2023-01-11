using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelApp.Models;

namespace TravelApp.ViewModels
{
    public partial class DetailPageViewModel : ObservableObject
    {
        [ObservableProperty]
        public string text;
        [ObservableProperty]
        public string imgSrc;

        public DetailPageViewModel(){}

        public DetailPageViewModel(Excitements exc)
        {
            Text = exc.Text;
            ImgSrc = exc.ImageSrc;
            //if (exc.Name.Contains("volc"))
            //{
            //    Text= exc.Text;
            //    ImgSrc = exc.ImageSrc;
            //    //text = exc.Text;
            //}
        }
    }
}
