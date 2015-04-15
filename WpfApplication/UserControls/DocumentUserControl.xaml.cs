using System;
using System.IO;
using System.Windows;
using System.Windows.Media;
using System.Windows.Markup;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Annotations;
using System.Windows.Annotations.Storage;

namespace WpfApplication.UserControls
{
    public partial class DocumentUserControl : UserControl
    {
        public DocumentUserControl()
        {
            InitializeComponent();
            this.PopulateDocument();
            this.EnableAnnotations();

            btnSaveDoc.Click += (o, s) =>
            {
                using (FileStream fStream = File.Open("documentData.xaml", FileMode.Create))
                {
                    XamlWriter.Save(this.myDocumentReader.Document, fStream);
                }
            };

            btnLoadDoc.Click += (o, s) =>
            {
                using (FileStream fStream = File.Open("documentData.xaml", FileMode.Open))
                {
                    try
                    {
                        FlowDocument doc = XamlReader.Load(fStream) as FlowDocument;
                        this.myDocumentReader.Document = doc;
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message, "Error Loading Doc!"); }
                }
            };
        }

        private void PopulateDocument()
        {
            this.listOfFunFacts.FontSize = 14;
            this.listOfFunFacts.MarkerStyle = TextMarkerStyle.Circle;
            this.listOfFunFacts.ListItems.Add(new ListItem(new Paragraph(new Run("Fixed documents are for WYSIWYG print ready docs!"))));
            this.listOfFunFacts.ListItems.Add(new ListItem(new Paragraph(new Run("The API supports tables and embedded figures!"))));
            this.listOfFunFacts.ListItems.Add(new ListItem(new Paragraph(new Run("Flow documents are read only!"))));
            this.listOfFunFacts.ListItems.Add(new ListItem(new Paragraph(new Run("BlockUIContainer allows you to embed WPF controls in the document!"))));
            Run prefix = new Run("This paragraph was generated ");
            Bold b = new Bold();
            Run infix = new Run("dynamically");
            infix.Foreground = Brushes.Red;
            infix.FontSize = 30;
            b.Inlines.Add(infix);
            Run suffix = new Run(" at runtime!");
            this.paraBodyText.Inlines.Add(prefix);
            this.paraBodyText.Inlines.Add(infix);
            this.paraBodyText.Inlines.Add(suffix);
        }

        private void EnableAnnotations()
        {
            AnnotationService anoService = new AnnotationService(myDocumentReader);
            MemoryStream anoStream = new MemoryStream();
            AnnotationStore store = new XmlStreamStore(anoStream);
            anoService.Enable(store);
        }
    }
}
