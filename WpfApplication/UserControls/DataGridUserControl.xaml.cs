using WpfApplication.Models;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace WpfApplication.UserControls
{
    public partial class DataGridUserControl : UserControl
    {
        public DataGridUserControl()
        {
            InitializeComponent();
            this.ConfigureGrid();
        }

        private void ConfigureGrid()
        {
            ObservableCollection<CarModel> dataToShow = new ObservableCollection<CarModel>();
            dataToShow.Add(new CarModel { CarID = 1, Make = "Ford", Color = "Yellow", PetName = "Rusty" });
            dataToShow.Add(new CarModel { CarID = 2, Make = "BMW", Color = "Black", PetName = "Hank" });
            dataToShow.Add(new CarModel { CarID = 3, Make = "BMW", Color = "Green", PetName = "Junior" });
            dataToShow.Add(new CarModel { CarID = 4, Make = "Ford", Color = "Red", PetName = "Snake" });
            dataToShow.Add(new CarModel { CarID = 5, Make = "Yugo", Color = "Pink", PetName = "Pinky" });
            this.gridInventory.ItemsSource = dataToShow;
        }
    }
}
