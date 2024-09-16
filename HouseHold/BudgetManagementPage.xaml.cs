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
using System.Collections.ObjectModel;

namespace AccountingApp
{
    /// <summary>
    /// BudgetManagementPage.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class BudgetManagementPage : Page
    {
        public ObservableCollection<BudgetItem> BudgetItems { get; set; }

        public BudgetManagementPage()
        {
            InitializeComponent();
            BudgetItems = new ObservableCollection<BudgetItem>();
            LoadBudgetItems();
            BudgetDataGrid.ItemsSource = BudgetItems;
        }

        private void LoadBudgetItems()
        {
            // 여기에서 실제 데이터를 로드하는 로직을 구현하세요.
            // 예시 데이터:
            BudgetItems.Add(new BudgetItem { Category = "식비", BudgetAmount = 500000, ActualSpending = 450000 });
            BudgetItems.Add(new BudgetItem { Category = "교통비", BudgetAmount = 25000, ActualSpending = 3500 });
        }
    }

    public class BudgetItem
    {
        public string Category { get; set; } = string.Empty;
        public decimal BudgetAmount { get; set; }
        public decimal ActualSpending { get; set; }
        public double ProgressPercentage => BudgetAmount != 0 ? Math.Min((double)ActualSpending / (double)BudgetAmount * 100, 100) : 0;
    }
}
