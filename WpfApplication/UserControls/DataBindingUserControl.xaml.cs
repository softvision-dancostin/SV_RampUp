using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication.UserControls
{
    /// <summary>
    /// Interaction logic for DataBindingUserControl.xaml
    /// </summary>
    public partial class DataBindingUserControl : UserControl
    {
        public DataBindingUserControl()
        {
            InitializeComponent();
            this.SetBindings();
        }

        private void SetBindings()
        {
            Binding b = new Binding();
            b.Converter = new MyDoubleConverter();
            b.Source = this.mySB;
            b.Path = new PropertyPath("Value");
            this.labelSBThumb.SetBinding(Label.ContentProperty, b);
        }
    }
}
