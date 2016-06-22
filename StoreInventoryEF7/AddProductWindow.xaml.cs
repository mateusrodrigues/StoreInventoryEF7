using StoreInventoryEF7.Models;
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
using System.Windows.Shapes;

namespace StoreInventoryEF7
{
    /// <summary>
    /// Interaction logic for AddProductWindow.xaml
    /// </summary>
    public partial class AddProductWindow : Window
    {
        private InventoryContext _context;

        public AddProductWindow()
        {
            InitializeComponent();
            _context = new InventoryContext();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            _context.Products.Add(new Product
            {
                Name = txtName.Text,
                Quantity = int.Parse(txtQuantity.Text)
            });
            _context.SaveChanges();

            this.Close();
        }
    }
}
