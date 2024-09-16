using System;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using AccountingApp;

namespace AccountingApp
{
    /// <summary>
    /// TransactionHistoryPage.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class TransactionHistoryPage : Page
    {
        public ObservableCollection<Transaction> Transactions { get; set; }

        public TransactionHistoryPage()
        {
            InitializeComponent();
            Transactions = new ObservableCollection<Transaction>();
            LoadTransactions();
            TransactionsDataGrid.ItemsSource = Transactions;
        }

        private void LoadTransactions()
        {
            Transactions.Add(new Transaction 
            { 
                Date = DateTime.Now, 
                Type = "지출", 
                Category = "식비", 
                Description = "점심", 
                Amount = -10000,
                PaymentMethod = "신용카드"
            }); // 임시 예시: 오늘의 점심 식사 지출

            Transactions.Add(new Transaction 
            { 
                Date = DateTime.Now.AddDays(-1), 
                Type = "수입", 
                Category = "급여", 
                Description = "월급", 
                Amount = 3000000,
                PaymentMethod = "계좌이체"
            }); // 임시 예시: 어제 받은 월급

            Transactions.Add(new Transaction 
            { 
                Date = DateTime.Now.AddDays(-2), 
                Type = "지출", 
                Category = "저축", 
                Description = "적금", 
                Amount = -500000,
                PaymentMethod = "자동이체"
            }); // 임시 예시: 이틀 전 적금 납입
        }
    }
}
