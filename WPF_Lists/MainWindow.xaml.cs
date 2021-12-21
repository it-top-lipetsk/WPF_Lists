using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace WPF_Lists
{
    public partial class MainWindow : Window
    {
        private ObservableCollection<Phone> _phones;
        
        public MainWindow()
        {
            InitializeComponent();

            _phones = new ObservableCollection<Phone>
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
            Button_Del.IsEnabled = true;
        }

        private void Button_Add_OnClick(object sender, RoutedEventArgs e)
        {
            _phones.Add(new Phone
            {
                Name = Input_Name.Text,
                Manufactured = Input_Manufactured.Text,
                Price = Convert.ToInt32(Input_Price.Text)
            });
        }

        private void Button_Del_OnClick(object sender, RoutedEventArgs e)
        {
            var select = List_Phones.SelectedIndex;
            _phones.RemoveAt(select);
        }
    }
}