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

namespace pz1_penkina
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string con;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            con = textBox1.Text + " " + textBox2.Text + "\n" + textBox3.Text + "\n" + textBox4.Text;
            listBox1.Items.Add(con);
        }
    }
    public class Contact
    {
        public string FirtsName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
    public class ContactList<T>
    {
        private List<T> contacts;
        public ContactList()
        {
            contacts = new List<T>();
        }
        public void AddContact(T contact)
        {
            contacts.Add(contact);
        }

    }
}

