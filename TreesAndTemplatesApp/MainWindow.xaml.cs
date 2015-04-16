using System.Windows;
using System.Windows.Media;

namespace TreesAndTemplatesApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private string dataToShow;

        private void btnShowLogicalTree_Click(object sender, RoutedEventArgs e)
        {
            dataToShow = "";
            BuildLogicalTree(0, this);
            this.txtDisplayArea.Text = dataToShow;
        }

        private void btnShowVisualTree_Click(object sender, RoutedEventArgs e)
        {
            dataToShow = "";
            BuildVisualTree(0, this);
            this.txtDisplayArea.Text = dataToShow;
        }

        void BuildLogicalTree(int depth, object obj)
        {
            dataToShow += new string(' ', depth) + obj.GetType().Name + "\n";
            if (!(obj is DependencyObject))
                return;
            foreach (object child in LogicalTreeHelper.GetChildren(
            obj as DependencyObject))
                BuildLogicalTree(depth + 5, child);
        }

        void BuildVisualTree(int depth, DependencyObject obj)
        {
            dataToShow += new string(' ', depth) + obj.GetType().Name + "\n";
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
                BuildVisualTree(depth + 1, VisualTreeHelper.GetChild(obj, i));
        }
    }
}
