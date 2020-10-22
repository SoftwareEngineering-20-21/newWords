using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace NewWords
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            using(var dbConnect = new AppContext())
            {
                this.Title = "Working with db";
                Thread.Sleep(1000);
                dbConnect.Add(new Language { id = 0 , code="UKR"}) ;
                this.Title = "Added ukrainian";
                Thread.Sleep(1000);
                dbConnect.Add(new Language { code = "ENG" });
                this.Title = "Added english";
                dbConnect.SaveChanges();
                Thread.Sleep(1000);
                var langs = dbConnect.Languages;
                this.Title = langs.ToArray().ToString();
            }
            InitializeComponent();
        }
    }
}
