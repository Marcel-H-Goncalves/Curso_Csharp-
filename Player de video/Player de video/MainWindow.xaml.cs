﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace Player_de_video
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mediaElementVideo.LoadedBehavior = MediaState.Manual;
            sliderVolume.Value = 50;
            mediaElementVideo.Volume = sliderVolume.Value / 100;
        }

        private void sliderVolume_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            mediaElementVideo.Volume = sliderVolume.Value / 100;
        }

        private void buttonPlay_Click(object sender, RoutedEventArgs e)
        {
            mediaElementVideo.Play();
        }

        private void buttonPause_Click(object sender, RoutedEventArgs e)
        {
            mediaElementVideo.Pause();
        }

        private void buttonStop_Click(object sender, RoutedEventArgs e)
        {
            mediaElementVideo.Stop();
        }

        private void buttonAbrir_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "c:\\";
            ofd.Filter = "Arquivos MP4| *.mp4";
            if(ofd.ShowDialog() == true)
            {
                mediaElementVideo.Source = new Uri(ofd.FileName);
                mediaElementVideo.Play();
            }
        }
    }
}