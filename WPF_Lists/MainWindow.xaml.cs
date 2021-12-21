using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace WPF_Lists
{
    public partial class MainWindow : Window
    {
        private List<Phone> _phones;
        
        public MainWindow()
        {
            InitializeComponent();

            _phones = new List<Phone>
            {
                new Phone()
                {
                    Name = "iPhone", 
                    Manufactured = "Apple", 
                    Price = 200000
                },
                new Phone()
                {
                    Name = "Galaxy", 
                    Manufactured = "Samsung", 
                    Price = 100000
                },
                new Phone()
                {
                    Name = "Oppo", 
                    Manufactured = "China", 
                    Price = 20000
                }
            };

            List_Phones.ItemsSource = _phones;
        }

        private void List_Phones_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected_index = (sender as ListBox).SelectedIndex;
            var phone = _phones[selected_index];
            Output.Content = $"{phone.Name} {phone.Manufactured} - {phone.Price}";
        }
    }
}