using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using TravelApp.Models;

namespace TravelApp.ViewModels
{
    public partial class CollectionPageViewModel : ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<Excitements> baliExcitements = new ObservableCollection<Excitements>();

        //[ObservableProperty]
        //public string name { get; set; }

        public CollectionPageViewModel()
        {
            baliExcitements.Add(new Excitements()
            {
                Name = "Surfing",
                IconSrc = "surfingicon.svg",
                 ImageSrc = "surfing.svg"
            });
            baliExcitements.Add(new Excitements()
            {
                Name = "bali volcano",
                IconSrc = "volcanoicon.svg",
                ImageSrc = "volcano.svg",
                Text = "Mount Agung in Bali is an active volcano that is on the brink of eruption. Seismologists are monitoring the volcano, which last erupted in 1963, after it started recording higher levels of activity in September 2017. \r\n\r\nLatest updates on activity and travel and evacuation warnings here Mount Agung in Bali is an active volcano that is on the brink of eruption. "
            });
            baliExcitements.Add(new Excitements()
            {
                Name = "zoo",
                IconSrc = "zooicon.svg",
                ImageSrc = "zoo.svg"
            });
            baliExcitements.Add(new Excitements()
            {
                Name = "rice fields",
                IconSrc = "fields.svg",
                ImageSrc = "fieldsicon.svg"
            });
            baliExcitements.Add(new Excitements()
            {
                Name = "diving",
                IconSrc = "divingicon.svg",
                ImageSrc = "diving.svg"
            });

        }
    }
}
