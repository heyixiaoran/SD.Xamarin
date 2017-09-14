using System;
using SD.Xamarin.Common;
using SD.Xamarin.Views;

namespace SD.Xamarin.Models
{
    public class DataCabinModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string GroupName { get; set; }
        public DataCabinType DisplayType { get; set; }
    }
}