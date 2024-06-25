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

namespace pz2_penkina
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

            listBox1.Items.Add(textBox1.Text);

        }

        private void button2_Click_1(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Remove(textBox1.Text);

        }

        public class Task
        {
            public string Title { get; set; }
            public string Description { get; set; }
            public DateTime Deadline { get; set; }
            public bool IsCompleted { get; set; }
        }
        public class TaskList<T>
        {
            private List<T> tasks;
            public TaskList()
            {
                tasks = new List<T>();
            }
            public void AddTask(T task)
            {
                tasks.Add(task);
            }
            public void RemoveTask(T task)
            {
                tasks.Remove(task);
            }

        }
    }
}