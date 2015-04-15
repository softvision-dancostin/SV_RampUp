using System;
using System.IO;
using System.Windows;
using System.Windows.Ink;
using System.Windows.Media;
using System.Windows.Controls;

namespace WpfApplication.UserControls
{
    public partial class InkUserControl : UserControl
    {
        public InkUserControl()
        {
            InitializeComponent();
            this.myInkCanvas.EditingMode = InkCanvasEditingMode.Ink;
            this.inkRadio.IsChecked = true;
            this.comboColors.SelectedIndex = 0;
        }

        private void RadioButtonClicked(object sender, RoutedEventArgs e)
        {
            switch ((sender as RadioButton).Content.ToString())
            {
                case "Ink Mode!":
                    this.myInkCanvas.EditingMode = InkCanvasEditingMode.Ink;
                    break;
                case "Erase Mode!":
                    this.myInkCanvas.EditingMode = InkCanvasEditingMode.EraseByStroke;
                    break;
                case "Select Mode!":
                    this.myInkCanvas.EditingMode = InkCanvasEditingMode.Select;
                    break;
            }
        }

        private void ColorChanged(object sender, SelectionChangedEventArgs e)
        {
            string colorToUse = (this.comboColors.SelectedItem as StackPanel).Tag.ToString();
            this.myInkCanvas.DefaultDrawingAttributes.Color = (Color)ColorConverter.ConvertFromString(colorToUse);
        }

        private void SaveData(object sender, System.Windows.RoutedEventArgs e)
        {
            using (FileStream fs = new FileStream("StrokeData.bin", FileMode.Create))
            {
                this.myInkCanvas.Strokes.Save(fs);
                fs.Close();
            }
        }

        private void LoadData(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                using (FileStream fs = new FileStream("StrokeData.bin", FileMode.Open, FileAccess.Read))
                {
                    StrokeCollection strokes = new StrokeCollection(fs);
                    this.myInkCanvas.Strokes = strokes;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void Clear(object sender, System.Windows.RoutedEventArgs e)
        {
            this.myInkCanvas.Strokes.Clear();
        }
    }
}
