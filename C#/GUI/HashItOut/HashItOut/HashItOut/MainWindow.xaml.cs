using Microsoft.Win32;
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
using HashItOut.ViewModels;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.ComponentModel;
using System.Security.Cryptography;

namespace HashItOut
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HashViewModel _viewModel;

        public MainWindow()
        {
            InitializeComponent();
            _viewModel = new HashViewModel();
            DataContext = _viewModel;
        }

        // Selects the source files to on board
        private void AddSrcFiles_Click(object sender, RoutedEventArgs e)
        {
            _viewModel = new HashViewModel();

            System.Windows.Forms.OpenFileDialog SelectFile = new System.Windows.Forms.OpenFileDialog
            {
                InitialDirectory = "C:\\",
                Filter = "All Files (*.*)|*.*",
                Title = "Select A File",
                Multiselect = true
            };
            SelectFile.ShowDialog();

            if (SelectFile.FileNames != null && SelectFile.FileNames.Length > 0)
            {
                foreach (string fn in SelectFile.FileNames)
                {
                    _viewModel.SourceFiles.Add(fn);
                    SourceFiles.ItemsSource = _viewModel.SourceFiles;
                }
            }
        }

        private void GetHashValues_Click(object sender, RoutedEventArgs e)
        {
            BeginOperation();
        }


        private void BeginOperation()
        {
            if (_viewModel.Results.Count > 0)
            {
                _viewModel.Results = new List<string>();
            }

            // if the MD5 option is selected
            if (_viewModel.MD5Selected)
            {
                foreach (string source in _viewModel.SourceFiles)
                {
                    using (MD5 _md5 = MD5.Create())
                    {
                        using (var stream = File.OpenRead(source))
                        {
                            _viewModel.Results.Add(BitConverter.ToString(_md5.ComputeHash(stream)).Replace("-", "‌​").ToLower());
                        }
                    }
                }
            }

            if (_viewModel.SHA1Selected)
            {
                foreach (string source in _viewModel.SourceFiles)
                {
                    using (var cryptoProvider = new SHA1CryptoServiceProvider())
                    {
                        using (var stream = File.OpenRead(source))
                        {
                            _viewModel.Results.Add(BitConverter.ToString(cryptoProvider.ComputeHash(stream)).Replace("-", "‌​").ToLower());
                        }
                    }
                }
            }
        }

        // UI Controls
        private void CloseApplication_Click(Object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        // Allows click + drag anywhere on form
        private void title_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Minimize(object sender, RoutedEventArgs e)
        {
            LayoutRoot.Visibility = Visibility.Hidden;
            this.WindowState = WindowState.Minimized;
        }
    }
}
