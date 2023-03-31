using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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
using MySql.Data.MySqlClient;

namespace InventoryManagementSystem
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		MySqlConnection con = new MySqlConnection("SERVER=localhost; DATABASE=productinformation; UID=root; PASSWORD=7!9H484m909K");

		public MainWindow()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			con.Open();
			MySqlCommand cmd = new MySqlCommand("SELECT * FROM product", con);
			MySqlDataReader reader = cmd.ExecuteReader();

			DataTable dt = new DataTable();
			dt.Load(reader);

			dtGrid.ItemsSource = dt.DefaultView;
		}
	}
}
