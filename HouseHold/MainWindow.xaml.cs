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
            if (sender is RadioButton clickedButton && clickedButton.Content is string content)
            {
                if (CurrentMenuLabel != null)
                {
                    CurrentMenuLabel.Text = content;
                }

                switch (content)
                {
                    case "대시보드":
                        MainFrame?.Navigate(new DashboardPage());
                        break;
                    case "거래 내역":
                        MainFrame?.Navigate(new TransactionHistoryPage());
                        break;
                    case "예산 관리":
                        MainFrame?.Navigate(new BudgetManagementPage());
                        break;
                    case "보고서":
                        MainFrame?.Navigate(new ReportPage());
                        break;
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