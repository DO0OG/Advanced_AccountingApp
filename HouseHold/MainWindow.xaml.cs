using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media.Animation;
using System.Windows.Media;

namespace AccountingApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool isMenuOpen = true;

        public MainWindow()
        {
            InitializeComponent();
            LoadDashboard(); // 초기에 대시보드 페이지 로드
        }

        private void MenuToggleButton_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation
            {
                Duration = TimeSpan.FromSeconds(0.3),
                From = isMenuOpen ? 200 : 0,
                To = isMenuOpen ? 0 : 200
            };

            LeftMenu.BeginAnimation(WidthProperty, animation);
            isMenuOpen = !isMenuOpen;
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton clickedButton)
            {
                CurrentMenuLabel.Text = clickedButton.Content?.ToString() ?? string.Empty;

                switch (clickedButton.Content?.ToString())
                {
                    case "대시보드":
                        LoadDashboard();
                        break;
                    // 다른 메뉴 항목에 대한 케이스 추가
                    // ...
                }
            }
        }

        private void LoadDashboard()
        {
            MainFrame.Navigate(new DashboardPage());
        }

        private void TransactionTypeButton_Checked(object sender, RoutedEventArgs e)
        {
            ToggleButton clickedButton = sender as ToggleButton;
            if (clickedButton != null)
            {
            }
        }
    }
}