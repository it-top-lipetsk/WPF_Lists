using System.Collections.Generic;
using System.Windows;

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
    }
}