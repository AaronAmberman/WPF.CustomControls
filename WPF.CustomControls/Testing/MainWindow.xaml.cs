using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace Testing
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                string[] setDirs = Directory.GetDirectories(@"C:\Users\Aaron\AppData\Local\MTGA-DeckMaster\CardImages");

                foreach (string dir in setDirs)
                {
                    string[] cardDirs = Directory.GetDirectories(dir);

                    foreach (string cardDir in cardDirs)
                    {
                        string[] files = Directory.GetFiles(cardDir);

                        foreach (string file in files)
                        {
                            ZoomableListView.Items.Add(file);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
