using DropShadowCrashDemo.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace DropShadowCrashDemo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public ObservableCollection<ItemViewModel> Collection { get; private set; }

        public MainPage()
        {
            this.InitializeComponent();

            FillRandomColors();
        }

        private void FillRandomColors()
        {
            var list = new List<ItemViewModel>();

            for (int i = 0; i < 10; i++)
            {
                list.Add(new ItemViewModel());
            }

            Collection = new ObservableCollection<ItemViewModel>(list);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Remove item at 0 and insert a new item
            Collection.RemoveAt(0);
            Collection.Insert(0, new ItemViewModel());
        }
    }
}