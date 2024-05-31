using System.Windows;

namespace _2301b2Wpf
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          
        
        string name = textBox1.Text;
            string age  = textBox2.Text;

            MessageBox.Show($"Hello, {name}");
            textBox1.Clear();
            textBox2.Clear();

            nameblock.Text =  "Name : "+name;
            ageblock.Text = "Age: "+age + "years old.";
        }
    }
}
